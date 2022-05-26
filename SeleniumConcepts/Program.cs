

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
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

            //15 Dec 2000
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("15");

            //Select Dec
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Name("birthday_month")));
            selectMonth.SelectByText("Dec");
            // selectMonth.SelectByValue("12");
            //selectMonth.SelectByIndex(11);

            //Select 2000
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByText("2000");


            //click on Custom radio button
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            //click on sign up
            driver.FindElement(By.Name("websubmit")).Click();

            
        }
    }
}
