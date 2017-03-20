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
            driver.Navigate().GoToUrl("https://google.com");
            Console.WriteLine("go to url");
        }
        [Test]
        public void ExecuteTest()
        {
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("test");
            Console.WriteLine("input");
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
