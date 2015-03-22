using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MentorStore.BL;
using MentorStore.Domain;
using MentorStore.Web.Models;
using Microsoft.Practices.Unity;

namespace MentorStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductLogic _productLogic;

        public ProductController(IProductLogic productLogic)
        {
            this._productLogic = productLogic;
        }

        public ActionResult Index(int id)
        {
            Product product = _productLogic.GetEntityById(id);
            return View(product);
        }

    }
}