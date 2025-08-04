using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    public class InformationPage : baseclass
    {
        public void Information()
        {
            string json = File.ReadAllText("E:/Selenium Practice/Heckathone01/UnitTestProject1/Resources/Locators.json");
            dynamic locators = JsonConvert.DeserializeObject(json);

            string header = locators.InformationPage.InfoHeader;
            string fname = locators.InformationPage.fname;
            string lname = locators.InformationPage.lname;
            string postal = locators.InformationPage.Postal;
            
            Action("assert", header, "asserttext", "Checkout: Your Information", "scrollup", 0, "Header Text Assetion", "headertext", path, "png");
            Action("write", fname, "hamza", "fname", "scrollup", 0, "first name input", "fname", path, "png");
            Action("write", lname, "ali", "lname", "scrollup", 0, "last name input", "lname", path, "png");
            Action("write", postal, "75660", "postal", "scrollup", 0, "postal address", "postal", path, "png"); ;
        }
    }
}
