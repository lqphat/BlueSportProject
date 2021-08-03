using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Models
{
    public class StoreModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string phoneNumber { get; set; }

        public int timeOpen { get; set; }

        public int timeClose { get; set; }

        public string imageMapSourse { get; set; }
        public List<string> listImage { get; set; }

    }
}
