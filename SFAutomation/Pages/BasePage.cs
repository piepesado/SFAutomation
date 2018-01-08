using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;
using System.Threading;

namespace SFAutomation.Pages
{
    /// <summary>
    /// The base class implementation of a page.
    /// </summary>
    public class BasePage
    {
        protected IWebDriver _driver;

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="driver"></param>
        public BasePage(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
            PageFactory.InitElements(_driver, this);
        }

        /// <summary>
        /// Wait for an element to be visible.
        /// </summary>
        /// <param name="element"></param>
        /// <exception cref="NoSuchElementException"></exception>"
        public void WaitForElementVisible(IWebElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(120));
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    wait.Until(d => element.Displayed);
                    break;
                }
                catch (Exception)
                {
                    Thread.Sleep(1000);
                }
            }
        }
        /// <summary>
        /// Enters user strings
        /// </summary>
        /// <param name="element"></param>   
        /// <param name="text"></param>  
        public void SetElementText(IWebElement element, string text)
        {
            WaitForElementVisible(element);
            element.Clear();
            element.Click();
            Assert.Equals(element.GetAttribute("value"), text);
        }

        public void EnsurePageIsLoaded(string pageTitle)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(120));
            wait.Until(d => d.Title.Contains(pageTitle));
            Thread.Sleep(2000);
        }

        //This procedure is to be used when normal checkbox flow does not work
        //Html command sample:
        //"document.getElementById('chkTerms').click();"
        public void ClickCheckBox(string htmlCommand)
        {
            var js = _driver as IJavaScriptExecutor;

            if (js != null)
            {
                js.ExecuteScript(htmlCommand);
            }
        }
    }
}
