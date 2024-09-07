using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using static System.Convert;

namespace MoveEstimatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Var
            const int MRATE = 200, HRATE = 150, MIRATE = 2;
            double hour, mile, total;
            //Read
            mile = Convert.ToDouble(textBox1.Text);
            hour = Convert.ToDouble(textBox2.Text);
            //calculation
            total = MRATE + (hour * HRATE) + (mile * MIRATE);
            //Display
            label3.Visible = true;
            label3.Text = String.Format("For a move taking {0} hours and going {1} miles,\nthe total moving fee is {2}.", hour, mile, total.ToString("c"));
        }
    }
}
