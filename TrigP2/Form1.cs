using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrigP2
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
            double sin(double x)
            {
                return (Math.Sin(x * Math.PI / 180.0));
            }

            double asin(double x)
            {
                return (Math.Asin(x) * 180 / Math.PI);
            }

            double cos(double x)
            {
                return (Math.Cos(x * Math.PI / 180.0));
            }

            double acos(double x)
            {
                return (Math.Acos(x) * 180 / Math.PI);
            }

            double tan(double x)
            {
                return (Math.Tan(x * Math.PI / 180.0));
            }

            double atan(double x)
            {
                return (Math.Atan(x) * 180 / Math.PI);
            }


        

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double Force = double.Parse(textBox1.Text);
            double Angle = double.Parse(textBox3.Text);
            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);
            label3.Text = "Fx = " + Fx.ToString("0.000");
            label4.Text = "Fy = " + Fy.ToString("0.000");
            try
            {
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox3.Text);
      
            }
        
            catch
            {
                MessageBox.Show(Force + " is not a correct input");
                MessageBox.Show(Angle + " is not a a correct input");
                MessageBox.Show(Fx + " is not a correct input");
                MessageBox.Show(Fy + " is not a correct input");
            }
            
            
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
