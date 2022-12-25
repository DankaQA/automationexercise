using AutomationExerciseFramework.Helpers;
using AutomationExerciseFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationExerciseFramework.Steps
{
    [Binding]
    public class ContactUsSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HederPage hp = new HederPage(Driver);

        [Given(@"user opens contact us page")]
        public void GivenUserOpensContactUsPage()
        {
            ut.ClikOnElement(hp.contactLink);
        }
        
        [When(@"user enters all required fields")]
        public void WhenUserEntersAllRequiredFields()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user submits contact us form")]
        public void WhenUserSubmitsContactUsForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"confirms the prompt message")]
        public void WhenConfirmsThePromptMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user will receive '(.*)' message")]
        public void ThenUserWillReceiveMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
