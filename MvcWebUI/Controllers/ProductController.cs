using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntitiesLayer;
using MvcWebUI.Models;
using NorthwindInterfaces;
using PagedList;
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
        public int PageSize = 6;
        public ActionResult Index(int page=1)
        {
            var products = _productService.GetAll().ToPagedList(page, 6);

            return View(products);
        }
    }
}