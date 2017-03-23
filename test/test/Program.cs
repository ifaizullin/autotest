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
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("go to url");
        }
        [Test]
        public void ExecuteTest()
        {

            ExcelLib.PopulateInCollection(@"C:\SomeTestCode\data.xlsx");
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1,"UserName"), ExcelLib.ReadData(1, "Password"));
            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));



            //SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", ProperyType.Id);
            //SeleniumSetMethods.EnterText("Initial", "Test", ProperyType.Name);
            //Console.WriteLine("the value " + SeleniumGetMethods.GetTextFromDDL("TitleId", ProperyType.Id));
            //Console.WriteLine("the value " + SeleniumGetMethods.GetText("Initial", ProperyType.Name));

            //SeleniumSetMethods.Click("Save", ProperyType.Name);
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
