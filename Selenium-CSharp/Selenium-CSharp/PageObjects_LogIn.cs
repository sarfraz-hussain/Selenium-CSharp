using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_CSharp
{
    class PageObjects_LogIn
    {

        public PageObjects_LogIn()
        {

            PageFactory.InitElements(propertiesCollection.driver, this);

        }


        #region Login Page - Web Elements

        //User Name
        [FindsBy(How = How.Id , Using = "txtUsername")]
        private IWebElement tbUserName { get; set; }

        //Password
        [FindsBy(How = How.Id, Using = "txtPassword")]
        private IWebElement tbPassword { get; set; }

        //Submit Button
        [FindsBy(How = How.Name, Using = "Submit")]
        private IWebElement btnSubmit { get; set; }

        #endregion

        #region Login Page - Page Actions

        public PageObjects_MainPage Login(string username, string password)
        {
            tbUserName.EnterText(username);
            tbPassword.EnterText(password);
            btnSubmit.click();
            return new PageObjects_MainPage();

            //  SeleniumSetMethods.EnterText(tbUserName, username);
            //  SeleniumSetMethods.EnterText(tbPassword, password);
            //  SeleniumSetMethods.click(btnSubmit);
            //  return new PageObjects_MainPage();
        }

        #endregion
    }
}
