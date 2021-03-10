using Common.Helper.IServices;
using Microsoft.Extensions.Configuration;
using Model.Models;
using System.Threading.Tasks;

namespace Common.Helper
{
    public class HTTPClientService :IHTTPClientService
    {
        private readonly IHTTPClientHelper _clientHelper;
        private static IConfiguration configuration;
        ConfigurationSettings settings;
        public HTTPClientService() { }

        public HTTPClientService(IConfiguration iconfiguration, IHTTPClientHelper clientHelper)
        {
            configuration = iconfiguration;
            _clientHelper = clientHelper;
        }

        public async Task<WeatherForecast> GetAsync(string url )
        {
            settings = new ConfigurationSettings();
            //configuration.GetValue<ConfigurationSettings>("ApplicationSettings:ConfigurationSettings");
           // $"{settings.ApiURL}/weatherforecast";
            var resultset = await _clientHelper.GetAsync<WeatherForecast>(url);
            return resultset;
        }       
    }
}
