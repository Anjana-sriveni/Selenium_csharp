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
    public class BackToHomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "loginModal")]
        [CacheLookup]
        public IWebElement mainpage { get; set; }

        public BackToHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void NavigateTohomepage()
        {
            mainpage.Click();
            Thread.Sleep(4000);
        }


    }
}
