﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MentorStore.BL;
using MentorStore.Domain;

namespace MentorStore.Web.Controllers
{
    public class OrderController : Controller
    {
        private IMainLogic<Order> _mainLogic;

        public OrderController(IMainLogic<Order> mainLogic)
        {
            this._mainLogic = mainLogic;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}