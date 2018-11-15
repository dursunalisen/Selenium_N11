using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace n11
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            string link = @"http://www.n11.com/ ";
            driver.Navigate().GoToUrl(link);

            driver.FindElement(By.ClassName("btnSignIn")).Click();
            
            driver.FindElement(By.Id("email")).SendKeys("dursunalisen@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("147.Dursun");
            driver.FindElement(By.Id("loginButton")).Click();
            
                driver.FindElement(By.Id("searchData")).SendKeys("Samsung");
            driver.FindElement(By.ClassName("searchBtn")).Click();
            driver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[3]/a[2]")).Click();
            
            driver.FindElement(By.XPath(".//*[@id='p-292859244']/div[1]/a")).Click();
            
            driver.FindElement(By.ClassName("addToFavorites item ")).Click();


        }
    }
}
