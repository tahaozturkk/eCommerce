using eCommerceApplication.Services;
using eCommerceEntity.Dtos;
using eCommerceEntity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eCommerceMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var result = _productService.GetProducts(); 
            return View(result);
        }
    }
}