using AutoMapper;
using models;
using ViewModel;

namespace Mappers
{
    public static class AdressCepMapper
    {
        public static AdressCepViewModel ToAdressCepViewModel(AdressCep model, long count)
        {
            IMapper mapper = AdressCepForAdressCepViewModelConfig().CreateMapper();
            AdressCepViewModel vm = mapper.Map<AdressCepViewModel>(model);
            vm.count = count.ToString();
            return vm;
        }

        public static AdressCep ToModel(AdressCepViewModel viewModel)
        {
            IMapper mapper = AdressCepForAdressCepViewModelConfig().CreateMapper();
            AdressCep model = mapper.Map<AdressCep>(viewModel);
            return model;
        }

        private static MapperConfiguration AdressCepForAdressCepViewModelConfig()
        {
            return new MapperConfiguration(m =>
            {
                m.CreateMap<AdressCep, AdressCepViewModel>();
                m.CreateMap<AdressCepViewModel, AdressCep>();
            });
        }
    }
}
