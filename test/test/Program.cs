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
        
        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&amp;Password=&amp;Login=Login");
            Console.WriteLine("go to url");
        }
        [Test]
        public void ExecuteTest()
        {

            SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", ProperyType.Id);
            SeleniumSetMethods.EnterText("Initial", "Test", ProperyType.Name);
            Console.WriteLine("the value " + SeleniumGetMethods.GetTextFromDDL("TitleId", ProperyType.Id));
            Console.WriteLine("the value " + SeleniumGetMethods.GetText("Initial", ProperyType.Name));

            SeleniumSetMethods.Click("Save", ProperyType.Name);
        }
        [Test]
        public void NextTest()
        {
            Console.WriteLine("next");
        }
        [TearDown]
        public void Cleanup()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("close");
        }

    }
}
