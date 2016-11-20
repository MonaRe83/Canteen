using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenFoodOrdering
{
    /// <summary>
    /// this is the class for Desert, the array will sore the information into listbox 
    /// </summary>
   public class Desert
    {
       private static DesertYum[] yum = new DesertYum[]
       
        {
                new DesertYum("blueberry Cheese Cake", 4.0f),
                new DesertYum("Mango Ice Cream", 3.0f),
                new DesertYum("Cookies and cream", 4.0f),
                new DesertYum("choclate Brownies", 5.0f)
       
        };
       /// <summary>
       /// automaticly implement code when adding it to combobox 
       /// </summary>
       public static DesertYum[] Yum
       {
           get { return Desert.yum; }
           set { Desert.yum = value; }
       }

    }
   /// <summary>
   /// This conects to classs product  which gets name and price and adds the price of Deserts selected
   /// </summary>
   public class DesertYum :Product
   {
       /// <summary>
       /// Initializes <see cref="DesertYum"/>
       /// </summary>
       /// <param name="name"> name of product </param>
       /// <param name="price"> price of product</param>
       public DesertYum(string name, float price)
           : base(name, price)
       { 
       }
   }
}

