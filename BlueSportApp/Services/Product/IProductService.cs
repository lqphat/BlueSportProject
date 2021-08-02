using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Services.Product
{
    public interface IProductService
    {
        public List<Models.ProductModel> GetAll();

    }
}
