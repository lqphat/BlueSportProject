using BlueSportApp.Models;
using BlueSportApp.ModelsDTO;
using BlueSportApp.Services.API;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Services.Store
{
    public class StoreService : IStoreService
    {
        private string _pathAPI;
        private readonly IAPIService _apiService;
        public StoreService(IAPIService apiService)
        {
            _apiService = apiService;
            _pathAPI = "https://virtserver.swaggerhub.com/lqphat/Bluesport/1.0.0/store";
        }
        public List<StoreModel> GetAll()
        {
            #region Declare data
            var data = new List<Models.StoreModel>();
            #endregion

            #region Get data from API to DTO
            var response = _apiService.GetDataFromAPI(_pathAPI);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.StoreDTO>>(response.Content);
            #endregion

            #region Mapping data from DTO to Model
            foreach (var item in dataDto)
            {
                data.Add(item.ToStoreModel());
            }
            #endregion

            #region Return data
            return data;
            #endregion
        }

        public StoreModel GetById(string id)
        {
            #region Declare data
            #endregion

            #region Get data from API to DTO
            var response= _apiService.GetDataFromAPI($"{_pathAPI}/{id}");

            var listStore = GetAll();
            var dataDto = listStore.Where(s => s.Id == id).FirstOrDefault();

            #endregion

            #region Mapping data from DTO to Model
            #endregion

            #region Return data
            return dataDto;
            #endregion
        }
    }
}
