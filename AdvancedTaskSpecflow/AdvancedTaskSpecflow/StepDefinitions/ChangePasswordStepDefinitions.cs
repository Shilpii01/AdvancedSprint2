using System;
using TechTalk.SpecFlow;

namespace AdvancedTaskSpecflow.StepDefinitions
{
    [Binding]
    public class ChangePasswordStepDefinitions
    {
        [Given(@"User is logged in to the mars portal")]
        public void GivenUserIsLoggedInToTheMarsPortal()
        {
            throw new PendingStepException();
        }

        [Given(@"User navigates to the Change password page")]
        public void GivenUserNavigatesToTheChangePasswordPage()
        {
            throw new PendingStepException();
        }

        [When(@"User enters valid change password details ""([^""]*)""")]
        public void WhenUserEntersValidChangePasswordDetails(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"user can successfully change the current password")]
        public void ThenUserCanSuccessfullyChangeTheCurrentPassword()
        {
            throw new PendingStepException();
        }
    }
}
