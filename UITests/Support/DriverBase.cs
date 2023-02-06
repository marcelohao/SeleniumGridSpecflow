using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;

namespace UITests.Support
{
    public class DriverBase
    {
        public IWebDriver? Driver { get; private set; }

        public DriverBase()
        {
        }

        public void SetupRemoteChrome()
        {
            ChromeOptions capabilities = new();
            capabilities.AddArguments(new List<string>
            {
                "--no-first-run",
                "--disable-site-isolation-trials",
                "--no-default-browser-check",
                "--ignore-certificate-errors",
                "--no-sandbox",
                "--window-size=1920,1080",
                "--disable-dev-shm-usage",
                "--headless"
            });

            var remoteURL = new Uri($"http://localhost:4444/");

            Driver = new RemoteWebDriver(remoteURL, capabilities);
        }
    }
}
