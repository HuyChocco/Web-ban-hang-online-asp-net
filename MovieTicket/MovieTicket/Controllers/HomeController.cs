﻿using ModelLayer.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTicket.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{

			ViewBag.Slides = new SlideDao().ListAll();
			var productDao = new ProductDao();
			ViewBag.NewProducts = productDao.ListNewProduct(4);
			ViewBag.ListFeatureProducts = productDao.ListFeatureProduct(4);
			return View();

		}
		[ChildActionOnly]
		[OutputCache(Duration = 3600 * 24)]
		public ActionResult MainMenu()
		{
			var model = new MenuDao().ListByGroupId(1);
			return PartialView(model);
		}

		[ChildActionOnly]
		[OutputCache(Duration = 3600 * 24)]
		public ActionResult TopMenu()
		{
			var model = new MenuDao().ListByGroupId(2);
			return PartialView(model);
		}

		[ChildActionOnly]
		[OutputCache(Duration = 3600 * 24)]
		public ActionResult Footer()
		{
			var model = new FooterDao().GetFooter();
			return PartialView(model);
		}


	}
}