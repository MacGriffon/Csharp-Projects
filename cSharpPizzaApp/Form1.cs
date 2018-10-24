using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpPizzaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tmrDateTimeSource.Tick += new EventHandler(tmrDateTimeSource_Tick);
            tmrDateTimeSource.Interval = 1000;
            tmrDateTimeSource.Enabled = true;
            tmrDateTimeSource.Start();
        }

        private void tmrDateTimeSource_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mtxPhoneEntry.Clear();
            mtxZipCodeEntry.Clear();
            txtAddressEntry1.Clear();
            txtAddressEntry2.Clear();
            txtCityEntry.Clear();
            txtNameEntry.Clear();
            cboStateEntry.ResetText();
            radLarge.Checked = false;
            radMedium.Checked = true;
            radSmall.Checked = false;
            nudQuantity.Value = 1;
            chkBacon.Checked = false;
            chkChicken.Checked = false;
            chkHamburger.Checked = false;
            chkPepperoni.Checked = false;
            chkSalami.Checked = false;
            chkSausage.Checked = false;
            chkTurkey.Checked = false;
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            int smallPizza = 5;
            int mediumPizza = 8;
            int largePizza = 10;
            int pizzaAmount = 0;
            int pizzaCount = Convert.ToInt16(nudQuantity.Value);
            int toppingsCounter = 0;
            double topping = 0.50;
            double taxRate = 0.07;
            double total = 0;
            double tax = 0;
            double totalWithTax = 0;

            foreach (CheckBox c in grpPizzaToppings.Controls)
            {
                if (c.Checked == true)
                    toppingsCounter += 1;
            }

            if (radSmall.Checked == true) { pizzaAmount = smallPizza; }
            if (radMedium.Checked == true) { pizzaAmount = mediumPizza; }
            if (radLarge.Checked == true) { pizzaAmount = largePizza; }

            total = pizzaCount * (pizzaAmount + (topping * toppingsCounter));
            tax = total * taxRate;
            totalWithTax = total + tax;

            lblSubtotalAmount.Text = total.ToString("C");
            lblTaxAmount.Text = tax.ToString("C");
            lblTotalAmount.Text = totalWithTax.ToString("C");
        }

    }
}
