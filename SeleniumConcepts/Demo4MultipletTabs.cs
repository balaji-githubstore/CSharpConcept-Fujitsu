

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
    internal class Demo4M
    {
        static void Mainwd(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);

            driver.Url = "https://www.db4free.net/";
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
       
            
            driver.FindElement(By.Id("input_username")).SendKeys("Bala");
            driver.FindElement(By.Id("input_password")).SendKeys("Bala");
            driver.FindElement(By.Id("input_go")).Click();

            string errorText=driver.FindElement(By.XPath("(//div[@role='alert'])[3]")).Text;
            Console.WriteLine(errorText);

            string header=driver.FindElement(By.TagName("h1")).Text;
            Console.WriteLine(header);
        }
    }
}
