using BusinessLogic.IService;
using Common.Helper;
using Model.Models;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class HomeService : IHomeService
    {
        //private readonly IHomeDALService _homeDalService;

        #region Home
        public async Task<WeatherForecast> CallApiMethodAsync()
        {
            //string url = "https://localhost:44306/weatherforecast";
            //var result = await _httpClient.GetAsync<WeatherForecast>(url);
            //return result;
            return null;
        }
        #endregion 
    }
}
