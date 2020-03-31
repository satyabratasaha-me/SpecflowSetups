using System;
using TechTalk.SpecFlow;

namespace UISpecs.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        [When(@"I click to navigate to Login page")]
        public void WhenIClickToNavigateToLoginPage()
        {
            Console.WriteLine("I click to navigate to Login page");
        }
        
        [Then(@"I land to Login Page successfully")]
        public void ThenILandToLoginPageSuccessfully()
        {
            Console.WriteLine("I land to Login Page successfully");
        }

        [When(@"I Sign In using the below details")]
        public void WhenISignInUsingTheBelowDetails(Table table)
        {
            Console.WriteLine("I Sign In using the below details");
        }

        [Then(@"I see the welcome page")]
        public void ThenISeeTheWelcomePage()
        {
            Console.WriteLine("I see the welcome page");
        }

        [Then(@"I see the sign up link")]
        public void ThenISeeTheSignUpLink()
        {
            Console.WriteLine("I see the sign up link");
        }


    }
}
