

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
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

            driver.Url = "https://www.facebook.com/"; 

            //click on create new account 
            driver.FindElement(By.LinkText("Create New Account")).Click();

            //enter firstname as JOhn
            driver.FindElement(By.Name("firstname")).SendKeys("John");

            //enter lastname as wick
            driver.FindElement(By.Name("lastname")).SendKeys("John");

            //enter password as welcome@123
            driver.FindElement(By.Id("password_step_input")).SendKeys("welcome@123");

            //click on Custom radio button
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            //click on sign up

        }
    }
}
