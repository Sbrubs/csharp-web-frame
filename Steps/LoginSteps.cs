using System;
using TechTalk.SpecFlow;
using teste_avivatec.Pages;

namespace teste_avivatec.Steps
{
    [Binding]
    public class LoginSteps
    {

        HomePage home = new HomePage();
        LoginPage login = new LoginPage();
        MyAccountPage minhaConta = new MyAccountPage();

        [Given(@"que eu acesse o site e vá até a página de login")]
        public void DadoQueEuAesseOSiteEVaAteAPaginaDeLogin()
        {
            home.ValidarAcesso();
            home.AcessarLogin();
        }


        [Given(@"que eu esteja na página de login")]
        public void DadoQueEuEstejaNaPaginaDeLogin()
        {
            login.ValidarLoginPage();
        }
        
        [When(@"insiro usuário e senha válidos")]
        public void QuandoInsiroUsuarioESenhaValidos()
        {
            login.LoginComDadosValidos("automatomati@gmail.com","12345");
        }
        
        [Then(@"o login é realizado com sucesso")]
        public void EntaoOLoginERealizadoComSucesso()
        {
            minhaConta.ValidarMyAccount();
            minhaConta.ValidarMensagemWelcome();
        }
    }
}
