namespace wh4Shop.AppCore.Services
{
    using System.Threading.Tasks;
    using wh4Shop.AppCore.Common;
    using wh4Shop.AppCore.ViewModel;
    public interface IUserServices
    {
        Task<Response<UserViewModel>> createUser(UserRequest userRequest);

    }
}
