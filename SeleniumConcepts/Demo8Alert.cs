

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
    internal class Demo8Alert
    {
        static void Main2(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            //click on Go
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            string alertText=driver.SwitchTo().Alert().Text;
            Console.WriteLine(alertText);

            //driver.SwitchTo().Alert().SendKeys("jrr");

            driver.SwitchTo().Alert().Accept();
        }
    }
}
