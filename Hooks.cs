using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using teste_avivatec.Config;
using teste_avivatec.Pages;

namespace teste_avivatec
{
    [Binding]
    public sealed class Hooks : Driver
    {
        BasePage basePage = new BasePage();

        private ScenarioContext _contexto;

        public Hooks(ScenarioContext contexto)
        {
            _contexto = contexto;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            GetDriver();
            basePage.AcessarURL();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            FinishDriver();
        }
    }
}
