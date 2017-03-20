using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class SeleniumSetMethods
    {
        public static void EnterText( string element,string value, ProperyType elementtype)
        {
            if (elementtype == ProperyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == ProperyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }
        public static void Click( string element, ProperyType elementtype)
        {
            if (elementtype == ProperyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == ProperyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }
        public static void SelectDropDown( string element, string value, ProperyType elementtype)
        {           
            if (elementtype == ProperyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == ProperyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
