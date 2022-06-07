
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
using FlaUI.UIA3;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using System.Diagnostics;
using System.Drawing;

namespace SeleniumConcepts
{
    //Unhandled exception.OpenQA.Selenium.ElementNotInteractableException: element not interactable
    internal class Program
    {
        static void Main(String[] args)
        {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArgument("--disable-notifications");
            //opt.AddArgument("--Headless");
            //opt.AcceptInsecureCertificates = true;

            Dictionary<string, string> prefs = new Dictionary<string, string>();
            prefs.Add("download.default_directory", @"C:\");

   //        opt.AddUserProfilePreference("prefs", prefs);

           

            IWebDriver driver = new ChromeDriver(opt);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.irctc.co.in/nget/train-search";

            Console.WriteLine(driver.Title);

            Size s=driver.Manage().Window.Size;
            Console.WriteLine(s.Width);
            Console.WriteLine(s.Height);

            // driver.Quit();

            Size s2 = new Size(500, 700);
            driver.Manage().Window.Size = s2;

            driver.Url = "https://www.irctc.co.in/nget/train-search";
            driver.Manage().Window.Maximize();
            Point p=  driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Location;
            Console.WriteLine(p.X);
            Console.WriteLine(p.Y);

        }
    }
}

