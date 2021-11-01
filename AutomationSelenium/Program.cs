using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AutomationSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"E:\");

            string url = "http://localhost:14430/Pizza";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            IWebElement ViewPizza = driver.FindElement(By.Id("2"));
            ViewPizza.Click();
            Thread.Sleep(3000);

            IWebElement FirstName = driver.FindElement(By.Id("fn"));
            FirstName.SendKeys("Ramya");
            Thread.Sleep(1000);

            IWebElement LastName = driver.FindElement(By.Id("ln"));
            LastName.SendKeys("K T");
            Thread.Sleep(1000);

            IWebElement Email = driver.FindElement(By.Id("email"));
            Email.SendKeys("ramya.kt864@gmail.com");
            Thread.Sleep(1000);

            IWebElement Address = driver.FindElement(By.Id("add"));
            Address.SendKeys("Door No: 1234, Street: ABCD, City: EFGH, District: IJKL, State: MNOP, Country: India");
            Thread.Sleep(1000);

            IWebElement ZipCode = driver.FindElement(By.Id("zip"));
            ZipCode.SendKeys("987456");
            Thread.Sleep(1000);

            IWebElement Payment = driver.FindElement(By.Id("cash"));
            Payment.Click();
            Thread.Sleep(4000);

            IWebElement Order = driver.FindElement(By.Id("checkout"));
            Order.Click();
            Thread.Sleep(4000);

            IWebElement Shop = driver.FindElement(By.Id("again"));
            Shop.Click();
            Thread.Sleep(10000);

            driver.Quit();
        }
    }
}
