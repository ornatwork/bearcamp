﻿using System.Web.Mvc;
using NUnit.Framework;
using BearCamp.Controllers;

namespace BearCamp.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.That("Welcome to ASP.NET MVC!", Is.EqualTo(result.ViewBag.Message));
        }


    }
}
