using BlueSportApp.Models;
using BlueSportApp.Services.Banner;
using BlueSportApp.Services.Category;
using BlueSportApp.Services.Product;
using BlueSportApp.Services.Store;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlueSportApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBannerService _bannerService;
        private readonly IStoreService _storeService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger, IBannerService bannerService,
            IStoreService storeService, IProductService productService, ICategoryService categoryService)
        {
            _logger = logger;
            _bannerService = bannerService;
            _storeService = storeService;
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var homeViewModel = new ViewModels.HomeViewModel()
            {
                ListBanner = _bannerService.GetAll(),
                ListProduct = _productService.GetAll(),
                ListStore = _storeService.GetAll(),
                ListCategory = _categoryService.GetAll(),
            };

            return View(homeViewModel);
        }
   

        //private List<Models.CategoryModel> GetCategory()
        //{
        //    var dataDemo = new List<CategoryModel>() { 
        //        new Models.CategoryModel()
        //        {
        //            Id = 1,
        //            Name = "Nam",
        //            Level = 0,
        //        },
        //        new Models.CategoryModel()
        //        {
        //            Id = 2,
        //            Name = "Nữ",
        //            Level = 0,
        //        },
        //        new Models.CategoryModel()
        //        {
        //            Id = 3,
        //            Name = "Trẻ em",
        //            Level = 0,
        //        },
        //        new Models.CategoryModel()
        //        {
        //            Id = 4,
        //            Name = "Giày dép",
        //            Level = 1,
        //            ParentId = 1
        //        },
        //        new Models.CategoryModel()
        //        {
        //            Id = 5,
        //            Name = "Quần áo",
        //            Level = 1,
        //            ParentId = 1
        //        },
        //        new Models.CategoryModel()
        //        {
        //            Id = 6,
        //            Name = "Phụ kiện",
        //            Level = 1,
        //            ParentId = 1
        //        },
        //        new Models.CategoryModel()
        //        {
        //            Id = 7,
        //            Name = "Giày dép",
        //            Level = 1,
        //            ParentId = 2
        //        },
        //        new Models.CategoryModel()
        //        {
        //            Id = 8,
        //            Name = "Quần áo",
        //            Level = 1,
        //            ParentId = 2
        //        },
        //        new Models.CategoryModel()
        //        {
        //            Id = 9,
        //            Name = "Phụ kiện",
        //            Level = 1,
        //            ParentId = 2
        //        },
        //        new Models.CategoryModel()
        //        {
        //            Id = 10,
        //            Name = "Giày dép Nam",
        //            Level = 2,
        //            ParentId = 4
        //        },
        //        new Models.CategoryModel()
        //        {
        //            Id = 11,
        //            Name = "Giày dép Nữ",
        //            Level = 2,
        //            ParentId = 7
        //        },

        //    };

        //    var data = new List<CategoryModel>();

        //    var ParentCategory = dataDemo.Where(c => c.Level == 0).ToList();
        //    var AllSubCategory = dataDemo.Where(c => c.Level == 1).ToList();
        //    var AllLastCategory = dataDemo.Where(c => c.Level == 2).ToList();

        //    foreach(var item in ParentCategory)
        //    {
        //        var itemParent = new Models.CategoryModel() {
        //            Name = item.Name,
        //            Id = item.Id,
        //            Level = item.Level,
        //            ListSubCategory = new List<CategoryModel>()
        //        };

        //        var subCate = AllSubCategory.Where(c => c.ParentId == item.Id).ToList();

        //        foreach(var sub in subCate)
        //        {
        //            var itemsub = new Models.CategoryModel()
        //            {
        //                Name = sub.Name,
        //                Id = sub.Id,
        //                Level = sub.Level,
        //                ListSubCategory = new List<CategoryModel>()
        //            };

        //            var lastCate = AllLastCategory.Where(c => c.ParentId == sub.Id).ToList();

        //            foreach(var last in lastCate)
        //            {
        //                itemsub.ListSubCategory.Add(new Models.CategoryModel()
        //                {
        //                    Name = last.Name,
        //                    Id = last.Id,
        //                    Level = last.Level,
        //                });
        //            }

        //            itemParent.ListSubCategory.Add(itemsub);
        //        }
        //        data.Add(itemParent);
        //    }

        //    return data;
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
