

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
    internal class Demo13WindowsAuth
    {
        static void Main33(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //driver.get('http://domain\username:password@abc.com')

            driver.Url = "https://john:john123@softwaretesting.com/";

           // driver.SwitchTo().Alert().SetAuthenticationCredentials("john", "john123");

        }
    }
}

