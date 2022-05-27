

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    //Unhandled exception.OpenQA.Selenium.ElementNotInteractableException: element not interactable
    internal class Demo13Keyboard
    {
        static void Main2(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.bing.com/";

            Actions action = new Actions(driver);
            action.KeyDown(Keys.Shift).SendKeys("hello").KeyUp(Keys.Shift).Build().Perform();
            action.Reset();


            //action.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown)
            //    .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown)
            for (int i=1;i<=5;i++)
            {
                Thread.Sleep(1000);
                action.SendKeys(Keys.ArrowDown).Build().Perform();
                action.Reset();
            }
          
            Thread.Sleep(1000);
            action.SendKeys(Keys.Enter).Build().Perform();
            action.Reset();

        }
    }
}

