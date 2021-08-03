using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.ModelsDTO
{
    public class ProductDTO
    {
        public string saleOff { get; set; }

        public string installment { get; set; }

        public string imageUrl { get; set; }

        public string ImageAlt { get; set; }

        public string brandName { get; set; }

        public string name { get; set; }

        public decimal priceCurrent { get; set; }

        public decimal priceOld { get; set; }

        //public List<Models.BannerModel> ListRelatedItem { get; set; }

    }

    public static class ProductDTOExt
    {
        public static Models.ProductModel ToProductModel(this ModelsDTO.ProductDTO productDTO)
        {
            return new Models.ProductModel()
            {
                Name = productDTO.name,
                ImageUrl = productDTO.imageUrl,
                Brand = productDTO.GetBrand(),
                DiscountPercent = productDTO.GetDiscountPercent(),
                ImageAlt = productDTO.ImageAlt,
                InstallmentPercent = productDTO.GetInstallmentPercente(),
                PriceCurrent = productDTO.GetPriceCurrent(),
                PriceOld = productDTO.GetPriceOld(),
                ListRelatedItem = null
            };
        }

        public static string GetBrand(this ModelsDTO.ProductDTO productDTO)
        {
            return productDTO.brandName.ToUpper();
        }
        public static string GetDiscountPercent(this ModelsDTO.ProductDTO productDTO)
        {
            return ($"-{productDTO.saleOff}%");
        }

        public static string GetInstallmentPercente(this ModelsDTO.ProductDTO productDTO)
        {
            return ($"Góp {productDTO.installment}%");
        }
        public static string GetPriceCurrent(this ModelsDTO.ProductDTO productDTO)
        {
            return string.Format("{0:###-###-###}", productDTO.priceCurrent).Replace("-", ".");
        }
        public static string GetPriceOld(this ModelsDTO.ProductDTO productDTO)
        {
            return string.Format("{0:###-###-###}", productDTO.priceOld).Replace("-", ".");
        }


    }
}
