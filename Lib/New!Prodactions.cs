using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class New_Prodactions : BasePage
    {
        protected override IWebElement Container => Driver.FindElement(By.CssSelector("#maincontent.page-main"));
    }
}
