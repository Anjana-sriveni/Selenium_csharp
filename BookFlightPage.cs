using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IndigoTesting.PageObjectModel
{
    public class BookFlightPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "Multi-city")]
        [CacheLookup]
        public IWebElement LoginButton { get; set; }

        public BookFlightPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void FillTheDetails()
        {
            LoginButton.Click();
            Thread.Sleep(4000);
        }
    }
}
