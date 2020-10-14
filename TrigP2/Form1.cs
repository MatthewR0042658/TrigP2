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
            double sin(double x) //Working out for Sin
            {
                return (Math.Sin(x * Math.PI / 180.0));
            }

            double asin(double x) //Working out for sin^-1
            {
                return (Math.Asin(x) * 180 / Math.PI);
            }

            double cos(double x) //Working out for Cos
            {
                return (Math.Cos(x * Math.PI / 180.0));
            }

            double acos(double x) //Working out for cos^-1
            {
                return (Math.Acos(x) * 180 / Math.PI);
            }

            double tan(double x) //Working out for tan
            {
                return (Math.Tan(x * Math.PI / 180.0));
            }

            double atan(double x) //Working out for tan^-1
            {
                return (Math.Atan(x) * 180 / Math.PI);
            }


        

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e) //This is the button so all code here is activated when the equals button is pressed.
        {
            try //Checks over the inputs to ensure that they are all capable of working with the code
            { 
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox3.Text);
                double Fx = Force * cos(Angle);
                double Fy = Force * sin(Angle);
                label3.Text = "Fx = " + Fx.ToString("0.000");
                label4.Text = "Fy = " + Fy.ToString("0.000");
            
            }
        
            catch //If not then this section of code outputs an error message for the user.
            {
                MessageBox.Show("Error on input");
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
