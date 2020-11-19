using System;
using System.Windows.Forms;

namespace Hastighed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string fromVal = cBox1.Text;
            string toVal = cBox2.Text;
            int value;
            value = Convert.ToInt32(textBox1.Text);
            float n = 3.6f;
            float answer;


            if (fromVal =="Km/t" && toVal == "M/s")
            {
                answer = value / n;
             
                label1.Text = answer + " M/s";
            }
            if (fromVal == "M/s" && toVal == "Km/t")
            {
                answer = value * n;

                label1.Text = answer + " Km/t";
            }
        }
    }
}
