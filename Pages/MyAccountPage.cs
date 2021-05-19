using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Framework.Assert;

namespace teste_avivatec.Pages
{
    class MyAccountPage : BasePage
    {
        public MyAccountPage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[text()='My account']")]
        private IWebElement titleMyAccount;

        [FindsBy(How = How.ClassName, Using = "info-account")]
        private IWebElement lblWelcomeAccount;

        [FindsBy(How = How.XPath, Using = "//div[@class='header_user_info']//span")]
        private IWebElement linkUserAccountName;

        public void ValidarMyAccount()
        {
            True(titleMyAccount.Displayed);
        }

        public void ValidarMensagemWelcome()
        {
            EvidencePrint("Usuário Logado");
            Equals(lblWelcomeAccount.GetAttribute("text"), "Welcome to your account. Here you can manage all of your personal information and orders.");
        }

        public void ValidarUsuarioLogado(string nome, string sobrenome)
        {
            Equals($"{nome} {sobrenome}", linkUserAccountName.GetAttribute("text"));
            EvidencePrint("Usuário Logado");
        }



    }
}
