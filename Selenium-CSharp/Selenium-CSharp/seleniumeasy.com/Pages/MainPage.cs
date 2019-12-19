using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
    class MainPage
    {
        public MainPage()
        {
            PageFactory.InitElements(propertiesCollection.driver, this);
        }

        Status status = new Status(false);

        #region Main Page - Page Elements


        [FindsBy(How = How.Id, Using = "site-name")]
        [CacheLookup]
        private IWebElement SiteLoadLocator { get; set; }

        // Drop Down List InputForm
        [FindsBy(How = How.ClassName, Using = "dropdown-toggle")]
        [CacheLookup]
        private IWebElement DDL_InputForm { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Simple Form Demo")]
        [FindsBy(How = How.ClassName, Using = "dropdown-menu1")]
        [CacheLookup]
        private IWebElement DDL_InputForm_Option1 { get; set; }
        
        

        #endregion

        #region Page URL

        public  string pageUrl = "https://www.seleniumeasy.com/test/";

        #endregion

        #region Main Page - Page Actions


        public void SelectRecruitment(string KeyWords)
        {
           
        }

        public Status ValidatePageLoaded()
        {

            //Console.WriteLine("Page URL Matches:" + propertiesCollection.driver.ValidatePageByUrl(this.pageUrl).ToString());       
            status = DDL_InputForm.click();
            //string str = DDL_InputForm.Text;
  
            status += DDL_InputForm_Option1.SelectDropDown("");
            //MainPage page = new MainPage
            //{
            //    pageUrl = propertiesCollection.driver.Url
            //};
            //return page;
            return status;
        }



        #endregion
    }

}
