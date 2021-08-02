using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Models
{
    public class ProductModel
    {
        public string DiscountPercent { get; set; }

        public string InstallmentPercent { get; set; }

        public string ImageUrl { get; set; }

        public string ImageAlt { get; set; }

        public string Brand { get; set; }

        public string Name { get; set; }

        public string PriceCurrent { get; set; } 

        public string PriceOld { get; set; }

        public List<Models.BannerModel> ListRelatedItem { get; set; } // Contains related image items 


    }
}
