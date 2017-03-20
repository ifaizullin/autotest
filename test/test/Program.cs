using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&amp;Password=&amp;Login=Login");
            Console.WriteLine("go to url");
        }
        [Test]
        public void ExecuteTest()
        {

            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            SeleniumSetMethods.EnterText(driver, "Initial", "Test", "Name");
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }
        [Test]
        public void NextTest()
        {
            Console.WriteLine("next");
        }
        [TearDown]
        public void Cleanup()
        {
            driver.Close();
            Console.WriteLine("close");
        }

    }
}
