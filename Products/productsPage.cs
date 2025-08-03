using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    public class productsPage : baseclass
    {
        public void products()
        {
            string json = File.ReadAllText("E:/Selenium Practice/Heckathone01/UnitTestProject1/Resources/Locators.json");
            dynamic locators = JsonConvert.DeserializeObject(json);

            string Prod1 = locators.InventoryPage.Product1;
            string Prod2 = locators.InventoryPage.Product2; 
            string Sort = locators.InventoryPage.SelectDropdown;
            string Option = locators.InventoryPage.Option;
            string Prod3 = locators.InventoryPage.Product3; 
            string Prod4 = locators.InventoryPage.Product4;

            Action("click",Prod1,"prod1","prod1","scrollup",0,"Product1 Selection","Product1",path,"png");
            Action("click",Prod2,"prod2","prod2","scrolldown",0,"Product2 Selection","Product2",path,"png");
            Action("click",Sort,"Sorting","Sort","scrollup",0,"Sorting Items","Sorting",path,"png");
            Action("click",Option,"SortOption","SortOption","scrollup",0,"SortingOpt","Sorting Option Seletion",path,"png");
            Action("click",Prod3,"prod3","prod3","scrolldown",0,"Product3 Selection","Product3",path,"png");
            Action("click",Prod4,"prod4","prod4","scrolldown",0,"Product4 Selection","Product4",path,"png");


        }
    }
}
