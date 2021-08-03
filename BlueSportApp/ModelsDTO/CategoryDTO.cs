using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.ModelsDTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int Level { get; set; }
        public List<Models.CategoryModel> ListSubCategory { get; set; }
    }

    public static class CategoryDTOExt
    {
        public static Models.CategoryModel ToCategoryModel(this CategoryDTO categoryDTO)
        {
            return new Models.CategoryModel()
            {
                Id = categoryDTO.Id,
                Level = categoryDTO.Level,
                Name = categoryDTO.Name,
                ParentId = categoryDTO.ParentId,
                ListSubCategory = new List<Models.CategoryModel>()
            };
        }
    }
}
