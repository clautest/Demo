using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using AngleSharp;
using System.Configuration;

namespace TestProject1.Utilities
{
    public class Base
    {
       public  IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            
            InitBrowser("Chrome");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";


        }

        public void InitBrowser(string browserName)
        {
            switch(browserName)
            {
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;

            }
        }

                    

        [TearDown]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
