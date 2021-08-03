using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Services.Category
{
    public interface ICategoryService
    {
        public List<Models.CategoryModel> GetAll();
    }
}
