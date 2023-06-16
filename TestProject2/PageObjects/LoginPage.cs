using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Utilities;

namespace TestProject1.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //PageObject factory
        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement username;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "login-button")]
        private IWebElement loginbtn;

        [FindsBy(How = How.XPath, Using = "//h3[@data-test='error']")]
        private IWebElement errormsg;



        //Acciones o pasos a realizar con los elementos para ello creamos un nuevo metodo, para no tener hacodeado las credenciaces podemos agregar parametros.

        public void ValidLogin(string user, string pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            loginbtn.Click();
       
        }

        public void InvalidLogin(string user, string pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            loginbtn.Click();

            String errorText = errormsg.Text;
            StringAssert.Contains("Epic sadface", errorText);

        }
    }
}
