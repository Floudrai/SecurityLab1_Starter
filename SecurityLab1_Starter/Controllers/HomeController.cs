﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{//missing something in this controller since the 404 and 500 are not working
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

         
            throw new Exception();


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DefaultAction() {
            return View();
        }


        public ActionResult NotFound() {

            return View();
        }

        public ActionResult GenError() {
            return new HttpStatusCodeResult(500);
            throw new Exception();
            throw new DivisionByZeroException();

        }
    }

	[Serializable]
	internal class DivisionByZeroException : Exception
	{
		public DivisionByZeroException()
		{
		}

		public DivisionByZeroException(string message) : base(message)
		{
		}

		public DivisionByZeroException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected DivisionByZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}