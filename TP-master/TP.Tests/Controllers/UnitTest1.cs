using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP;
using TP.Controllers;
using TP.Models;

namespace TP.Tests.Controllers
{
    [TestClass]
    public class DetailsTest
    {
        [TestMethod]
        public void DetailsViewTest()
        {
            var controller = new HomeController();
            var result = controller.Details(3) as ViewResult;
            var m = (Movie)result.ViewData.Model;
            Assert.AreEqual("The Dreamers", m.Title);
        }
    }
}
