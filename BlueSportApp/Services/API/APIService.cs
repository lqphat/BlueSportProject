using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Services.API
{
    public class APIService : IAPIService
    {
        public IRestResponse GetDataFromAPI(string path)
        {
            var client = new RestClient(path);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            return client.Execute(request);
        }
    }
}
