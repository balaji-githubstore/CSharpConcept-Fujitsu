

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
    internal class Program
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.online.citibank.co.in/";

            //img[@class='appClose']
            driver.FindElement(By.ClassName("appClose")).Click();

            driver.FindElement(By.XPath("//span[text()='Login']")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.XPath("//div[contains(text(),'Forgot User')]")).Click();

            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();

            //not working
            //driver.FindElement(By.Id("bill-date-long")).SendKeys("20/03/2000");

            driver.FindElement(By.CssSelector("#bill-date-long")).Click();

            SelectElement selMon = new SelectElement(driver.FindElement(By.CssSelector("select[data-handler='selectMonth']")));
            selMon.SelectByText("Mar");

            SelectElement selectYr = new SelectElement(driver.FindElement(By.CssSelector("[data-handler='selectYear']")));
            selectYr.SelectByText("2000");

            driver.FindElement(By.XPath("//a[text()='20']")).Click();


        }
    }
}

