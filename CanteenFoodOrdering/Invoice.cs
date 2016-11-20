using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
 using System.Collections;
using System.Drawing.Printing;
using System.Diagnostics;

namespace CanteenFoodOrdering
{
    /// <summary>
    /// Class invoice displays items to show in listbox as customers copy of inovice 
    /// </summary>
    public partial class Invoice : Form
    {
        private List<Product> products;
        List<object> invoice = new List<object>();
        private float total;
       /// <summary>
       /// this adds items into produccts so i can call the list instead of each item individually 
       /// </summary>
       /// <param name="products"></param>
       /// <param name="total"></param>
        public Invoice(List<Product> products, float total)
        {
            this.products = products;
            InitializeComponent();

            this.total = total;

            //list 2 passing into invoice 
            this.invoice.Add("--Central Canteen Order Invoice--");
            this.invoice.Add("");
            foreach (Product product in products)
            {
                invoice.Add(product);
            }
        }
        int Array_Length = 0;
        /// <summary>
        /// 
        /// </summary>
        public void DisplayOBject()
        {
            listBox1.Items.Clear();
            foreach (object c in invoice)
            {

                DeliveryInfo calculate = c as DeliveryInfo;
                if (calculate != null)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Name:" + calculate.nam);
                    listBox1.Items.Add("Address:" + calculate.add);
                    listBox1.Items.Add("Mobile No:" + calculate.mobNo);
                    listBox1.Items.Add("");
                    Array_Length++;
                }
                else
                {
                    listBox1.Items.Add(c);
                }
            }
        }
        /// <summary>
        /// This button adds details of customer delivery then adds all details from order into invoice 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn2_Click(object sender, EventArgs e)
        {       // validate mobile number 
            Regex regex = new Regex(@"^\(\d{3}\) ?\d{3}( |-)?\d{4}|^\d{3}( |-)?\d{3}( |-)?\d{4}", RegexOptions.Singleline); //http://regexlib.com/REDetails.aspx?regexp_id=979

            if (regex.IsMatch(this.txtBx3.Text))
                {
                    btn2.Enabled = false;
                    this.btn1PrintInvoice.Enabled = true;
                    DeliveryInfo calculate = new DeliveryInfo(1, this.txtBx1.Text, this.txtBx2.Text, this.txtBx3.Text);
                
                    this.invoice.Add(calculate);

                    float total = this.total;

                    if (this.checkBox1.Checked)
                        {
                    
                            this.invoice.Add("Your Delivery Fee is :$10.0");
                            total += 10.0f;
                        }

                    this.invoice.Add(string.Format("Total Price: {0:C}", total));
                    this.invoice.Add(DateTime.Now.ToLongDateString());
                    this.invoice.Add("");
                    this.invoice.Add("Thanks, Have a Great Day and Enjoy your Meal");
                    this.DisplayOBject();
                }
                else
                {

                    MessageBox.Show("Incorrect phone number, please try again in the format 012-345-6789");
                }

        }


        private void btn1Printinvoice_Click(object sender, EventArgs e)
        {
            this.SaveToInvoice();
            MessageBox.Show("Your invoice is saved to @C:\\Users\\041502928\\Documents");
          }
        /// <summary>
        /// This calculate price of items 
        /// </summary>
        /// <returns></returns>
        public float CalcTotal()
        {
            float total = 0.0f;

            foreach (Product product in this.products)
            {
                total += product.Price;
            }

            return total;
        }
        /// <summary>
        /// This saves incoice to desktop  into a text file 
        /// </summary>
        public void SaveToInvoice()
        {
            FileStream file = null;
            try
            {

                string documents = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MoniquesCanteenApplication");

                if (!Directory.Exists(documents))
                {
                    Directory.CreateDirectory(documents);
                }

                file = new FileStream(documents + @"/invoice.txt", FileMode.Create);
                using (StreamWriter writer = new StreamWriter(file))
                {

                    writer.WriteLine("--Central Canteen Order Invoice--");
                    writer.WriteLine("");

                    foreach (object obj in this.listBox1.Items)
                    {
                        if (obj is Product)
                        {
                            Product product = obj as Product;

                            writer.WriteLine(product);
                        }

                    }

                    total = CalcTotal();

                    if (this.checkBox1.Checked)
                    {

                        writer.WriteLine("Your Delivery Fee is :$10.0");
                        total += 10.0f;
                    }

                    writer.WriteLine(string.Format("Total Price: {0:C}", total));
                    writer.WriteLine(DateTime.Now.ToLongDateString());
                    writer.WriteLine("");
                    writer.WriteLine("Thanks, Have a Great Day and Enjoy your Meal");
                    writer.Flush();
                }
            }
            finally
            {
                file.Close();
            }
        }
    }
}



