using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.FindElement(By.Id("fef"));
            IList<int> blref = null;

            blref[2] = 3;
            
        }
    }
}
