using Microsoft.AspNetCore.Mvc;

namespace dpd_api.Controllers
{
    public class BaseController : ControllerBase
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string UserName { get; set; }
        public string Password { get; set; }


        private readonly IConfiguration _configuration;

        public BaseController(IConfiguration configuration)
        {
            _configuration = configuration;

            var baseUrl = _configuration.GetValue<string>("Dpd:BaseUrl");
            var userName = _configuration.GetValue<string>("Dpd:UserName");
            var password = _configuration.GetValue<string>("Dpd:Password");

            if (baseUrl == null || userName == null || password == null)
            {
                throw new Exception("Configuration is incorrect");
            }

            BaseUrl = baseUrl;
            UserName = userName;
            Password = password;
        }
    }
}
