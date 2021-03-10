using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper.IServices
{
    public interface IHTTPClientService
    {
        Task<WeatherForecast> GetAsync(string url);
    }
}
