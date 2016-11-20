using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanteenFoodOrdering
{
    /// <summary>
    /// class pizza stores size of meat pizza in an array 
    /// </summary>
    public class Pizza
    {
        private static PizzaMeat[] meat = new PizzaMeat[]
        {
            new PizzaMeat("Small", 1.0f),
            new PizzaMeat("Medium", 5.0f),
            new PizzaMeat("Large", 10.0f),     
        };

        /// <summary>
        ///  automaticly implement code when adding it to combobox 
        /// </summary>
        public static PizzaMeat[] Meat
        {
            get { return Pizza.meat; }
            set { Pizza.meat = value; }
        }

        private static PizzaTopping[] topping = new PizzaTopping[]
        {
            new PizzaTopping("Grand Supreme Pizza", 5.0f),
            new PizzaTopping("Hawaiian Pizza", 5.0f),
            new PizzaTopping("Americano Pizza", 5.0f),
            new PizzaTopping("Pepperoni Pizza", 5.0f),
           
        };
        /// <summary>
        ///  automaticly implement code when adding it to combobox 
        /// </summary>
        public static PizzaTopping[] Topping
        {
            get { return Pizza.topping; }
            set { Pizza.topping = value; }
        }

        /// <summary>
        /// Storting  info into the array to be used in combobox
        /// </summary>
        public static PizzaCrust[] crust = new PizzaCrust[]
        {
            new PizzaCrust("Thick", 1.0f),
            new PizzaCrust("Thin", 0.0f),
           
        };
        /// <summary>
        /// automaticly implement code when adding it to combobox 
        /// </summary>
        public static PizzaCrust[] Crust
        {
                get { return Pizza.crust; }
                set { Pizza.crust = value; }
        }

    }

    /// <summary>
    /// The name and price of PizzaMeat will be added into product to calculate a total cost  
    /// </summary>
    public class PizzaMeat : Product
       {
            /// <summary>
            /// Initializes <see cref="PizzaMeat"/>
            /// </summary>
            /// <param name="name">name of product </param>
            /// <param name="price"> price of product</param>
            public PizzaMeat(string name, float price)
                : base(name, price)
            {
            }
       }

    /// <summary>
    ///  This allows pizzatopping to connect to Product Class
    /// </summary>
    
    public class PizzaTopping : Product
       {
           /// <summary>
           /// Initializes <see cref="PizzaTopping"/>
           /// </summary>
           /// <param name="name">name of product </param>
           /// <param name="price">price of product</param>
           public PizzaTopping(string name, float price)
                : base(name, price)
           {
           }
       }
    /// <summary>
    ///  This allows pizzacrust topping to connect to Product Class
    /// </summary>
     public class PizzaCrust : Product
       {
           /// <summary>
           /// Initializes <see cref="PizzaCrust"/>
           /// </summary>
           /// <param name="name">name of product </param>
           /// <param name="price">price of product</param>
           public PizzaCrust(string name, float price)
                : base(name, price)
           {
           }
       }

}
