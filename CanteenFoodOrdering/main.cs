using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanteenFoodOrdering
{
    /// <summary>
    /// 
    /// </summary>
   public class Main
    {
     
       private static MainOrder[] order = new MainOrder[]
    {
            new MainOrder ("Pasta", 8.0f),
            new MainOrder ("Hot Dog", 6.0f),
            new MainOrder ("Curry", 6.0f),
            new MainOrder ("Roast Beef", 8.0f),
            new MainOrder("Fried Chicken", 7.0f)
    };

       /// <summary>
       /// automaticly implement code when adding it to combobox 
       /// </summary>
       public static MainOrder[] Order
        {
            get { return Main.order; }
            set { Main.order = value; }
        }
    }

   /// <summary>
   /// This conects to classs product  which gets name and price and adds the price of Mainorder selected
   /// </summary>
   public class MainOrder:Product
   {
       /// <summary>
       /// Initializes mainorder
       /// </summary>
       /// <param name="name"> name of product </param>
       /// <param name="price"> price of product</param>
       public MainOrder(string name, float price)
           : base(name, price)
       {

       }
   }
  
    
}
