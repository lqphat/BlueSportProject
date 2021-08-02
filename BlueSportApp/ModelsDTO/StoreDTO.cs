using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.ModelsDTO
{
    public class StoreDTO
    {
        public string name { get; set; }

        public string address { get; set; }

        public string webAddress { get; set; }
    }

    public static class StoreDTOExt
    {
        public static Models.StoreModel ToStoreModel(this StoreDTO storeDTO)
        {
            return new Models.StoreModel()
            {
                Name = storeDTO.name,
                Address = storeDTO.GetAddress(),
            };
        }


        public static string GetAddress(this StoreDTO storeDTO)
        {
            return string.IsNullOrEmpty(storeDTO.webAddress) ? storeDTO.address.ToString() : storeDTO.webAddress.ToString();
        }
    }
}
