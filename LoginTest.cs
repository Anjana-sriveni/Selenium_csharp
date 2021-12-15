using Docker.DotNet.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using IndigoTesting.PageObjectModel;


namespace IndigoTesting.TestCases
{
    [TestFixture]
    class LoginTest : BasePage
    {
        [Test]
        public void Test()
        {

            var homepage = new HomePage(driver);
            homepage.NavigateToLoginPage();
            Thread.Sleep(4000);

            var loginpage = new LoginPage(driver);
            loginpage.LoginDetails("1234567890", "hahahah");
            Thread.Sleep(4000);

            var backtohomepg = new BackToHomePage(driver);
            backtohomepg.NavigateTohomepage();
            Thread.Sleep(4000);

            //driver.Navigate().Refresh();
            //driver.Navigate().GoToUrl("https://www.goindigo.in/");
            driver.Navigate().Back();
            
            var bookflightpage = new BookFlightPage(driver);
            bookflightpage.FillTheDetails();
            Thread.Sleep(4000);


        }
    }
}
