﻿using apiService;
using apiService.Interfaces;
using cepService;
using Exceptions;
using Mappers;
using MongoRepository;
using Newtonsoft.Json.Linq;
using System;
using System.Web.Http;
using System.Web.Http.Description;
using ViewModel;

namespace web_api.Controllers
{
    [RoutePrefix("api/cep")]
    public class CepController : ApiController
    {
        private IAdressCepService _adressCepService;

        [Route("{cep}")]
        [ResponseType(typeof(AdressCepViewModel))]
        public IHttpActionResult Get(string cep)
        {
            try
            {
                _adressCepService = new AdressCepService(new WebManiaCepService(), new AdressCepMongoRepository());
                AdressCepViewModel viewModel = _adressCepService.Get(cep).ToAdressCepViewModel(_adressCepService.GetCount(cep));
                JObject objectJsonExpectedResult = new JObject();
                objectJsonExpectedResult.Add("bairro", "Rio Doce");
                objectJsonExpectedResult.Add("cep", "53080800");
                objectJsonExpectedResult.Add("cidade", "Olinda");
                objectJsonExpectedResult.Add("complemento", "IV Etapa");
                objectJsonExpectedResult.Add("count", "10");
                objectJsonExpectedResult.Add("estado", "PE");
                objectJsonExpectedResult.Add("gia", "");
                objectJsonExpectedResult.Add("ibge", "");
                objectJsonExpectedResult.Add("rua", "Avenida Das Garças");
                objectJsonExpectedResult.Add("unidade", "");
                return Ok(viewModel.ToJObject());
            }
            catch (ApiException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
