using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenFoodOrdering
{
    public partial class MenuForm : Form
    {
            public List<Product> orderList = new List<Product>();

        /// <summary>
        /// This allows the infomation from my class into my combo boxes
        /// </summary>
            public MenuForm()
            {
                    InitializeComponent();


                    comboBox2.Items.AddRange(Pizza.Crust);
                    comboBox1.Items.AddRange(Pizza.Meat);

                    btn5FinishOrder.Enabled = false;
                    this.comboBox1.SelectedIndex = 0;
            }

            public void AddProduct(Product value)
            {
                this.orderList.Add(value);
                this.listBox2.Items.Add(value);
                this.CalcPrice();
            }

            public void RemoveProduct(Product value)
            {
                this.orderList.Remove(value);
                this.listBox2.Items.Remove(value);
                this.CalcPrice();
            }
        /// <summary>
        /// This Calculates the price  of each item selected into listbox from different classes
        /// </summary>
        /// <returns></returns>
            public float CalcPrice()
            {
                    float total = 0.0f;
                    foreach (object item in this.listBox2.Items)
                    {
                        if (item is PizzaMeat)
                        {
                                PizzaMeat meat = item as PizzaMeat;

                                total += meat.Price;

                        }
                        else if (item is PizzaTopping)
                        {
                                PizzaTopping topping = item as PizzaTopping;

                                total += topping.Price;
                        }


                        if (item is MainOrder)
                        {
                                MainOrder order = item as MainOrder;

                                total += order.Price;

                        }


                        if (item is BeverageDrink)
                        {
                                BeverageDrink drink = item as BeverageDrink;

                                total += drink.Price;
                        }

                        if (item is DesertYum)
                        {
                                DesertYum yum = item as DesertYum;

                                total += yum.Price;
                        }


                        if (item is PizzaCrust)
                        {
                                PizzaCrust crust = item as PizzaCrust;

                                total += crust.Price;
                        }

                }

                label5.Text = string.Format("Total Price: {0:C}", Convert.ToDecimal(total));

                return total;
            }


        
        /// <summary>
        /// finish button restriction if listbox is empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

                if (listBox1.SelectedItem != null)
                    {
                        if (listBox1.SelectedItem is Product)
                        {
                            AddProduct((Product)listBox1.SelectedItem);

                            if (listBox2.Items.Count >= 1)
                            {
                                btn5FinishOrder.Enabled = true;
                            }
                            else
                            {
                                btn5FinishOrder.Enabled = false;
                            }

                        }
                    }
               
               else
                   {
                        MessageBox.Show("no item selected");
                   }
            }

        /// <summary>
        /// Once main button is clicked items from class wil be sent into listbox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void btn1Main_Click_1(object sender, EventArgs e)
            {
                    this.BackgroundImage = CanteenFoodOrdering.Properties.Resources.main;
                    this.listBox1.Items.Clear();
    
                    foreach (MainOrder main in Main.Order)
                        {
                            listBox1.Items.Add(main);
                        }
            }

    /// <summary>
    /// Once button is clicked image will appear
    /// if combo box1 and 2  items from add product will be moved into list box2
    /// once pizza button is clicked will add items into listbox to select
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
            private void btn2Pizza_Click(object sender, EventArgs e)
            {
                this.BackgroundImage = CanteenFoodOrdering.Properties.Resources.pizza;
                this.listBox1.Items.Clear();

                if (comboBox1 != null)
                    {

                        if (comboBox1.SelectedItem is Product)
                        {
                            AddProduct((Product)comboBox1.SelectedItem);
                        }
                    }
                else
                    {
                        MessageBox.Show("no item selected");
                    }

                if (comboBox2 != null)
                {
                    if (comboBox2.SelectedItem is Product)
                    {
                        AddProduct((Product)comboBox2.SelectedItem);
                    }
                    }
                else
                    {
                        MessageBox.Show("no item selected");
                    }

           

                listBox1.Items.AddRange(Pizza.Topping);
            


                if (listBox2.Items.Count >= 1)
                {
                    btn5FinishOrder.Enabled = true;

                }
                else
                {
                    btn5FinishOrder.Enabled = false;
                }

            }
            /// <summary>
            /// load  beverage drink name from class into listbox 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
                private void btn3Beverages_Click(object sender, EventArgs e)
                {
                    this.BackgroundImage = CanteenFoodOrdering.Properties.Resources.beverages;
                    this.listBox1.Items.Clear();
                        foreach (BeverageDrink beverage in Beverage.Drink)
                        {
                            listBox1.Items.Add(beverage);
                        }
                }
      /// <summary>
                /// load  desert name from class into listbox 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
                private void btn4Desert_Click(object sender, EventArgs e)
                {
                    this.BackgroundImage = CanteenFoodOrdering.Properties.Resources.desert;
                    this.listBox1.Items.Clear();

                    foreach (DesertYum desert in Desert.Yum)
                    {
                        listBox1.Items.Add(desert);
                    }
                }
        /// <summary>
                ///  Remove items from list box  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            public void btn6RemoveItem_Click(object sender, EventArgs e)   
            {

                if (listBox2.SelectedItem is Product)
                {
                    RemoveProduct((Product)listBox2.SelectedItem);


                    if (listBox2.Items.Count >= 1)
                    {
                        btn5FinishOrder.Enabled = true;

                    }
                    else
                    {
                        btn5FinishOrder.Enabled = false;
                    }
                }
        }

    /// <summary>
    /// this calls the calprice method and sums up the price from in listbox2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
            private void btn5FinishOrder_Click(object sender, EventArgs e)
            {
            
               this.Hide();

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Invoice))
                    {
                        form.Visible = true;
                        return;
                    }
                }

             float total = CalcPrice();

                Invoice invoice = new Invoice(orderList, total);
                invoice.Show();
            }

        private void txtBx1Price_TextChanged(object sender, EventArgs e)
        {
            foreach (PizzaTopping topping in Pizza.Topping)
            {
            }
        }
    }
}

