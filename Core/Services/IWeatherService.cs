using System;
using System.Threading.Tasks;
using Core.Models;
using NHibernate;
using Npgsql;

namespace Core.Services
{

    public interface IWeatherService
    {
        WeatherForecast GetWeather();
    };



    public class WeatherService : IWeatherService
    {

        private ISessionFactory _sessionFactory;

        public WeatherService(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }




       public  WeatherForecast GetWeather()
        {

            using (ISession session = _sessionFactory.OpenSession())
            {
                var weather = session.Get<WeatherForecast>(1);
                return weather;
            }
        }
    }
}
