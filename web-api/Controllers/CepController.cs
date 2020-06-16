using apiService;
using apiService.Interfaces;
using cepService;
using Exceptions;
using Mappers;
using MongoRepository;
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
                _adressCepService = new AdressCepService(new ViaCepService(), new AdressCepMongoRepository());
                AdressCepViewModel viewModel = AdressCepMapper.ToAdressCepViewModel(_adressCepService.Get(cep), _adressCepService.GetCount(cep));
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
