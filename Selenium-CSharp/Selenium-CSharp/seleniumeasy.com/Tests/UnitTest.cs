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
            propertiesCollection.driver.Navigate().GoToUrl(new mPaige().pageUrl);
            //WebDriverWait wait = new WebDriverWait(propertiesCollection.driver, new TimeSpan(0, 0, 30));
            //propertiesCollection.driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 2, 30);
        }

        [Test]
        public void VerifyMainPage()
        {
            mPaige page = new mPaige(propertiesCollection.driver);
            Status status = new Status(false); 


            Assert.IsFalse((status += page.ClickInputForms1Link()).ErrorOccurred, status.ReturnedMessage);
            Assert.IsFalse((status += page.ClickAjaxFormSubmit1Link()).ErrorOccurred, status.ReturnedMessage);


        }

        [TearDown]
        public void Clean()
        {
          propertiesCollection.driver.Close();
        }
    }
}
