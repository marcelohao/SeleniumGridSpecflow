using System;
using TechTalk.SpecFlow;
using UITests.Support;
using UITests.PageObjects;

namespace UITests.StepDefinitions
{
    [Binding]
    public class EcommStepDefinitions
    {
        private readonly DriverBase _driver;
        private readonly EcommHomePage _homepage;

        public EcommStepDefinitions(DriverBase currDriver)
        {
            _driver = currDriver;
            _homepage= new EcommHomePage(_driver.Driver);
        }

        [Given(@"the login page is loaded")]
        public void GivenTheLoginPageIsLoaded()
        {
            _homepage.GoToPage();
        }

        [When(@"the credentials are entered")]
        public void WhenTheCredentialsForTheStandardUserAreEntered()
        {
            _homepage.EnterCredentials("standard_user", "secret_sauce");
        }

        [Then(@"the inventory will be presented")]
        public void ThenTheInventoryWillBePresented()
        {
            System.Threading.Thread.Sleep(30000);
        }
    }
}
