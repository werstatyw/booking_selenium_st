using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://www.booking.com/index.en-gb.html?label=gen173nr-1BCAEoggI46AdIM1gEaGeIAQGYAQm4AQfIAQzYAQHoAQGIAgGoAgO4Avu644sGwAIB0gIkOGU4N2RjNDUtOTY3Yi00Y2I0LWE3YTYtYWY4MzFiY2EyZWY12AIF4AIB;sid=1579888e024746bfb0a42b19db0c16b0;keep_landing=1;sb_price_type=total;sig=v1UnAcuUs2&");
            driver.FindElement(By.XPath("//img[contains(@src,'https://cf.bstatic.com/static/img/flags/new/48-squared/gb/daba79fdd4066d133e8bf59070fd6819b951c403.png')]")).Click();
            driver.FindElement(By.XPath("//div[@id='language-selection']/div/div/div/div/div/div/div/div[2]/div/ul/div/ul/li[2]/a/div/div[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='_tdw1cksys']/div/div/div/div/div/div/div/div[2]/div/div/div/ul/li[2]/a/div/div/div")).Click();
            driver.FindElement(By.Id("ss")).Click();
            driver.FindElement(By.Id("ss")).Clear();
            driver.FindElement(By.Id("ss")).SendKeys("Saint-Petersburg");
            driver.FindElement(By.XPath("//form[@id='frm']/div/div/div/div/ul/li/span[2]")).Click();
            driver.FindElement(By.XPath("//form[@id='frm']/div/div[2]/div[2]/div/div/div[3]/div/table/tbody/tr[5]/td[7]/span/span")).Click();
            driver.FindElement(By.XPath("//form[@id='frm']/div/div[2]/div[2]/div/div/div[3]/div[2]/table/tbody/tr/td/span/span")).Click();
            driver.FindElement(By.XPath("//label[@id='xp__guests__toggle']/span[2]/span")).Click();
            driver.FindElement(By.XPath("//div[@id='xp__guests__inputs-container']/div/div/div[2]/div/div[2]/button[2]")).Click();
            driver.FindElement(By.Id("group_children")).Clear();
            driver.FindElement(By.Id("group_children")).SendKeys("1");
            driver.FindElement(By.Name("age")).Click();
            new SelectElement(driver.FindElement(By.Name("age"))).SelectByText("5 years old");
            driver.FindElement(By.XPath("//div[@id='xp__guests__inputs-container']/div/div/div[2]/div/div[2]/button/span")).Click();
            driver.FindElement(By.Id("group_children")).Clear();
            driver.FindElement(By.Id("group_children")).SendKeys("1");
            driver.FindElement(By.XPath("//div[@id='xp__guests__inputs-container']/div/div/div[4]/div/div[2]/button[2]/span")).Click();
            driver.FindElement(By.Id("no_rooms")).Clear();
            driver.FindElement(By.Id("no_rooms")).SendKeys("2");
            driver.FindElement(By.Id("frm")).Click();
            driver.FindElement(By.XPath("//form[@id='frm']/div[3]/label")).Click();
            driver.FindElement(By.XPath("//form[@id='frm']/div/div[4]/div[2]/button/span")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by.id("property-card"));
                where ((driver.FindElement(By.id("price-and-discounted-price")), Is.LowerThan(50)) && (driver.FindElement(By.Id("review-score")), Is.GreaterThan(8.0)));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
