using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Services.Banner
{
    public interface IBannerService
    {
        public List<Models.BannerModel> GetAll();
    }
}
