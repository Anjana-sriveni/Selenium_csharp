using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IndigoTesting

{
    public class BasePage
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.goindigo.in/";
            Thread.Sleep(4000);
        }

        [OneTimeTearDown]
        public void closeWin()
        {
            driver.Quit();
        }
    }
}
