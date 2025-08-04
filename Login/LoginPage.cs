using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenQA.Selenium;
using UnitTestProject1;

namespace UnitTestProject1
{
    internal class LoginPage : baseclass
    {
        
        //By usrname = By.XPath("//div/form/input[1]");
        //By password = By.XPath("//div/form/input[2]");
        //By login = By.XPath("//div/form/input[3]");
        productsPage pp = new productsPage();
        Cartpage cp = new Cartpage();   
        InformationPage ip = new InformationPage();    
        public void Valid_login(string url)
        {
            string json = File.ReadAllText("E:/Selenium Practice/Heckathone01/UnitTestProject1/Resources/Locators.json");
            dynamic locators = JsonConvert.DeserializeObject(json);
            
            string usernameXpath = locators.LoginPage.UsernameField;
            string passXpath = locators.LoginPage.PasswordField;
            string loginXpath = locators.LoginPage.LoginButton;


            var dataList = CsvReaderFileUtility.ReadTestData(@"TestData\TestData.csv");
            foreach (var data in dataList)
            {
                driver.Url = url;
                extentreport.Parent_log("Login Page");
                extentreport.Child_log("Valid Login");
                Action("write", usernameXpath, data.username, "username","scrolldown",0,"UsernameField","username",path,"png");
                //screenshot("username",path,"jpg");
                Action("write", passXpath, data.password, "password", "scrolldown", 0,"passwordfield","password",path, "png");
                Action("click", loginXpath, "login", "login", "scrolldown", 0,"loginbutton","loginButton",path ,"png");
               
                //Inventory Page
                extentreport.Parent_log("Inventory Page");
                extentreport.Child_log("Products Selection & Sorting");
                pp.products();
                //Cart Page
                extentreport.Parent_log("Cart Page");
                extentreport.Child_log("Products Cart");
                cp.CartPage();
                //Checkout Page
                extentreport.Parent_log("CheckOut Page");
                extentreport.Child_log("Check Out Information");
                ip.Information();
            }

        }
    }
}
