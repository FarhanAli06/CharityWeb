using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public interface IHTTPClientHelper
    {
        Task<T> GetAsync<T>(string url);
        Task<T> PostAsync<T>(string url, T postObject);
        Task PutRequest<T>(string apiUrl, T postObject);
        Task DeleteRequest<T>(string apiUrl, T postObject);
        Task<T> GetById<T>(string apiUrl, int id);
    }
}
