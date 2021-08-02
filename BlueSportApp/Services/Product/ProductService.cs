using BlueSportApp.Models;
using BlueSportApp.ModelsDTO;
using BlueSportApp.Services.API;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Services.Product
{
    public class ProductService : IProductService
    {
        private string _pathAPI;
        private readonly IAPIService _apiService;
        public ProductService(IAPIService apiService)
        {
            _apiService = apiService;
            _pathAPI = "https://virtserver.swaggerhub.com/lqphat/Bluesport/1.0.0/product";
        }
        public List<ProductModel> GetAll()
        {
            #region Declare data
            var data = new List<Models.ProductModel>();
            #endregion

            #region Get data from API to DTO

            var response = _apiService.GetDataFromAPI(_pathAPI);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.ProductDTO>>(response.Content);
            #endregion

            #region Mapping data from DTO to Model
            foreach (var item in dataDto)
            {
                data.Add(item.ToProductModel());
            };
            #endregion

            #region Return data
            return data;
            #endregion
        }
    }
}
