using BlueSportApp.Services.Category;
using BlueSportApp.Services.Store;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSportApp.Controllers
{
    public class StoreController : Controller
    {
        private readonly ILogger<StoreController> _logger;
        private readonly IStoreService _storeService;
        private readonly ICategoryService _categoryService;

        public StoreController(ILogger<StoreController> logger, IStoreService storeService, ICategoryService categoryService)
        {
            _logger = logger;
            _storeService = storeService;
            _categoryService = categoryService;
        }

        [Route("Store/{id}")]
        public IActionResult Detail(string id)
        {

            var storeDetailViewModel = new ViewModels.StoreDetailViewModel();

            storeDetailViewModel.StoreModel = _storeService.GetById(id);
            storeDetailViewModel.ListCategory = _categoryService.GetAll();

            return View(storeDetailViewModel);
        }
    }
}
