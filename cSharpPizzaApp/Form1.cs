using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
