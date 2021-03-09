using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wh4Shop.AppCore.Common;
using wh4Shop.AppCore.Services;
using wh4Shop.AppCore.ViewModel;

namespace wh4Shop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IUserServices _userServices;

        public UserController(ILogger<UserController> logger,
                                IUserServices userServices)
        {
            _logger = logger;
            _userServices = userServices;

        }

        [HttpGet]
        public async Task<Response<UserViewModel>> Get([FromForm]UserRequest userRequest)
        {
            try
            {
                var data = await _userServices.createUser(userRequest);

                return data;
            }
            catch (Exception ex)
            {
                var result = new Response<UserViewModel>();
                result.payload = null;
                result.message = ex.Message.ToString();
                result.success = false;

                throw;
            }
        }
    }
}
