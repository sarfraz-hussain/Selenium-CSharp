using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
        static class Validations
        {
            //public void validateScreenByUrl(IWebDriver driver, String screenUrl)
            //{
            //    String currentURL = driver.Url;
            //    Assert.IsTrue(currentURL.Equals(screenUrl));
            //}

            public static bool validateIsPresent(this IWebElement element)
            {
                return element.Displayed;
            }

            //public void validatetextinelement(iwebdriver driver, by element, string text)
            //{
            //    string findelement = driver.findelement(element).text;
            //    assert.istrue(findelement.equals(text));
            //}
        }

}
