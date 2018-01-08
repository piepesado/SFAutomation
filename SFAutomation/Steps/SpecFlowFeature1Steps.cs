using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;
using System.Configuration;
using SFAutomation.Pages;
using System;

namespace SFAutomation.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        private IWebDriver _driver;

        //Parameters


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        /// <summary>
        /// Clean up the 
        /// </summary>
        [AfterScenario]
        public void Cleanup()
        {
            try
            {
                if (_driver != null)
                {
                    _driver.Close();
                    _driver.Dispose();
                    _driver = null;
                }
            }
            catch (Exception)
            {
                // This will get any exceptions in the cleanup step.
            }
        }
    }
}
