using NorthwindInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
           _categoryService = categoryService;
        }

        public PartialViewResult List()
        {
            return PartialView(_categoryService.GetAll());
        }
    }
}