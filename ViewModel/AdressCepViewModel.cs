using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ViewModel
{
    public class AdressCepViewModel
    {
        [JsonProperty("cep")]
        public string cep { get; set; }

        [JsonProperty("rua")]
        public string rua { get; set; }

        [JsonProperty("complemento")]
        public string complemento { get; set; }

        [JsonProperty("bairro")]
        public string bairro { get; set; }

        [JsonProperty("cidade")]
        public string cidade { get; set; }

        [JsonProperty("estado")]
        public string estado { get; set; }

        [JsonProperty("unidade")]
        public string unidade { get; set; }

        [JsonProperty("ibge")]
        public string ibge { get; set; }

        [JsonProperty("gia")]
        public string gia { get; set; }

        [JsonProperty("count")]
        public string count { get; set; }

        public JObject ToJObject()
        {
            return JObject.Parse(JsonConvert.SerializeObject(this));
        }
    }
}
