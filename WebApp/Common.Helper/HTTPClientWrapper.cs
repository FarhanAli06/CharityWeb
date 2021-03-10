using Model.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public class HTTPClientWrapper: IHTTPClientHelper
    {
        #region Abstract, Async, static HTTP functions for GET, POST, PUT, DELETE          
        public Task DeleteRequest<T>(string apiUrl, T postObject)
        {
            throw new NotImplementedException();
        }
        public async Task<T> GetAsync<T>(string url)
        {
            T data = default(T);
            try
            {
                using (var client = new HttpClient())
                {                              
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    using (HttpContent content = response.Content)
                    {
                        string d = await content.ReadAsStringAsync();
                        if (d != null)
                        {
                            data = JsonConvert.DeserializeObject<T>(d);
                            return (T)data;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            Object o = new Object();
            return (T)o;
        }

        public Task<T> GetById<T>(string apiUrl, int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> PostAsync<T>(string url, T postObject)
        {
            throw new NotImplementedException();
        }

        public Task PutRequest<T>(string apiUrl, T postObject)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
