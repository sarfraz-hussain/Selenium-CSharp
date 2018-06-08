using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
    class SeleniumGetMethods
    {
        public static string GetText(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.ID)
                return propertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("id");
            if (elementType == PropertyType.Name)
                return propertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("id");
            else
                return string.Empty;
        }

        public static string GetTextFromDDL(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.ID)
                return new SelectElement(propertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == PropertyType.Name)
                return new SelectElement(propertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else
                return string.Empty;
        }
    }
}
