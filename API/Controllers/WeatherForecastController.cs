using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace API.Controllers
{
    [ApiController]
    [Route("/")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
   

       public WeatherForecastController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }



        [HttpGet]
       public WeatherForecast Get()
        {

            var  weatherForecast = _weatherService.GetWeather();
            
            return weatherForecast;
        }
    }
}
