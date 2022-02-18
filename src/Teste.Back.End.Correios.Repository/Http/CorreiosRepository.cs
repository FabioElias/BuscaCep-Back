using Atendimento.Cliente.Bff.For.Order.Domain.Contracts.Repository.Http;
using Atendimento.Cliente.Bff.For.Order.Domain.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Atendimento.Cliente.Bff.For.Order.Repository.Http
{
    public class CorreiosRepository : ICorreiosRepository
    {
        private readonly HttpClient _clientFactory;
        private readonly IConfiguration _configuration;

        public CorreiosRepository(HttpClient clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
            _clientFactory.BaseAddress = new Uri(_configuration.GetSection("Correios")["BaseUrl"]);
        }

        public async Task<Address> GetAddressByZipCodeAsync(string zipCode)
        {

            var url = $"{zipCode}/json";
            var response = await _clientFactory.GetAsync(url);
            var result = await JsonSerializer.DeserializeAsync<Address>(await response.Content.ReadAsStreamAsync());
            return result; 
        }
    }
}