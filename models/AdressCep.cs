using Newtonsoft.Json;
using System;

namespace models
{
    public class AdressCep
    {
        public string Cep { get; set; } = String.Empty;

        public string Rua { get; set; } = String.Empty;

        public string Complemento { get; set; } = String.Empty;

        public string Bairro { get; set; } = String.Empty;

        public string Cidade { get; set; } = String.Empty;

        public string Estado { get; set; } = String.Empty;

        public string Unidade { get; set; } = String.Empty;

        public string Ibge { get; set; } = String.Empty;

        public string Gia { get; set; } = String.Empty;

        public bool IsValid()
        {
            return this != null && !String.IsNullOrEmpty(Cep);
        }
    }
}
