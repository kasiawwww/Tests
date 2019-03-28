using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    class TestCase
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.demoqa.com";

            driver.FindElement(By.XPath(".//[@id='menu-item-374']/a'")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();

            String title = driver.Title;
            int titleLength = driver.Title.Length;
            Console.WriteLine("Title of this page is: "+ title);
            Console.WriteLine("Length of this title is " + titleLength);

            string pageURL = driver.Url;
            int URLLength = pageURL.Length;

            Console.WriteLine("URL of this website is " + pageURL);
            Console.WriteLine("Length of this URL is " + URLLength);



            driver.Close();
        }
    }
}
