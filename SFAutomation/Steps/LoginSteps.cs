using System;
using TechTalk.SpecFlow;

namespace SFAutomation.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"that I navigate to the APEX Portal Url")]
        public void GivenThatINavigateToTheAPEXPortalUrl()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have entered edward\.hart@travelleaders\.com as username")]
        public void WhenIHaveEnteredEdward_HartTravelleaders_ComAsUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have entered zaq(.*)ZAQ! as password")]
        public void WhenIHaveEnteredZaqZAQAsPassword(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have entered (.*) as the CID number")]
        public void WhenIHaveEnteredAsTheCIDNumber(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should land on Apex hompage for Agency Agent role")]
        public void ThenIShouldLandOnApexHompageForAgencyAgentRole()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
