using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppointmentApp.E2ETests
{
    public class SeleniumTestBase : IDisposable
    {

        protected IWebDriver Driver { get;  set; }

        public SeleniumTestBase()
        {
            var options = new ChromeOptions ();
            options.AddArgument("--headless");

            Driver=new ChromeDriver(options);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void Dispose()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}
