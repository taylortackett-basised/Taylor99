using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


//https://groupscrubs-teststore.myshopify.com/admin/auth/login

namespace Guru99
{
    class Guru99Demo
    {
        IWebDriver driver;

        public object GetActiveElement { get; private set; }

        

        IWebDriver driver2;
        IWebDriver driver3;
        //IWebDriver WebDriverWait;
        //this will not wait for page to load
        //Assert.True(Driver.FindElement(object.elementLocator).Enabled);

        //this will search for the element until a timeout is reached
        

        [SetUp]
        public void StartBrowser()
        {
            //FirefoxOptions options = new FirefoxOptions();
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            //driver = new FirefoxDriver("C:\\Users\\Taylor\\Source\\Repos\\Guru99", options);
            driver = new ChromeDriver("C:\\Users\\Taylor\\Source\\Repos\\Guru99", options);
        }

        //[Test]
        //public override IWebElement WaitUntilElementExists(By elementLocator, int timeout = 10)
        //{
        //    try
        //    {
        //        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
        //        //return driver.FindElement(DriverCommand GetActiveElement);
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
        //        throw;
        //    }
        //}

        // currently, this test opens admin login page and logs in as admin
        [Test]
        public void Test()
        {
            
            
            driver.Url = "https://groupscrubs.myshopify.com/admin";
            driver.Manage().Window.Maximize();
            /********* JOB QUEUE (Total Jobs#2/2) *********/

            /********* START JOB (Job# 1/2 start) *********/
            // Store locator values of email text box and sign up button				
            IWebElement emailTextBox = driver.FindElement(By.XPath(".//*[@id='Login']"));
            IWebElement passwordTextBox = driver.FindElement(By.XPath(".//*[@id='Password']"));
            IWebElement submitBtm = driver.FindElement(By.XPath(".//*[@id='LoginSubmit']") );

            emailTextBox.SendKeys("taylorbtackett7@gmail.com");
            passwordTextBox.SendKeys("admin33");

            

            submitBtm.Click();
            driver.Manage().Timeouts().ImplicitWait.Seconds.Equals(1);

            driver2.Url = driver.Url;


            IWebElement WaitUntilElementExists = driver2.FindElement(By.XPath(".//*[@id='product - form - container']/div/div/div[1]"));
            //driver2 = driver;
            IWebElement productsCategory = driver2.FindElement(By.XPath(".//*[@id='AppFrameNav']/nav/div[2]/div/ul[1]/li[3]"));
            productsCategory.Click();
            driver.Manage().Timeouts().ImplicitWait.Seconds.Equals(1);

            IWebElement addProductBtn = driver2.FindElement(By.CssSelector("#products-index > header > div.ui-title-bar > div.ui-title-bar__actions-group > div > a"));
            addProductBtn.Click();
            driver.Manage().Timeouts().ImplicitWait.Seconds.Equals(1);

            IWebElement inputTitle = driver2.FindElement(By.XPath(".//*[@id='product - form - container']/div/div/div[1]"));
            inputTitle.SendKeys("Test Title");
            driver.Manage().Timeouts().ImplicitWait.Seconds.Equals(1);



            /********* END JOB (Job# 1/2 complete) *********/
            //}

            //[Test]
            //public void Test2()
            //{
            //driver2.Url = "https://groupscrubs.myshopify.com/admin/products";
            //driver2.Manage().Window.Maximize();

            //IWebElement goToProducts = driver.FindElement(By.XPath("//*[@id='AppFrameNav']//nav//div[2]//div//ul[1]//li[3]//a//span"));
            //goToProducts.Click();

            //driver.Url = "https://groupscrubs.myshopify.com/admin/products/new";
            //IWebElement goToAddProduct = driver.FindElement(By.XPath(".//*[@id='product-name']"));

            //IWebElement titleFieldElement = driver3.FindElement(By.CssSelector("'#product-name'"));
            //goToAddProduct.Click();
            //goToAddProduct.SendKeys("Example Title");

            /********* JOB QUEUE (Total Jobs#2/2) *********/

            /********* START JOB (Job# 1/2 start) *********/
            // Store locator values of email text box and sign up button				
            //IWebElement emailTextBox = driver.FindElement(By.XPath(".//*[@id='Login']"));
            //IWebElement passwordTextBox = driver.FindElement(By.XPath(".//*[@id='Password']"));
            //IWebElement submitBtm = driver.FindElement(By.XPath(".//*[@id='LoginSubmit']"));

            //emailTextBox.SendKeys("tay2162577@maricopa.edu");
            //passwordTextBox.SendKeys("L57s21rq1");
            //submitBtm.Click();
            /********* END JOB (Job# 1/2 complete) *********/
        }


        //[TearDown]
        //public void CloseBrowser()
        //{
        //    driver.Close();
        //}
    }
}
