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
            propertiesCollection.driver.Navigate().GoToUrl("http://opensource.demo.orangehrmlive.com/");
            Console.WriteLine("Chrome Driver Intilize");
        }

        [Test]
        public void Executetest()
        {
            //Set User Name
            SeleniumSetMethods.EnterText("txtUsername", "Admin", PropertyType.ID);
           
            //Set Password
            SeleniumSetMethods.EnterText("txtPassword", "admin", PropertyType.ID);

            //Click Submit Button
            SeleniumSetMethods.click("Submit", PropertyType.Name);

            //Click on Recruitment Tab
            SeleniumSetMethods.click("menu_recruitment_viewRecruitmentModule", PropertyType.ID);
            SeleniumSetMethods.EnterText( "candidateSearch_keywords", "administration", PropertyType.ID);

            //Click on job title Drop Down
            SeleniumSetMethods.SelectDropDown("candidateSearch_jobTitle", "Sales Manager", PropertyType.ID);
            

            //Click checkbox
            SeleniumSetMethods.click("ohrmList_chkSelectAll", PropertyType.ID);


            //Get Selected DDL
            Console.WriteLine("Selected Drop Down is: " + SeleniumGetMethods.GetTextFromDDL("candidateSearch_jobTitle", PropertyType.ID));
            //Get Selected Keyword
            Console.WriteLine("Selected Keyword is: " + SeleniumGetMethods.GetText( "candidateSearch_keywords", PropertyType.ID));


        }


        [TearDown]
        public void clean()
        {
            propertiesCollection.driver.Close();
        }
    }
}
