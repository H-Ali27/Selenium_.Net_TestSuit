using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    public class Cartpage : baseclass
    {
        public void CartPage()
        {
            string json = File.ReadAllText("E:/Selenium Practice/Heckathone01/UnitTestProject1/Resources/Locators.json");
            dynamic locators = JsonConvert.DeserializeObject(json);
            string carticon = locators.CartPage.CartIcon;
            string cartitem1 = locators.CartPage.CartItem1;
            string cartitem2 = locators.CartPage.CartItem2;
            string contShop = locators.CartPage.ContShop;
            string CheckOut = locators.CartPage.CheckOut;

            Action("click", carticon, "carticon", "carticon", "scrollup", 0, "CartIcon button", "carticon", path, "png");
            Action("click", cartitem1, "cartitem1", "cartitem1", "scrollup", 0, "cartitem1 remove button", "cartitem1", path, "png");
            Action("click", cartitem2, "cartitem2", "cartitem2", "scrollup", 0, "cartitem2 remove button", "cartitem2", path, "png");
            Action("click", contShop, "contShop", "contShop", "scrolldown", 0, "Continue Shop button", "contShop", path, "png");
            Action("click", carticon, "carticon", "carticon", "scrollup", 0, "CartIcon button", "carticon", path, "png");
            Action("click", CheckOut, "CheckOut", "CheckOut", "scrolldown", 0, "CheckOut button", "CheckOut", path, "png");
            
        }
    }
}
