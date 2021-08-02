using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.ViewModels
{
    public class HomeViewModel
    {
        public List<Models.BannerModel> ListBanner { get; set; }

        public List<Models.StoreModel> ListStore { get; set; }

        public List<Models.ProductModel> ListProduct { get; set; }

        public List<Models.RelatedItemModel> ListRelatedItem { get; set; }

        public List<Models.CategoryModel> ListCategoryModel { get; set; }

        public HomeViewModel()
        {
            ListBanner = new List<Models.BannerModel>();
            ListStore = new List<Models.StoreModel>();
            ListProduct = new List<Models.ProductModel>();
            ListRelatedItem = new List<Models.RelatedItemModel>();
            ListCategoryModel = new List<Models.CategoryModel>();
        }
    }
}
