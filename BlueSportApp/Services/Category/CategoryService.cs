using BlueSportApp.Models;
using BlueSportApp.ModelsDTO;
using BlueSportApp.Services.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private string _pathAPI;
        private readonly IAPIService _apiService;
        public CategoryService(IAPIService apiService)
        {
            _apiService = apiService;
            _pathAPI = "https://virtserver.swaggerhub.com/lqphat/Bluesport/1.0.0/category";
        }
        public List<CategoryModel> GetAll()
        {
            #region Declare data
            var data = new List<Models.CategoryModel>();
            #endregion

            #region Get data from API to DTO
            var response = _apiService.GetDataFromAPI(_pathAPI);
            var dataDto = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelsDTO.CategoryDTO>>(response.Content);
            #endregion

            var ParentCategory = dataDto.Where(C => C.Level == 0).ToList();
            var SubCategory = dataDto.Where(C => C.Level == 1).ToList();
            var LastCategory = dataDto.Where(C => C.Level == 2).ToList();

            #region Mapping data from DTO to Model
            foreach(var item in ParentCategory)
            {
                var itemParent = item.ToCategoryModel();

                var subCate = SubCategory.Where(c => c.ParentId == item.Id).ToList();
                foreach(var sub in subCate)
                {
                    var itemsub = sub.ToCategoryModel();

                    var lastCate = LastCategory.Where(c => c.ParentId == itemsub.Id).ToList();
                    foreach(var itemlast in lastCate)
                    {
                        itemsub.ListSubCategory.Add(itemlast.ToCategoryModel());
                    }
                    itemParent.ListSubCategory.Add(itemsub);
                }
                data.Add(itemParent);
            }
            #endregion

            #region Return data
            return data;
            #endregion

        }
    }
    
}
