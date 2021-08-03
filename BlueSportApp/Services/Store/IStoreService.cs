using BlueSportApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Services.Store
{
    public interface IStoreService
    {
        public List<Models.StoreModel> GetAll();
        StoreModel GetById(string id);
    }
}
