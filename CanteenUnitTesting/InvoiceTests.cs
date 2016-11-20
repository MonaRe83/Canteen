using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CanteenFoodOrdering;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace CanteenUnitTesting
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void SaveInvoiceTest()
        {
            List<Product> products = new List<Product>();
            products.Add(new PizzaTopping("Pepperoni Pizza", 3.50f));

            MenuForm menu = new MenuForm();
            menu.orderList = products;

            Invoice invoice = new Invoice(products, menu.CalcPrice());
            invoice.DisplayOBject();
            invoice.SaveToInvoice();

            string expectedInvoice = @"--Central Canteen Order Invoice--

            Pepperoni Pizza - $3.50
            Total Price: $3.50
            " + DateTime.Now.ToLongDateString() + @"

            Thanks, Have a Great Day and Enjoy your Meal
            ";

        string documents = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MoniquesCanteenApplication");


        string path = documents + @"/invoice.txt";

        if (!File.Exists(path))
        {
            Assert.Fail("Invoice was not created");
        }
           string readText = File.ReadAllText(path);

           Assert.AreEqual(expectedInvoice, readText);
        }
    }
}
