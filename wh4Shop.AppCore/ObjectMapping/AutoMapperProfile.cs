namespace wh4Shop.AppCore.Mapping
{
    using AutoMapper;
    using ViewModel;
    using wh4Shop.DataEntity.EntityModels;
    using wh4Shop.AppCore.Services;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserViewModel, AppUser>();

            CreateMap<UserRequest, AppUser>();
        }
    }
}
