using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.ModelsDTO
{
    public class StoreDTO
    {
        public string id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string webAddress { get; set; }

        public string phoneNumber { get; set; }

        public int timeOpen { get; set; }

        public int timeClose { get; set; }

        public string imageMapSourse { get; set; }

        public List<string> images { get; set; }


    }

    public static class StoreDTOExt
    {
        public static Models.StoreModel ToStoreModel(this StoreDTO storeDTO)
        {
            return new Models.StoreModel()
            {
                Name = storeDTO.name,
                Address = storeDTO.GetAddress(),
                imageMapSourse = storeDTO.imageMapSourse,
                phoneNumber = storeDTO.phoneNumber,
                timeClose = storeDTO.timeClose, 
                timeOpen = storeDTO.timeOpen,
                listImage = storeDTO.images,
                Id = storeDTO.id
            };
        }


        public static string GetAddress(this StoreDTO storeDTO)
        {
            return string.IsNullOrEmpty(storeDTO.webAddress) ? storeDTO.address.ToString() : storeDTO.webAddress.ToString();
        }
    }
}
