using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Core
{
    public class ChromeDriverFactory
    {
        public static IWebDriver Driver;

        public static IWebDriver CreateChromeDriver()
        {
            var chromeServic = ChromeDriverService.CreateDefaultService();
            chromeServic.HideCommandPromptWindow = true;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            chromeOptions.AddArgument("--ignore-certificate-errors");
            chromeOptions.AddArgument("--disable-popup-blocking");
            chromeOptions.AddArgument("--incognito");
            chromeOptions.AddArgument("--disable-default-apps");

            var driver = new ChromeDriver(chromeServic, chromeOptions);
            return driver; 
        }


    }

}
