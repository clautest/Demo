using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject1.PageObjects;
using TestProject1.Utilities;
using TestProject2.Utilities;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1.Tests
{
    public class Tests : Base
    {


        [Test]
        public void SuccessfulLogin()
        {
            LoginPage loginpage= new LoginPage(driver);
            loginpage.ValidLogin(Data.Credentials.Valid.UsernameData, Data.Credentials.Valid.Password);
        }

        [Test]
        public void IcorrectLogin()
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.InvalidLogin(Data.Credentials.Invalid.UsernameData, Data.Credentials.Invalid.Password);
            //String errorText = driver.FindElement(By.XPath("//h3[@data-test='error']")).Text;
            //StringAssert.Contains("Epic sadface", errorText);

        }
    }
}