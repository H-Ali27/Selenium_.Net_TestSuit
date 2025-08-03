using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1;

namespace Heckathone1
{
    [TestClass]
    public class ExecutionClass : baseclass
    {
        baseclass bc = new baseclass();

        [TestInitialize]
        public void Init()
        {
            seleniumInit("chrome");
            extentreport.Report();

        }
        [TestCleanup]
        public void Cleanup()
        {
            DriverClose();
            extentreport.flush();
        }

        LoginPage loginPage = new LoginPage();  
        [TestMethod]
        public void Valid_Login() 
        {
            loginPage.Valid_login("https://www.saucedemo.com/v1/index.html");
        }
    }
}
