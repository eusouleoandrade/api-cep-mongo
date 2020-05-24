using Mappers;
using models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace cepService
{
    public class WebManiaCepService : CepService
    {
        private readonly HttpClient _client;
        private readonly string _appKey = Properties.Settings.Default.appKeyWebManiaCep;
        private readonly string _appSecret = Properties.Settings.Default.appSecretWeManiaCep;

        public WebManiaCepService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://webmaniabr.com/api/1/cep/")
            };
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public override AdressCep GetAdressCep(string cep)
        {
            HttpResponseMessage response = _client.GetAsync(String.Format("{0}/?app_key={1}&app_secret={2}", cep, _appKey, _appSecret)).Result;

            if (response.IsSuccessStatusCode)
            {
                var adressWMCep = JsonConvert.DeserializeObject<AdressWebManiaCep>(response.Content.ReadAsStringAsync().Result);

                return AdressWebManiaCepMapper.ToAdressCep(adressWMCep);
            }
            else
                return null;
        }
    }
}
