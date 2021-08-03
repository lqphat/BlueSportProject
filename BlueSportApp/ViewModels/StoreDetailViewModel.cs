using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.ViewModels
{
    public class StoreDetailViewModel : CommonViewModel
    {
        public Models.StoreModel StoreModel { get; set; }
        public List<Models.StoreModel> ListStore { get; set; }

    }
}
