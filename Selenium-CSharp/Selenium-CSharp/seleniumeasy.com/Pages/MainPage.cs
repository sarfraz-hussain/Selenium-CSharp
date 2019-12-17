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

        #region Main Page - Page Elements

        [FindsBy(How = How.Id, Using = "menu_recruitment_viewRecruitmentModule")]
        private IWebElement btnRecruitment { get; set; }

        [FindsBy(How = How.Id, Using = "candidateSearch_keywords")]
        private IWebElement txtKeyWords { get; set; }

        [FindsBy(How = How.Id, Using = "site-name")]
        private IWebElement SiteLoadLocator { get; set; }

        #endregion

        #region Page URL

        public readonly string pageUrl = "https://www.seleniumeasy.com/test/";

        #endregion

        #region Main Page - Page Actions


        public void SelectRecruitment(string KeyWords)
        {
            btnRecruitment.click();
            txtKeyWords.EnterText(KeyWords);
           
        }

        public MainPage ValidatePageLoaded()
        {

            //SiteLoadLocator.click();  

            //Console.WriteLine("Page URL Matches:" + propertiesCollection.driver.ValidatePageByUrl(this.pageUrl).ToString());

            IWebDriver currentpage = propertiesCollection.driver;

            return new MainPage();

        }



        #endregion
    }

}
