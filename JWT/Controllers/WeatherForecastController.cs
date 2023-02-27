using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using JWT.Token;

namespace JWT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly FakeData _fakeData;


        public WeatherForecastController(FakeData fakeData)
        {
            _fakeData = fakeData;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        [Authorize]
        public IActionResult Get(FakeData data)
        {
            if (data.Name == data.Mdp)
            {
                return new ObjectResult(GenerateTokenClass.GenerateToken(data.Name));
            }
            return BadRequest();
        }
    }

}