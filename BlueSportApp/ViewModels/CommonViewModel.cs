using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.ViewModels
{
    public class CommonViewModel
    {
        public List<Models.CategoryModel> ListCategory { get; set; }
        public CommonViewModel()
        {
            ListCategory = new List<Models.CategoryModel>();
        }
    }
}
