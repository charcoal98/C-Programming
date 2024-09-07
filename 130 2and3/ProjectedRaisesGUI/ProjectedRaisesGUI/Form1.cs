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

namespace ProjectedRaisesGUI
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
            const double RAISE = .04;
            double salary = ToDouble(textBox1.Text);
            double nSalary = salary + (salary * RAISE);
            //Display
            label2.Visible = true;
            label2.Text = String.Format("Salary increases by 4%, from ${0} to ${1}", salary, nSalary);

        }
    }
}
