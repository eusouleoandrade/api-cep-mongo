using Mappers;
using models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace cepService
{
    public class ViaCepService : CepService
    {
        private readonly HttpClient _client;

        public ViaCepService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://viacep.com.br/ws/")
            };
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public override AdressCep GetAdressCep(string cep)
        {
            HttpResponseMessage response = _client.GetAsync(cep + "/json/").Result;

            if (response.IsSuccessStatusCode)
            {
                var adressViaCep = JsonConvert.DeserializeObject<AdressViaCep>(response.Content.ReadAsStringAsync().Result);

                return AdressViaCepMapper.ToAdressCep(adressViaCep);
            }
            else
                return null;
        }
    }
}
