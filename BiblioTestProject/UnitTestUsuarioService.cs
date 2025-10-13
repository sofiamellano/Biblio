using Microsoft.Extensions.Configuration;
using Service.DTOs;
using Service.Models;
using Service.Services;
using System.Text;
using System.Text.Json;

namespace BiblioTestProject
{
    public class UnitTestUsuarioService
    {
        [Fact]
        public async Task Test_GetAlAsync_ReturnListOfEntities()
        {
            //Arrange

            await LoginTest();
            var service = new UsuarioService();
            var result = await service.GetAllAsync();


            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<Usuario>>(result);
            Assert.True(result.Count > 0);
        }

        private async Task LoginTest()
        {
            var serviceAuth = new AuthService();
            var token = await serviceAuth.Login(new LoginDTO
            {
                Username = "sofiimellano@gmail.com",
                Password = "123456"
            });
        }

        [Fact]
        public async Task Test_GetByEmailAsync()
        {
            await LoginTest();
            var service = new UsuarioService();
            var result = await service.GetByEmailAsync("sofiimellano@gmail.com");

            Assert.NotNull(result);
            Assert.IsType<Usuario>(result);
            Assert.Equal("sofiimellano@gmail.com", result.Email);
        }
    }
}