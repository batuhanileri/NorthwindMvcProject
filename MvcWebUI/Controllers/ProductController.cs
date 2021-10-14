using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntitiesLayer;
using NorthwindInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            List<Product> values = _productService.GetAll();
            return View(values);
        }
    }
}