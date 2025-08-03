using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Threading;

namespace UnitTestProject1
{
    public class baseclass 
    {
        public static WebDriver driver;
        public static string path = @"E:\Selenium Practice\Heckathone01\UnitTestProject1\Screenshots";
        public static void seleniumInit(string browser)
        {
            BOption(browser);
            driver.Manage().Window.Maximize();
        }

        public static void DriverClose()
        {
            driver.Close();
            driver.Quit();  
        }

        public static void BOption(string Boption)
        {
            if(Boption == "Chrome" || Boption == "chrome") 
            {
                driver = new ChromeDriver();
            }
            else if(Boption == "Edge" || Boption == "edge")
            {
                driver = new EdgeDriver();
            }
            else if (Boption == "Firefox" || Boption == "firefox")
            {
                driver = new FirefoxDriver();
            }
        }

        public static void Action(string operation,string locator,string text,string exptext,string direction, int val, string detail, string filename,string path, string format)
        {
            var by = GetBy(locator);
            if (operation == "write")
            {
                try
                {
                    driver.FindElement(by).SendKeys(text);
                    extentreport.LogReport(detail,filename,path,format);
                    JSExecutor(direction,val);
                }
                catch (Exception ex)
                {
                    extentreport.LogReportFailed(detail, filename, path,format);
                    throw ex;
                }
            }
            else if (operation == "click")
            {
                try
                {
                    JSExecutor(direction,val);
                    driver.FindElement(by).Click();
                    extentreport.LogReport(detail, filename, path, format);
                    Thread.Sleep(2000);
                }
                catch(Exception ex)
                {
                    extentreport.LogReportFailed(detail, filename, path,format);
                    throw ex;
                }
            }
            else if (operation == "assert")
            {
                try
                {
                    string astext = driver.FindElement(by).Text;
                    extentreport.LogReport(detail, filename, path, format);
                    Assert.AreEqual(exptext, astext);
                }
                catch (Exception ex)
                {
                    extentreport.LogReportFailed(detail, filename, path, format);
                    throw ex;
                }
            }
            else if(operation == "select")
            {
                try
                {
                    var dropdown = driver.FindElement(by);
                    var selectdropdown = new SelectElement(dropdown);
                    selectdropdown.SelectByText(text);
                    extentreport.LogReport(detail, filename, path, format);
                }
                catch (Exception ex)
                {
                    extentreport.LogReportFailed(detail, filename, path, format);
                    throw ex;
                }
            }
        }
        public static By GetBy(string locator)
        {
            if (locator.Contains(":"))
            {
                var parts = locator.Split(new[] { ':' }, 2);
                var type = parts[0].Trim().ToLower();
                var value = parts[1].Trim();

                switch (type)
                {
                    case "id":
                        return By.Id(value);
                    case "name":
                        return By.Name(value);
                    case "xpath":
                        return By.XPath(value);
                    case "css":
                        return By.CssSelector(value);
                    case "class":
                        return By.ClassName(value);
                    case "tag":
                        return By.TagName(value);
                    case "linktext":
                        return By.LinkText(value);
                    case "partiallinktext":
                        return By.PartialLinkText(value);
                    default:
                        throw new ArgumentException("Unsupported locator type: " + type);
                }
            }

            else
            {
                if (locator.StartsWith("//") || locator.StartsWith("(//"))
                    return By.XPath(locator);
                if (locator.StartsWith("#") || locator.StartsWith("."))
                    return By.CssSelector(locator);

                throw new ArgumentException("Unable to infer locator type. Provide a prefix like 'id:' or use standard XPath or CSS selector.");
            }
        }

        //Screenshot
        public static void screenshot(string filename, string path, string fileformat)
        {
            fileformat = fileformat.ToUpper();
            Screenshot image_user = ((ITakesScreenshot)driver).GetScreenshot();
            string fullPath = Path.Combine(path, filename);
            if (fileformat == "PNG")
            {
                image_user.SaveAsFile(fullPath + ".png");
            }
            else if (fileformat == "JPEG" || fileformat == "JPG")
            {
                image_user.SaveAsFile(fullPath + ".Jpeg");
            }
        }

        //window scroll up & down Method
        public static void JSExecutor(string direct, int val)
        {
            IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
            direct.ToUpper();
            if (direct == "SCROLLDOWN")
            {
                js.ExecuteScript("window.scrollBy(0," + val + ")");
            }
            else if (direct == "SCROLLUP")
            {
                js.ExecuteScript("window.scrollBy(0," + val + ")");
            }
        }
    }
}
