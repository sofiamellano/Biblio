using Microsoft.Extensions.Configuration;
using Service.Models;
using Service.Services;
using System.Text;
using System.Text.Json;

namespace BiblioTestProject
{
    public class UnitTestGenericService
    {
        // Test GetAllAsync method of GenericService
        [Fact]
        public async Task Test_GetAlAsync_ReturnListOfEntities()
        {
            //Arrange
            var service = new GenericService<Libro>();

            //Act 
            var result = await service.GetAllAsync();

            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<Libro>>(result);
            Assert.True(result.Count > 0);
        }
    }
}