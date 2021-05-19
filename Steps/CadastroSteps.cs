using System;
using TechTalk.SpecFlow;
using teste_avivatec.Pages;

namespace teste_avivatec.Steps
{
    [Binding]
    public class CadastroSteps
    {

        HomePage home = new HomePage();
        LoginPage login = new LoginPage();
        CadastroPage cadastro = new CadastroPage();
        MyAccountPage minhaConta = new MyAccountPage();

        [Given(@"que eu acesse o site e vá até a página de cadastro")]
        public void DadoQueEuAcesseOSiteEVaAteAPaginaDeCadastro()
        {
            home.ValidarAcesso();
            home.AcessarLogin();
            login.PreencherEmailCadastro("eu.pietro@gmail.com");
        }
        
        [When(@"insiro meus dados corretamente e finalizo")]
        public void QuandoInsiroMeusDadosCorretamenteEFinalizo()
        {
            cadastro.PreencherInformacoesPessoais("Pietro", 
                                                  "Belli", 
                                                  "eu.pietro@gmail.com",
                                                  "123456",
                                                  "21",
                                                  "6",
                                                  "2001");
            cadastro.PreencherContato("Pietro", 
                                      "Belli",
                                      "2844 S 1030 W SUITE 421682",
                                      "South Salt Lake",
                                      "Utah",
                                      "84119",
                                      "United States",
                                      "+551199999999");
        }
        
        [Then(@"o cadastro é realizado com sucesso")]
        public void EntaoOCadastroERealizadoComSucesso()
        {
            minhaConta.ValidarMyAccount();
        }
    }
}
