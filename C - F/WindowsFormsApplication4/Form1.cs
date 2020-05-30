using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal Fa;
            decimal tempF = Convert.ToDecimal(textBox1.Text);
            Fa = ((tempF * 9 / 5) + 32);
            textBox3.Text = Convert.ToString(Fa);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal Ce;
            decimal tempC = Convert.ToDecimal(textBox3.Text);
            Ce = ((tempC - 32) * 5 / 9) ;
            textBox1.Text = Convert.ToString(Ce);
        }
    }
}
