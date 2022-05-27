

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
    internal class Demo1
    {
        static void Main1(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);

            driver.Url = "https://opensource-demo.orangehrmlive.com/"; //wait for page load to complete

            string currentUrl=driver.Url;
            Console.WriteLine(currentUrl);

            string title=driver.Title;
            Console.WriteLine(title);

            string pageSource=driver.PageSource;
            Console.WriteLine(pageSource);

            Console.WriteLine(pageSource.Contains("LOGIN Panel"));

            // By loc= By.Id("txtUsername");
            //IWebElement ele = driver.FindElement(loc);
            //ele.SendKeys("Admin");

            IWebElement ele = driver.FindElement(By.Id("txtUsername"));
            ele.SendKeys("Admin");

            //driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();

            Console.WriteLine(driver.Url);

            driver.FindElement(By.Id("welcome")).Click();
            
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
