using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Boxes_3._2
{
    public partial class pizzaShopForm : Form
    {
        private double large, medium, small, topping, amount;

        public pizzaShopForm()
        {
            InitializeComponent();
            large = 11;
            medium = 8;
            small = 5;
            topping = 2.50;
        }

        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This adds 2.5 onto the total cost if 
        /// the topping is selected, and minuses
        /// 2.5 if deselected.
        /// </summary>
        private void toppingOneSelected(object sender, EventArgs e)
        {
            if (toppingOneCheckBox.Checked)
            {
                amount += topping;
                costLabel.Text = "£" + amount.ToString();
            }
            else
            {
                amount -= topping;
                costLabel.Text = "£" + amount.ToString();
            }
        }

        /// <summary>
        /// This adds 2.5 onto the total cost if 
        /// the topping is selected, and minuses
        /// 2.5 if deselected.
        /// </summary>
        private void toppingTwoSelected(object sender, EventArgs e)
        {
            if (toppingTwoCheckBox.Checked)
            {
                amount += topping;
                costLabel.Text = "£" + amount.ToString();
            }
            else
            {
                amount -= topping;
                costLabel.Text = "£" + amount.ToString();
            }
        }

        /// <summary>
        /// This adds 2.5 onto the total cost if 
        /// the topping is selected, and minuses
        /// 2.5 if deselected.
        /// </summary>
        private void toppingThreeSelected(object sender, EventArgs e)
        {
            if (toppingThreeCheckBox.Checked)
            {
                amount += topping;
                costLabel.Text = "£" + amount.ToString();
            }
            else
            {
                amount -= topping;
                costLabel.Text = "£" + amount.ToString();
            }
        }
        
        /// <summary>
        /// This adds 2.5 onto the total cost if 
        /// the topping is selected, and minuses
        /// 2.5 if deselected.
        /// </summary>
        private void toppingFourSelected(object sender, EventArgs e)
        {
            if (toppingFourCheckBox.Checked)
            {
                amount += topping;
                costLabel.Text = "£" + amount.ToString();
            }
            else
            {
                amount -= topping;
                costLabel.Text = "£" + amount.ToString();
            }
        }

        private void largeSelection(object sender, EventArgs e)
        {
            amount = 0;
            amount += large;
            costLabel.Text = "£" + amount.ToString();
        }
        
        private void mediumSelection(object sender, EventArgs e)
        {
            amount = 0;
            amount += medium;
            costLabel.Text = "£" + amount.ToString();
        }
        
        private void smallSelection(object sender, EventArgs e)
        {
            amount = 0;
            amount += small;
            costLabel.Text = "£" + amount.ToString();
        }
    }
}
