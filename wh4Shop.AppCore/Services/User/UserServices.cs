namespace wh4Shop.AppCore.Services
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Identity;
    using wh4Shop.DataEntity.EntityModels;
    using wh4Shop.AppCore.Common;
    using wh4Shop.AppCore.ViewModel;
    public class UserServices : IUserServices
    {
        private readonly IMapper _mapper;

        private readonly UserManager<AppUser> _userManager;

        public UserServices(IMapper mapper, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<Response<UserViewModel>> createUser(UserRequest userRequest)
        {

            var result = new Response<UserViewModel>();

            try
            {
                var findUsernameExist = await _userManager.FindByNameAsync(userRequest.UserName);
                var findEmailExist = await _userManager.FindByNameAsync(userRequest.UserName);

                if (findUsernameExist != null || findEmailExist != null)
                {
                    result.message = "UserName or Email is Exist";
                    result.payload = null;
                    result.success = false;

                    return result;
                }


                AppUser nUser = _mapper.Map<AppUser>(userRequest);


                var data = await _userManager.CreateAsync(nUser, userRequest.Password);

                result.message = data.Succeeded ? "OK" : data.Errors.ToString();
                result.payload = data.Succeeded ? _mapper.Map<UserViewModel>(nUser) : null;
                result.success = data.Succeeded;

                return result;
            }
            catch (Exception ex)
            {
                result.message = ex.Message.ToString();
                result.payload = null;
                result.success = false;

                return result;
                throw;
            }
        }
    }
}
