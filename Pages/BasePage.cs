using teste_avivatec.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.IO;
using NUnit.Framework;

namespace teste_avivatec
{
    class BasePage
    {
        public IWebDriver driver = Driver.GetDriver();

        public void AcessarURL(string url = "http://automationpractice.com/index.php") => driver.Navigate().GoToUrl(url);
    
        public WebDriverWait Wait()
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public void EvidencePrint(string evidenceName)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

            DateTime dataAtual = DateTime.UtcNow; 
            TimeZoneInfo horaBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");


            string date = TimeZoneInfo.ConvertTimeFromUtc(dataAtual, horaBrasilia).ToString("ddMMyyyy");

            var classpath = Path.GetFullPath($@"{System.AppContext.BaseDirectory}..\..\Evidences\");

            string evidencePath = $"{classpath}{date}";

            string printsPath = $"{evidencePath}\\{TestContext.CurrentContext.Test.Name}";

            if (!Directory.Exists(evidencePath))
            {
                Directory.CreateDirectory(evidencePath);
            }
            
            if (!Directory.Exists(printsPath))
            {
                Directory.CreateDirectory(printsPath);
            }
            

            ss.SaveAsFile($"{printsPath}\\{evidenceName}.png", ScreenshotImageFormat.Png);
        }
    }
}
