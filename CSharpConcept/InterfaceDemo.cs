using CSharpConcept;
using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    interface IWebDriverDemo
    {
        public abstract void Quit();
        string URL { get; set; }

        void Click();
    }

    interface IJavascriptExecutor
    {
        void ExecuteScript();
    }

    class ChromeDriverDemo : IWebDriverDemo,IJavascriptExecutor
    {
        public void OnlyChrome()
        {

        }
        public string URL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Click()
        {
           ///click on chrome
        }

        public void Quit()
        {
            //close chrome 
        }

        public void ExecuteScript()
        {
          
        }
    }

    class FirefoxDemo : IWebDriverDemo,IJavascriptExecutor
    {
        public string URL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Click()
        {
            throw new NotImplementedException();
        }

        public void ExecuteScript()
        {
           
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }
    }

    class Programrr
    {
        public static void PayRollrr(IWebDriverDemo e)
        {
            Console.WriteLine(e);
        }
        static void Mainee(String[] args)
        {
            IWebDriverDemo driver = new ChromeDriverDemo();
            driver.Quit();
            driver.Click();

            IJavascriptExecutor js = (IJavascriptExecutor)driver;
            js.ExecuteScript();

            //Program p = (Program)driver;
        }

    }
}
