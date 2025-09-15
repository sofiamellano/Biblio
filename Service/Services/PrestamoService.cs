﻿using Service.Interfaces;
using Service.Models;
using Service.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PrestamoService : GenericService<Prestamo>, IPrestamoService
    {

        public PrestamoService(HttpClient? httpClient = null) : base(httpClient)
        {
        }
        public async Task<List<Prestamo>?> GetByUsuarioAsync(int idUsuario)
        {
            SetAuthorizationHeader();
            var response = await _httpClient.GetAsync($"{_endpoint}/byusuario?idusuario={idUsuario}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error al obtener los datos: {response.StatusCode}");
            }
            return JsonSerializer.Deserialize<List<Prestamo>>(content, _options);
        }
    }
}
