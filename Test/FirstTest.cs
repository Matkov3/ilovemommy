using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Core;
using Lib;
using Test;
using Tests;


namespace Tests
{
    [TestFixture]
    public class FirstTest : BaseTest
    {
        [Test]
        public void TestFirstPage()
        {
            Driver.Navigate().GoToUrl("https://ilovemommy.com.ua/");

            HeaderPage menu = new HeaderPage();
            menu.ChangeСhapter("NEW!");


        }


    }
}
