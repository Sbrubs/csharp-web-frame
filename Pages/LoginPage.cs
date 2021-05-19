using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static NUnit.Framework.Assert;

namespace teste_avivatec.Pages
{
    class LoginPage : BasePage
    {
        public LoginPage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[text()='Authentication']")]
        private IWebElement titleAuthentication;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement inputEmail;

        [FindsBy(How = How.Name, Using = "passwd")]
        private IWebElement inputSenha;
        
        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement btnSignIn;

        [FindsBy(How = How.Id, Using = "email_create")]
        private IWebElement inputEmailCadastro;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement btnCreateAccount;

        public void ValidarLoginPage()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(btnSignIn);
            actions.Perform();
            EvidencePrint("Login Page");
            True(titleAuthentication.Displayed);
        }

        public void LoginComDadosValidos(string email, string senha)
        {
            EvidencePrint("Login antes do preenchimento");
            inputEmail.SendKeys(email);
            inputSenha.SendKeys(senha);
            EvidencePrint("Login após preenchimento");
            btnSignIn.Click();
        }

        public void PreencherEmailCadastro(string email)
        {
            EvidencePrint("Email para cadastro antes do preenchimento");
            inputEmailCadastro.SendKeys(email);
            EvidencePrint("Email para cadastro após preenchimento");
            btnCreateAccount.Click();
        }

    }
}
