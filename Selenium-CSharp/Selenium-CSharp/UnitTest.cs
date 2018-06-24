using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
    class UnitTest
    {


        [SetUp]
        public void Initilize()
        {
            propertiesCollection.driver = new ChromeDriver();

            propertiesCollection.driver.Navigate().GoToUrl(new PageObjects_LogIn().pageUrl);
            Console.WriteLine("Chrome Driver Intilize");
        }

        [Test]
        public void VerifyLogIN()
        {
            PageObjects_LogIn pageLogIN = new PageObjects_LogIn();
            
            // page Actions - Login
            pageLogIN.Login("Admin", "admin");           
        }

        [Test]
        public void VerifyMainPage()
        {
            PageObjects_LogIn pageLogIN = new PageObjects_LogIn();


            // page Actions - Login
            PageObjects_MainPage pageMain = pageLogIN.Login("Admin", "admin");
            pageMain.selectRecruitment("Engineering");

        }

        [TearDown]
        public void clean()
        {
          propertiesCollection.driver.Close();
        }
    }
}
