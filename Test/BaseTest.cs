using Core;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using OpenQA.Selenium;
using NUnit.Framework;


namespace Test
{
    public class BaseTest
    {
        protected static IWebDriver Driver => ChromeDriverFactory.Driver;

        [OneTimeSetUp]
        public void BeforeTests()
        {
            ChromeDriverFactory.Driver = ChromeDriverFactory.CreateChromeDriver();
        }

        [OneTimeTearDown]
        public void AfterTests()
        {
            ChromeDriverFactory.Driver.Dispose();
        }


    }
}
