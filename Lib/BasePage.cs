using System.Reflection.Metadata.Ecma335;
using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;



namespace Lib
{
    public abstract class BasePage
    {
        protected abstract IWebElement  Container { get; }

        //protected BasePage()
        //{
        //    new WebDriverWait(Driver, TimeSpan.FromSeconds(7)).Until(d =>
        //        d.ExecuteJavaScript<bool>("return document && document.readState == 'complete'"));

        //}

        protected static IWebDriver Driver
        {
            get
            {
              return  ChromeDriverFactory.Driver;
            }
        }


    }
}
