using AutoMapper;
using models;

namespace Mappers
{
    public class AdressViaCepMapper
    {
        public static AdressCep ToAdressCep(AdressViaCep model)
        {
            IMapper mapper = AdressViaCepForAdressCepConfig().CreateMapper();
            AdressCep adressCep = mapper.Map<AdressCep>(model);

            return adressCep;
        }

        private static MapperConfiguration AdressViaCepForAdressCepConfig()
        {
            return new MapperConfiguration(m =>
            {
                m.CreateMap<AdressViaCep, AdressCep>()
                .ForMember(dst => dst.Rua, map => map.MapFrom(src => src.logradouro))
                .ForMember(dst => dst.Cidade, map => map.MapFrom(src => src.localidade))
                .ForMember(dst => dst.Estado, map => map.MapFrom(src => src.uf));
            });
        }
    }
}
