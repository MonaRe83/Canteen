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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// If a user logins then will go into menu page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1StartOrder_Click(object sender, EventArgs e) //  Starts order 
        {
            this.Hide();

            // Takes you into menu form 
            foreach(Form form in Application.OpenForms)
            {
                if(form.GetType() == typeof(MenuForm))
                {
                    form.Visible = true;
                    return;
                }
            }
            MenuForm Menu = new MenuForm();
            Menu.Show();
        }

      
    }
}
