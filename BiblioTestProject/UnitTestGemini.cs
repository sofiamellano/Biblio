using Microsoft.Extensions.Configuration;
using Service.Services;
using System.Text;
using System.Text.Json;

namespace BiblioTestProject
{
    public class UnitTestGemini
    {
        [Fact]
        public async Task TestObtenerResumenLibroIA()
        {
            //leemos la api key desde appsettings.json
            var configuration = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                  .AddEnvironmentVariables()
                  .Build();

            var apiKey = configuration["ApiKeyGemini"];
            var url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key= " + apiKey;

            var prompt = $"Me puedes dar un resumen de 100 palabras como m�ximo del libro Sin Red: Nadal, Federer y la historia detr�s del duelo que cambi� el tenis";

            var payload = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new { text = prompt }
                        }
                    }
                }
            };

            var json = JsonSerializer.Serialize(payload);
            using var client = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            var result = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(result);
            var texto = doc.RootElement
               .GetProperty("candidates")[0]
               .GetProperty("content")
               .GetProperty("parts")[0]
               .GetProperty("text")
               .GetString();

            Console.WriteLine($"Respuesta de IA: {texto}");
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task TestServicioGemini()
        {
            //leemos la api key desde appsettings.json
            var configuration = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                  .AddEnvironmentVariables()
                  .Build();
            var prompt = $"Me puedes dar un resumen de 100 palabras como m�ximo del libro Sin Red: Nadal, Federer y la historia detr�s del duelo que cambi� el tenis";
            var servicio = new GeminiService(configuration);
            var resultado = await servicio.GetPrompt(prompt);
            Console.WriteLine($"Respuesta de IA desde servicio: {resultado}");
            Assert.NotNull(resultado);
        }

    }
}