using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
    class PageObjects_MainPage
    {
        public PageObjects_MainPage()
        {
            PageFactory.InitElements(propertiesCollection.driver, this);
        }

        #region Main Page - Page Elements

        [FindsBy(How = How.Id, Using = "menu_recruitment_viewRecruitmentModule")]
        private IWebElement btnRecruitment { get; set; }

        [FindsBy(How = How.Id, Using = "candidateSearch_keywords")]
        private IWebElement txtKeyWords { get; set; }

        #endregion

        #region Main Page - Page Actions
        public void SelectRecruitment(string KeyWords)
        {
            btnRecruitment.click();
            txtKeyWords.EnterText(KeyWords);


           // SeleniumSetMethods.click(btnRecruitment);
           // SeleniumSetMethods.EnterText(txtKeyWords, KeyWords);
           
        }

        #endregion
    }

}
