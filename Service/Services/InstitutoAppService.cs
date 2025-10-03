using Microsoft.Extensions.Configuration;
using Service.Interfaces;
using Service.Models.InstitutoApp;
using Service.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Service.Services
{
    public class InstitutoAppService : IInstitutoAppService
    {
        private readonly IConfiguration _configuration;
        private readonly JsonSerializerOptions _options;
        private readonly HttpClient _httpClient = new HttpClient();
        public InstitutoAppService(IConfiguration configuration)
        {
            _configuration = configuration;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<Usuario?> GetUsuarioByEmailAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("El email no puede estar vacío.", nameof(email));
            }
            try 
            {
                var UrlApi = _configuration["UrlInstitutoApp"];
                var endpoint = ApiEndpoints.GetEndpoint("UsuarioInstitutoApp");
                
                var response = await _httpClient.GetAsync($"{UrlApi}{endpoint}/getbyemail?email={email}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var usuario = JsonSerializer.Deserialize<Usuario>(result, _options);
                    return usuario;
                }
                else
                {
                    throw new Exception($"Error en la respuesta de la API:{response.StatusCode} -{response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario." + ex.Message);
            }
        }
    }
}
