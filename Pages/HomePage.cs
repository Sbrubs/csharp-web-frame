using static NUnit.Framework.Assert;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_avivatec.Pages
{
    class HomePage : BasePage
    {
        public HomePage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "login")]
        private IWebElement btnLogin;

        public void ValidarAcesso()
        {
            EvidencePrint("HomePage");
             Equals("My Store", driver.Title);
        }

        public void AcessarLogin()
        {
            btnLogin.Click();
        }
    }
}
