using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
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
        NorthwindContext db = new NorthwindContext();
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public int PageSize = 6;
        //public ActionResult Index(int page = 1, int category = 1)
        //{
        //    var products = _productService.GetAll().ToPagedList(page, 6);

        //    return View(products);
        //}
        public ActionResult Index(int page=1,int category =0)
        {
            
            var products = _productService.GetAll().Where(p=>p.CategoryID==category||category==0).ToList();

            return View(new ProductViewModel

            {
                Products = products.ToList(),
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = PageSize,
                    TotalItems = products.Count,
                    CurrentPage= page

                }

        });
        }
    }
    }
