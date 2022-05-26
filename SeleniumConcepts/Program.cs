

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class Program
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin
            //b[contains(text(),'phpMy')]
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            ReadOnlyCollection<string> windows= driver.WindowHandles;

            Console.WriteLine(windows[0]);
            Console.WriteLine(windows[1]);

            Console.WriteLine(driver.Title);

            driver.SwitchTo().Window(windows[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("Bala");
            //enter password
            //click on login


            driver.Quit(); //close the browser

        }
    }
}
