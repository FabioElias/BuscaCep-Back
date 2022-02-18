using System.Text.Json.Serialization;

namespace Teste.Back.End.Correios.Api.DTO.Error
{
    /// <summary>
    /// Classe responsavel por descrever um erro
    /// </summary>
    public class ErrorDescription
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="error"></param>
        public ErrorDescription(string error)
        {
            Error = error;
        }

        /// <summary>
        /// Erro
        /// </summary>
        [JsonPropertyName("erro")]
        public string Error { get; set; }
    }
}
