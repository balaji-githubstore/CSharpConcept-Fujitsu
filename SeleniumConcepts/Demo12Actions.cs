

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
    internal class Demo12Actions
    {
        static void Mainw(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://nasscom.in/";

            
            Actions action=new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Perform();

            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Become a member']"))).Perform();

            //action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']")))
            //    .MoveToElement(driver.FindElement(By.XPath("//a[text()='Become a member']"))).Build().Perform();


            driver.FindElement(By.XPath("//a[text()='Membership Benefits']")).Click();
           
        }
    }
}
