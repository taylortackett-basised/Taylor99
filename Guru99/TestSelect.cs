//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Guru99
//{
//    class TestSelect
//    {
//        IWebDriver driver;

//        [Test]
//        public void selectDemo()
//        {
//            driver = new ChromeDriver("G:\\");
//            driver.Url = "http://demo.guru99.com/test/guru99home/";
//            driver.Manage().Window.Maximize();

//            IWebElement course = driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

//            var selectTest = new SelectElement(course);
//            // Select a value from the dropdown				
//            selectTest.SelectByValue("sap-abap");

//        }
//    }
//}
