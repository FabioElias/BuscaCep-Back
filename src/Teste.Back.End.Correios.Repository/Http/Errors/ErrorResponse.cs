using System.Text.Json.Serialization;

namespace Atendimento.Cliente.Bff.For.Order.Repository.Http.Errors
{
    public class ErrorResponse
    {
        /// <summary>
        /// Erro
        /// </summary>
        [JsonPropertyName("erro")]
        public string Error { get; set; }
    }
}
