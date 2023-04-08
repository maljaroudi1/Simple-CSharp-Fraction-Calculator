using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Addition Radio button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        //Number 1 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        //Number 2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        //Number 3
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Number 4
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //Result Number 1
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //Result Number 2
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Divide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Multipication_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Minus_CheckedChanged(object sender, EventArgs e)
        {

        }


        //Perform operation button
        private void button1_Click(object sender, EventArgs e)
        {
            double first = 0;
            double first2 = 0;

            double second = 0;
            double second2 = 0;

            double result = 0;
            double result2 = 0;

            double hold1 = 0;
            double hold2 = 0;
            double hold3 = 0;

            double operation = 0;
          
         

            try
            {
                first = double.Parse(this.first.Text);
                first2 = double.Parse(this.first2.Text);

                second = double.Parse(this.second.Text);
                second2 = double.Parse(this.second2.Text);



                if (Addition.Checked)
                {
                    if (first2 != second2)
                    {
                        hold1 = first * second2;
                        hold2 = first2 * second2;
                        hold3 = second * first2;
                        operation = hold1 + hold3;
                        
                        result = operation;
                        result2 = hold2;

                    }
                    else
                    {
                        hold1 = first + second;

                        result = hold1;
                        result2 = second2;


                    }


                }
                if (Minus.Checked)
                {
                    if (first2 != second2)
                    {
                        hold1 = first * second2;
                        hold2 = second2 * first2;
                        hold3 = second * first2;
                        operation = hold1 - hold3;

                        result = operation;
                        result2 = hold2;
                    }
                    else
                    {
                        hold1 = first - second;

                        result = hold1;
                        result2 = second2;
                    }
                }
                if (Multipication.Checked)
                {
                    hold1 = first * second;
                    hold2 = first2 * second2;
                  

                    result = hold1;
                    result2 = hold2;

                }
                if (Divide.Checked)
                {
                    hold1 = first * second2;
                    hold2 = first2 * second;

                    result = hold1;
                    result2 = hold2;
                }





                txtResult.Text = result.ToString();
                txtResult2.Text = result2.ToString();
                txtResult.ReadOnly = true;
                txtResult2.ReadOnly = true;



            }
            catch (FormatException ex)
            { 
                MessageBox.Show(ex.Message);
                txtResult.Text = "NA";
                txtResult2.Text = "NA";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
                txtResult.Text = "DIV 0";
                txtResult2.Text = "DIV 0";
            }
        }
    }
}
