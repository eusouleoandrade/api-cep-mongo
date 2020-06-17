using apiService.Interfaces;
using cepService.Interfaces;
using CommonRepository.Interfaces;
using Exceptions;
using models;
using System;

namespace apiService
{
    public class AdressCepService : IAdressCepService
    {
        private readonly ICepService _cepService;
        private readonly IAdressCepRepository _repository;

        public AdressCepService(ICepService cepService, IAdressCepRepository repository)
        {
            _cepService = cepService;
            _repository = repository;
        }

        public AdressCep Get(string cep)
        {
            if (!_cepService.IsValid(cep))
                throw new AdressCepServiceException("Invalid CEP");

            AdressCep adressCep = _cepService.GetAdressCep(cep);

            if (adressCep == null || !adressCep.IsValid())
                throw new AdressCepServiceException("Failed to query CEP");

            Save(adressCep);

            return adressCep;
        }

        public long GetCount(string cep)
        {
            if (!_cepService.IsValid(cep))
                throw new AdressCepServiceException("Invalid CEP");

            return _repository.GetCount(cep);
        }

        public void Save(AdressCep adressCep)
        {
            if (adressCep == null || !adressCep.IsValid())
                throw new AdressCepServiceException("Failed to query CEP");

            _repository.Save(Sanitize(adressCep));
        }

        private AdressCep Sanitize(AdressCep adressCep)
        {
            adressCep.Cep = adressCep.Cep.Replace("-", "");

            return adressCep;
        }
    }
}
