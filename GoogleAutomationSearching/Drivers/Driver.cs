using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleAutomationSearching.Drivers
{
    public class Driver : IDisposable
    {
        private readonly Lazy<IWebDriver> _driver;
        private bool _isDisposed;

        public IWebDriver CurrentDriver => _driver.Value;

        public Driver()
        {
            _driver = new Lazy<IWebDriver>(CreateWebDriver);
        }

        private IWebDriver CreateWebDriver()
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            var chromeOptions = new ChromeOptions();
            var chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions);
            return chromeDriver;
        }

        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            if (_driver.IsValueCreated)
            {
                CurrentDriver.Quit();
            }

            _isDisposed = true;
        }
    }
}