using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Services.API
{
    public interface IAPIService
    {
        public IRestResponse GetDataFromAPI(string path);
    }
}
