using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
    class SeleniumSetMethods
    {
        // Enter Text
        public static void EnterText(string element, string value, PropertyType elementType)
        {
            if(elementType == PropertyType.ID)
                propertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == PropertyType.Name)
                propertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //click into a button, checkbox, option 
        public static void click(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.ID)
                propertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementType == PropertyType.Name)
                propertiesCollection.driver.FindElement(By.Name(element)).Click();
        }
        //To Select a drop down control 
        public static void SelectDropDown(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.ID)
                new SelectElement(propertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == PropertyType.Name)
                new SelectElement(propertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);

        }
    }
}
