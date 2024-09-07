using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;

namespace ExtraAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Var and Calc
            const double cups = 1.5/48;
            int cookies = ToInt32(textBox1.Text);
            double sugar = cookies * cups;
            //Display
            label2.Visible = true;
            label2.Text = String.Format("For {0} cookies you will need {1} cups of sugar.", cookies, sugar.ToString("f2"));
        }
    }
}
