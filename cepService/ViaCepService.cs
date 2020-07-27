using Exceptions;
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
            try
            {
                _client = new HttpClient
                {
                    BaseAddress = new Uri("https://viacep.com.br/ws/")
                };
                _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
            catch (Exception ex)
            {
                if (_client != null)
                    _client.Dispose();

                throw new ViaCepServiceException(ex);
            }

        }

        public override AdressCep GetAdressCep(string cep)
        {
            try
            {
                HttpResponseMessage response = _client.GetAsync($"{cep}/json/").Result;

                if (response.IsSuccessStatusCode)
                {
                    var adressViaCepResponse = JsonConvert.DeserializeObject<AdressViaCep>(response.Content.ReadAsStringAsync().Result);

                    return adressViaCepResponse.ToAdressCep();
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new ViaCepServiceException(ex);
            }
            finally
            {
                if (_client != null)
                    _client.Dispose();
            }
        }
    }
}
