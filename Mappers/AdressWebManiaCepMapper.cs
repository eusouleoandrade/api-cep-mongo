using AutoMapper;
using models;

namespace Mappers
{
    public static class AdressWebManiaCepMapper
    {
        public static AdressCep ToAdressCep(this AdressWebManiaCep model)
        {
            IMapper mapper = AdressWebManiaCepForAdressCepConfig().CreateMapper();
            AdressCep adressCep = mapper.Map<AdressCep>(model);

            return adressCep;
        }

        private static MapperConfiguration AdressWebManiaCepForAdressCepConfig()
        {
            return new MapperConfiguration(m =>
            {
                m.CreateMap<AdressWebManiaCep, AdressCep>()
                .ForMember(dst => dst.Rua, map => map.MapFrom(src => src.endereco))
                .ForMember(dst => dst.Estado, map => map.MapFrom(src => src.uf));
            });
        }
    }
}
