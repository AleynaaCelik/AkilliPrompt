using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkilliPrompt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly string _apiUrl;
        private readonly string _clientId;
        private readonly string _clientSecret;

        public ApiController(IConfiguration configuration)
        {
            _apiUrl = configuration["Settings:ApiUrl"];
            _clientId = configuration["Settings:ClientId"];
            _clientSecret = configuration["Settings:ClientSecret"];
        }

        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            var apiService = new ApiService(_apiUrl, _clientId, _clientSecret);
            var data = await apiService.GetDataFromApiAsync();
            return Ok(data);
        }
    }

    public class ApiService
    {
        private readonly string _apiUrl;
        private readonly string _clientId;
        private readonly string _clientSecret;

        public ApiService(string apiUrl, string clientId, string clientSecret)
        {
            _apiUrl = apiUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        public async Task<string> GetDataFromApiAsync()
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(_apiUrl);
            return response;
        }
    }
}
