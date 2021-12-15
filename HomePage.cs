using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace IndigoTesting.PageObjectModel
{
    public class HomePage
    {
            private IWebDriver driver;

            [FindsBy(How = How.LinkText, Using = "Login")]
            [CacheLookup]
            public IWebElement LoginButton{ get; set; }

            public HomePage(IWebDriver driver)
            {
                this.driver = driver;
                PageFactory.InitElements(driver, this);
            }
            public void NavigateToLoginPage()
            {
                 LoginButton.Click();
                 Thread.Sleep(4000);
            }
       
    }
}

