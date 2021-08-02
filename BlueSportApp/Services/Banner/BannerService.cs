using BlueSportApp.Models;
using BlueSportApp.ModelsDTO;
using BlueSportApp.Services.API;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Services.Banner
{
    public class BannerService : IBannerService
    {
        private string _pathAPI;
        private readonly IAPIService _apiService;
        public BannerService(IAPIService apiService)
        {
            _apiService = apiService;
            _pathAPI = "https://virtserver.swaggerhub.com/lqphat/Bluesport/1.0.0/banner";
        }
        public List<Models.BannerModel> GetAll()
        {
            #region Declare data
            var data = new List<Models.BannerModel>();
            #endregion

            #region Get data from API to DTO
            var response = _apiService.GetDataFromAPI(_pathAPI);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.BannerDTO>>(response.Content);
            #endregion

            #region Mapping data from DTO to Model
            foreach (var item in dataDto)
            {
                data.Add(item.ToBannerModel());
            }
            #endregion

            #region Return data
            return data;
            #endregion
        }

    }
}
