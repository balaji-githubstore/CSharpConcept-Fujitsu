

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
    internal class Demo7FrameString
    {
        static void Main3(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame("login_page");

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("test123");
            //click on continue
            driver.FindElement(By.LinkText("CONTINUE")).Click();

            //will switch to main html
            driver.SwitchTo().DefaultContent();


        }
    }
}
