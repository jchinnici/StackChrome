using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.stackoverflow.com");

            IWebElement searchBox = driver.FindElement(By.ClassName("s-input"));
            searchBox.SendKeys("c#");
            driver.FindElement(By.ClassName("s-btn")).Click();
        }
    }
}
