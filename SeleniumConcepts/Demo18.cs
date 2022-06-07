
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlaUI.UIA3;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using System.Diagnostics;

namespace SeleniumConcepts
{
    //Unhandled exception.OpenQA.Selenium.ElementNotInteractableException: element not interactable
    internal class Demo18
    {
        static void Main2(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.ilovepdf.com/pdf_to_word";


            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            // wait.IgnoreExceptionTypes(typeof(NoAlertPresentException),typeof(NoSuchElementException));
            wait.IgnoreExceptionTypes(typeof(Exception));
            wait.Timeout = TimeSpan.FromSeconds(20);
           // wait.PollingInterval= TimeSpan.FromSeconds(1);

           IWebElement ele= wait.Until(x => x.FindElement(By.XPath("//king")));

            ele.Click();

         // string title=  wait.Until(x => x.Title);

            //driver.FindElement(By.XPath("//king")).Click();
            
        }
    }
}

