using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp_NewGit
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://www.google.com");

            IWebElement element = Driver.FindElement(By.Name("q"));
            element.SendKeys("execute this page");
           
       

        }
    }
}
