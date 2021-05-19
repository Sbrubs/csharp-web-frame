using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_avivatec.Pages
{
    class CadastroPage : BasePage
    {
        public CadastroPage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'personal information')]")]
        private IWebElement titlePersonalInformation;

        [FindsBy(How = How.Id, Using = "id_gender1")]
        private IWebElement radioSexoMasc;

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        private IWebElement inputFirstName;

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        private IWebElement inputLastName;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement inputEmail;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement inputSenha;

        [FindsBy(How = How.Id, Using = "days")]
        private IWebElement selectDays;

        [FindsBy(How = How.Id, Using = "months")]
        private IWebElement selectMonths;

        [FindsBy(How = How.Id, Using = "years")]
        private IWebElement selectYears;

        [FindsBy(How = How.Id, Using = "firstname")]
        private IWebElement inputFirstNameAddress;

        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement inputLastNameAddress;

        [FindsBy(How = How.Id, Using = "address1")]
        private IWebElement inputEndereco1;
        
        [FindsBy(How = How.Id, Using = "address2")]
        private IWebElement inputEndereco2;

        [FindsBy(How = How.Id, Using = "city")]
        private IWebElement inputCity;

        [FindsBy(How = How.Id, Using = "id_state")]
        private IWebElement selectState;

        [FindsBy(How = How.Id, Using = "postcode")]
        private IWebElement inputZipCode;

        [FindsBy(How = How.Id, Using = "id_country")]
        private IWebElement selectCountry;

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        private IWebElement inputPhone;

        [FindsBy(How = How.Id, Using = "submitAccount")]
        private IWebElement btnRegister;

        public void PreencherInformacoesPessoais(string nome, 
                                                string sobrenome,
                                                string email,
                                                string senha,
                                                string diaNascimento,
                                                string mesNascimento,
                                                string anoNascimento)
        {
            EvidencePrint("Informações pessoais antes do preenchimento");
            radioSexoMasc.Click();
            inputFirstName.SendKeys(nome);
            inputLastName.SendKeys(sobrenome);
            inputEmail.Clear();
            inputEmail.SendKeys(email);
            inputSenha.SendKeys(senha);
            
            var dia = new SelectElement(selectDays);
            dia.SelectByValue(diaNascimento);

            var mes = new SelectElement(selectMonths);
            mes.SelectByValue(mesNascimento);

            var ano = new SelectElement(selectYears);
            ano.SelectByValue(anoNascimento);

            EvidencePrint("Informações pessoais após preenchimento");
        }

        public void PreencherContato(string nome,
                                      string sobrenome,
                                      string endereco,
                                      string cidade,
                                      string estado,
                                      string zipCode,
                                      string pais,
                                      string telefone)
        {
            EvidencePrint("Informações de contato antes do preenchimento");
            Actions actions = new Actions(driver);
            actions.MoveToElement(inputFirstNameAddress);
            actions.Perform();

            inputFirstNameAddress.Clear();
            inputFirstNameAddress.SendKeys(nome);
            inputLastNameAddress.Clear();
            inputLastNameAddress.SendKeys(sobrenome);
            inputEndereco1.SendKeys(endereco);
            inputCity.SendKeys(cidade);

            var state = new SelectElement(selectState);
            state.SelectByText(estado);

            inputZipCode.SendKeys(zipCode);

            var country = new SelectElement(selectCountry);
            country.SelectByText(pais);
            inputPhone.SendKeys(telefone);

            EvidencePrint("Informações de contato após preenchimento");
            btnRegister.Click();
        }

    }
}
