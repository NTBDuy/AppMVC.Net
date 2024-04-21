using System.Data;
using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.AddControllers
{
    public class FirstController : Controller
    {
        private readonly ILogger<FirstController> _logger; 
        private readonly ProductService _productService;
        
        public FirstController(ILogger<FirstController> logger, ProductService poductService) 
        {
            _logger = logger;
            _productService = poductService;
        }

        public string Index()
        {
            _logger.LogInformation("Index Action");
            return "Toi la index cua First";
        }

        public void Nothing()
        {
            _logger.LogInformation("Nothing Action");
            Response.Headers.Append("Hi", "Xin Chao cac ban");
        }

        public object Anything() => DateTime.Now   ;

        [TempData]
        public string StatusMessage {get; set; }

        public IActionResult ViewProducts(int? id) 
        {
            var product = _productService.Where(p => p.Id == id).FirstOrDefault();
            if (product == null) 
            {
                // TempData["StatusMessage"] = "San pham ban yeu cau khong co";
                StatusMessage = "San pham ban yeu cau khong co";
                return Redirect(Url.Action("Index", "Home"));
            }
            // return Content($"San Pham ID = {id}");

            // View/First/ViewProducts.cshtml
            // Model
            // return View(product);

            // ViewData
            // this.ViewData["product"] = product;
            // ViewData["Title"] = product.NameOfProduct;

            // return View("ViewProduct2");


            TempData["Thong bao"] = "asdasdaa";

            // ViewBag
            ViewBag.product = product;
            return View("ViewProduct3");

        }
    }
}