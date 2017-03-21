﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitileID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string middlename, string firstname)
        {
            SeleniumSetMethods.EnterText(txtInitial, initial);
            SeleniumSetMethods.EnterText(txtFirstName, firstname);
            SeleniumSetMethods.EnterText(txtMiddleName, middlename);
            SeleniumSetMethods.Click(btnSave);

            //txtInitial.SendKeys(initial);
            //txtFirstName.SendKeys(firstname);
            //txtMiddleName.SendKeys(middlename);
            //btnSave.Click();
        }
    }
}
