

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
    internal class Program
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.google.com/";

            //int count = driver.FindElements(By.TagName("hello")).Count();
            //Console.WriteLine(count);

            //ReadOnlyCollection<IWebElement> elements= driver.FindElements(By.TagName("a"));
            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.TagName("a"));
            int linkCount=elements.Count();
            Console.WriteLine(linkCount);

            //elements[0].Click();
            //Console.WriteLine(elements[0].Text);
            //Console.WriteLine(elements[1].Text);

            for(int i=0;i<linkCount;i++)
            {
                Console.WriteLine(elements[i].Text);
                string href=elements[i].GetAttribute("href");
                Console.WriteLine(href);
            }

            foreach (IWebElement ele  in elements )
            {
                Console.WriteLine(ele.Text);
                string href = ele.GetAttribute("href");
                Console.WriteLine(href);
            }


            foreach (var ele in elements)
            {
                Console.WriteLine(ele.Text);
                string href = ele.GetAttribute("href");
                Console.WriteLine(href);
            }
        }
    }
}

