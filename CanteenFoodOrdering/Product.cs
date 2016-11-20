using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenFoodOrdering
{
    /// <summary>
    /// the base class of all products
    /// </summary>
    public class Product
    {
        private string name;
        private float price;
        /// <summary>
        /// initializes the product
        /// </summary>
        /// <param name="name">the name of the product</param>
        /// <param name="price">the price of the product</param>
        public Product(string name, float price)
        {
            this.name = name;
            this.price = price;
        }
        /// <summary>
        /// the name of the product
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        /// <summary>
        /// the price of the product
        /// </summary>
        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        /// <summary>
        /// this returns name and price of items selected
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} - {1:C}", this.Name, Convert.ToDecimal(this.Price));
        }
    }
}
