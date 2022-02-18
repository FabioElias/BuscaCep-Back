using System.Text.Json.Serialization;

namespace Teste.Back.End.Correios.Api.DTO.Correios
{
    public class AddressResponse
    {
        [JsonPropertyName("cep")]
        public string ZipCode { get; set; }
        [JsonPropertyName("logradouro")]
        public string Street { get; set; }
        [JsonPropertyName("complemento")]
        public string Complement { get; set; }
        [JsonPropertyName("bairro")]
        public string Neighborhood { get; set; }
        [JsonPropertyName("localidade")]
        public string City { get; set; }
        [JsonPropertyName("uf")]
        public string State { get; set; }
        [JsonPropertyName("ibge")]
        public  string Ibge { get; set; }
        [JsonPropertyName("gia")]
        public  string Gia { get; set; }
        [JsonPropertyName("ddd")]
        public  string Ddd { get; set; }
        [JsonPropertyName("siafi")]
        public  string Siafi { get; set; }
    }
}
