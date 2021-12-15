using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IndigoTesting.PageObjectModel
{
    public class LoginPage
    {
        private IWebDriver driver;
       
        [FindsBy(How = How.Id, Using = "memberId")]
        [CacheLookup]
        public IWebElement MobileNumber { get; set; }

        [FindsBy(How = How.Id, Using = "mobilePass")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "rememberMeId")]
        [CacheLookup]
        public IWebElement CheckBox { get; set; }

       // [FindsBy(How = How.ClassName, Using = "buttonText")]
        //[CacheLookup]
        //public IWebElement LoginButton { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [DynamicData(nameof(ReadExcel), DynamicDataSourceType.Method)]
        [TestMethod]
        public void LoginDetails(string mnum, string pwd)
        {
            MobileNumber.SendKeys(mnum);
            Thread.Sleep(4000);
            Password.SendKeys(pwd);
            Thread.Sleep(4000);
            CheckBox.Click();
            Thread.Sleep(4000);
            //LoginButton.Click();
            //Thread.Sleep(4000);
 
        }

        public static IEnumerable <object[]> ReadExcel()
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo("DataSheet.xlsx")))
            {
                //get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.End.Row;     //get row count
                for (int i = 2; i <= rowCount; i++)
                {
                    yield return new object[] {
                        worksheet.Cells[i, 1].Value?.ToString().Trim(), // MobileNumber
                        worksheet.Cells[i, 2].Value?.ToString().Trim() // Password
                    }; 
                }
            }
        }
    }
}
