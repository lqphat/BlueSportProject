using BlueSportApp.Models;
using BlueSportApp.Services.Banner;
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

        public HomeController(ILogger<HomeController> logger, IBannerService bannerService,
            IStoreService storeService, IProductService productService)
        {
            _logger = logger;
            _bannerService = bannerService;
            _storeService = storeService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var homeViewModel = new ViewModels.HomeViewModel()
            {
                ListBanner = _bannerService.GetAll(),
                ListProduct = _productService.GetAll(),
                ListStore = _storeService.GetAll(),
            };
            return View(homeViewModel);
        }

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
