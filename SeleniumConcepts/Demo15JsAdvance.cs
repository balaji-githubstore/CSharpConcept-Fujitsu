

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

namespace SeleniumConcepts
{
    //Unhandled exception.OpenQA.Selenium.ElementNotInteractableException: element not interactable
    internal class ssdd
    {
        static void Mainss(String[] args)
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



            //driver.FindElement(By.CssSelector("#bill-date-long")).Click();

            //SelectElement selMon = new SelectElement(driver.FindElement(By.CssSelector("select[data-handler='selectMonth']")));
            //selMon.SelectByText("Mar");

            //SelectElement selectYr = new SelectElement(driver.FindElement(By.CssSelector("[data-handler='selectYear']")));
            //selectYr.SelectByText("2000");

            //driver.FindElement(By.XPath("//a[text()='20']")).Click();

            driver.FindElement(By.Id("cvvnumber")).SendKeys("344");

            IWebElement ele= driver.FindElement(By.XPath("//input[@name='DOB']"));

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value='20/08/2000'", ele);


            string cvv=js.ExecuteScript("return document.querySelector('#cvvnumber').value").ToString();
            Console.WriteLine( cvv);

            string title = js.ExecuteScript("return document.title").ToString();
            Console.WriteLine(title);

            driver.FindElement(By.XPath("//input[@value='PROCEED']")).Click();

            string text=driver.FindElement(By.XPath("//div[contains(@id,'ui-id')]")).Text;
            Console.WriteLine(text);


            //youtube
            //document.querySelectorAll('.video-stream.html5-main-video')[0].duration

            string duration = Convert.ToString(js.ExecuteScript(@"return document.querySelectorAll('.video-stream.html5-main-video')[0].duration"));
            Console.WriteLine(duration);
        }
    }
}

