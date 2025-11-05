using System.Text.Json.Serialization;

namespace ControleClientes
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; }
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }
        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }
        [JsonPropertyName("localidade")]
        public string Cidade { get; set; }
        [JsonPropertyName("uf")]
        public string Uf { get; set; }
        [JsonPropertyName("estado")]
        public string Estado { get; set; }
        [JsonPropertyName("numero")]
        public string Numero { get; set; }
        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }


    }
}