using cepService.Interfaces;
using models;
using System;

namespace cepService
{
    public abstract class CepService : ICepService
    {
        public abstract AdressCep GetAdressCep(string cep);

        public virtual bool IsValid(string cep)
        {
            bool valid = true;

            if (cep.Length != 8)
                valid = false;

            if (String.IsNullOrEmpty(cep))
                valid = false;

            if (!int.TryParse(cep, out _))
                valid = false;

            return valid;
        }
    }
}
