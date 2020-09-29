using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TutorialApplication.Models;
using TutorialApplication.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using UnitTestProject1;

namespace TutorialApplicationUnitTestProject
{
    [TestClass]
    public class TutorialApplicationUnitTest
    {
        [TestMethod]
        public void TutorialApplicationTestMethod()
        {
            try
            {
                Console.WriteLine(" Login testcase");
                LoginViewModel Lvm = new LoginViewModel();
                Lvm.Email = TestData.Email;
                Lvm.Password = TestData.Password;

                // Drive
                AccountController controller = new AccountController();

                //Test
                 var results = controller.Login(Lvm,"");

                //Assert
                Assert.IsNotNull(results);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        [TestMethod]
        public void TutorialApplicationTestMethod1()
        {
            try
            {
                Console.WriteLine("About Page testcase");
                //Arrange
                HomeController controller = new HomeController();

                //Act
                var results = controller.About() as ViewResult;

                //Assert
                Assert.IsNotNull(results);
                Assert.IsNotNull(results.ViewBag.Message);
                Assert.AreEqual(TestData.AboutPageMessage, results.ViewBag.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }




        [TestMethod]
        public void TutorialApplicationTestMethod2()
        {
            try
            {

                //Arrange
                Console.WriteLine("Contact Page testcase");
                HomeController controller = new HomeController();

                //Act
                var results = controller.Contact() as ViewResult;

                //Assert
                Assert.IsNotNull(results);
                Assert.IsNotNull(results.ViewBag.Message);
                Assert.AreEqual(TestData.ContactPageMessage, results.ViewBag.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

      
    }
}
