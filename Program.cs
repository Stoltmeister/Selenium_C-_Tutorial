using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {

        // Create the reference for our browswer
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            // Create the reference for our browswer
            IWebDriver driver = new ChromeDriver();

            // Navigate to your page
            driver.Navigate().GoToUrl("https://www.google.com");

            // Find the Element

            IWebElement element = driver.FindElement(By.Name("q"));

            // Perform Ops
            element.SendKeys("continous integration");
            element.Submit();

            driver.Close();
        }

        [SetUp]
        public void Initialize()
        {
            // Navigate to your page
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [Test]
        public void ExecuteTest()
        {
            // Find the Element

            IWebElement element = driver.FindElement(By.Name("q"));

            // Perform Ops
            element.SendKeys("continous integration");
            element.Submit();
            Console.WriteLine("Exectued Test");
        }

        public void NextTest()
        {
            Console.WriteLine("Next Test /n");

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
