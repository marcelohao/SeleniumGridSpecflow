using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UITests.Support
{
    [Binding]
    public sealed class Hooks
    {
        private readonly DriverBase _driverBase;
        private readonly IObjectContainer _objectContainer;

        public Hooks(DriverBase driverBase, IObjectContainer objectContainer)
        {
            _driverBase = driverBase;
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driverBase.SetupRemoteChrome();
            _objectContainer.RegisterInstanceAs(_driverBase.Driver);
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _objectContainer.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
            _objectContainer.Dispose();
        }
    }
}