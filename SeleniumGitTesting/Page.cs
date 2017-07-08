using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumGitTesting
{
    public class Page
    {
        private static IWebDriver _driver = new ChromeDriver();
          
        public IWebDriver Driver
        {
            get { return _driver; }            
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("http://www.ynet.co.il/home/0,7340,L-8,00.html");
            _driver.Manage().Window.Maximize();                        
        }

        public string GetText()
        {
            return _driver.FindElement(By.TagName("body")).Text;
        }
    }
}
