using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:4200/user/login");
            driver.FindElement(By.Name("UserName")).SendKeys("hansi");
            driver.FindElement(By.Name("Password")).SendKeys("0987");
        }
    }
}
