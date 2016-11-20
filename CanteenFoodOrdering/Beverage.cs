using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenFoodOrdering
{
    /// <summary>
    /// this is the class for beverage , the array will sore the information  into listbox and allows you to call it when needed
    /// </summary>
   public class Beverage
    {
       /// <summary>
       /// Beverage array to store name and prices of drinks 
       /// </summary>
        private static BeverageDrink[] drink = new BeverageDrink[]
    {
            new BeverageDrink ("Coco-Cola", 3.0f),
            new BeverageDrink ("Fanta", 3.0f),
            new BeverageDrink ("Pepsi", 3.0f),
            new BeverageDrink ("Water", 1.50f),
            new BeverageDrink("Orange juice",2.0f),
            new BeverageDrink("Coffee", 2.0f),
            new BeverageDrink("Hot Choc",2.0f)
    };

   /// <summary>
        /// automaticly implement code when adding it to combobox 
   /// </summary>
        public static BeverageDrink[] Drink
        {
            get { return Beverage.drink; }
            set { Beverage.drink = value; }
        }
   }
    /// <summary>
    /// This conects to classs product  which gets name and price and adds the price of drinks selected
    /// </summary>
   public class BeverageDrink : Product
   {
       /// <summary>
       /// Initializes <see cref="BeverageDrink"/>
       /// </summary>
       /// <param name="name">name of product </param>
       /// <param name="price"> price of product</param>
       public BeverageDrink(string name, float price)
           : base(name, price)
       {
        
       }
   }


}
