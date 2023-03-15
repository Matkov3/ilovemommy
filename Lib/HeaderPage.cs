using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Lib
{
    public class HeaderPage : BasePage
    {
        protected override IWebElement Container => Driver.FindElement(By.CssSelector(".page-wrapper"));

        private  IWebElement Navigations => Container.FindElement(By.CssSelector("nav.navigation"));

        public void ChangeСhapter(string nameField)
        {
           Navigations.FindElements(By.CssSelector("li a.level-top")).First(n => n.Text == nameField).Click();

            //var elements = Navigations.FindElements(By.CssSelector("li a.level-top"));
            //var texts = elements.Select(e => e.Text).ToList();


        }

        
    }
}
