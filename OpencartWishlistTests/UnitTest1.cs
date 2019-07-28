using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace OpencartWishlistTests
{
    [TestFixture]
    public class OpencartWishlistAdd
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            //driver.Close();
            driver.Quit();
        }

        [SetUp]
        public void SetupTest()
        {
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
        public void TheOpencartWishlistAddTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://192.168.20.128/opencart/upload/");
            driver.FindElement(By.LinkText("Desktops")).Click();
            driver.FindElement(By.LinkText("Show All Desktops")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[22]")).Click();
            driver.FindElement(By.CssSelector("i.fa.fa-heart")).Click();
            
                Assert.AreEqual("iPhone", driver.FindElement(By.LinkText("iPhone")).Text);
            
                Assert.AreEqual("product 11", driver.FindElement(By.CssSelector("tbody .text-left:nth-child(3)")).Text);
            
                Assert.AreEqual("In Stock", driver.FindElement(By.CssSelector("tbody .text-right:nth-child(4)")).Text);
            
                Assert.AreEqual("$101.00", driver.FindElement(By.CssSelector(".price")).Text);
            
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
