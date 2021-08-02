using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Models
{
    public class CategoryModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int Level { get; set; }
        public List<SubCategoryModel> ListSubCategory { get; set; }
    }

    public class SubCategoryModel
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int Level { get; set; }
        public List<SubLastCategoryModel> ListLastCategory { get; set; }
    }

    public class SubLastCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int Level { get; set; }
    }
    


}
