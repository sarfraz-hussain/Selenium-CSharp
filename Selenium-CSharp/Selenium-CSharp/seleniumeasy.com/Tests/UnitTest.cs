using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
    [TestFixture]
    class UnitTest
    {

        Status status = new Status(false);
        [SetUp]
        public void Initilize()
        {
            propertiesCollection.driver = new ChromeDriver();
            propertiesCollection.driver.Manage().Window.Maximize();
            propertiesCollection.driver.Navigate().GoToUrl(new PageObjects_LogIn().pageUrl);
            Console.WriteLine("Chrome Driver Intilize");
            //WebDriverWait wait = new WebDriverWait(propertiesCollection.driver, new TimeSpan(0, 0, 30));
            //propertiesCollection.driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 2, 30);
        }

        [Test]
        public void VerifyMainPage()
        {
            MainPage page = new MainPage();
            status =  page.ValidatePageLoaded();
            Assert.IsFalse(status.ErrorOccurred);
        }

        [TearDown]
        public void Clean()
        {
          propertiesCollection.driver.Close();
        }
    }
}
