using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MentorStore.BL;
using MentorStore.Domain;

namespace MentorStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private IMainLogic<Product> _mainLogic;

        public ProductController(IMainLogic<Product> mainLogic)
        {
            this._mainLogic = mainLogic;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}