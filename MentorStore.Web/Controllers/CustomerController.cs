using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MentorStore.BL;
using MentorStore.Domain;

namespace MentorStore.Web.Controllers
{
    public class CustomerController : Controller
    {
        private IMainLogic<Customer> _mainLogic;

        public CustomerController(IMainLogic<Customer> mainLogic)
        {
            this._mainLogic = mainLogic;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}