using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.ModelsDTO
{
    public class BannerDTO
    {
        public string pathImg { get; set; }

        public string altImg { get; set; }
    }

    public static class BannerDTOExt
    {
        public static Models.BannerModel ToBannerModel(this ModelsDTO.BannerDTO bannerDTO)
        {
            return new Models.BannerModel()
            {
                ImageAlt = bannerDTO.altImg,
                ImageUrl = bannerDTO.pathImg
            };
        }
    }
}

