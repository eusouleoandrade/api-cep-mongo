using cepService.Interfaces;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiService.Interfaces
{
    public interface IAdressCepService
    {
        AdressCep Get(string cep);
        long GetCount(string cep);
        void Save(AdressCep adressCep);
    }
}
