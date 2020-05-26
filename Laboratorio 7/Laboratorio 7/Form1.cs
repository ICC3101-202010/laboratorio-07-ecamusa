using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7
{
   
    public partial class Resulttext : Form
    {
        List<string> lista = new List<string>();
        Double result1 = 0;
        String operation = "";
        String z = "";
        bool op = false;
        public Resulttext()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (op)
                textresult.Clear();
            if (textresult.Text == "0")
                textresult.Clear();

            op = false;
            textresult.Text = textresult.Text + "7";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (op)
                textresult.Clear();
            if (textresult.Text == "0")
                textresult.Clear();
            op = false;
            textresult.Text = textresult.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (op)
                textresult.Clear();
            if (textresult.Text == "0")
                textresult.Clear();
            op = false;
            textresult.Text = textresult.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (op)
                textresult.Clear();
            if (textresult.Text == "0")
                textresult.Clear();
            op = false;
            textresult.Text = textresult.Text + "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {   if (op)
                textresult.Clear();
            if (textresult.Text == "0")
                textresult.Clear();
            op = false;
            textresult.Text = textresult.Text + "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (op)
                textresult.Clear();
            if (textresult.Text == "0")
                textresult.Clear();
            op = false;
            textresult.Text = textresult.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (op)
                textresult.Clear();
            if (textresult.Text == "0")
                textresult.Clear();
            op = false;
            textresult.Text = textresult.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (op)
                textresult.Clear();
            if (textresult.Text == "0")
                textresult.Clear();
            op = false;
            textresult.Text = textresult.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (op)
                textresult.Clear();
            if (textresult.Text == "0")
                textresult.Clear();
            op = false;
            textresult.Text = textresult.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (op)
                textresult.Clear();
            if (textresult.Text == "0")
                textresult.Clear();
            op = false;
            textresult.Text = textresult.Text + "9";
        }

        private void button_click(object sender, EventArgs e)
        {
            textresult.Text = z;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result1 = Double.Parse(textresult.Text);
            op = true;
            label1.Text = result1.ToString() + " " + operation;
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textresult.Text = "0";
            result1 = 0;
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            textresult.Text = textresult.Text.Remove(textresult.Text.Length-1);
            if (textresult.Text == "")
            {
                textresult.Text = "0";
            }
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            switch (operation) 
            {
                case "+":
                    textresult.Text = (result1 + Double.Parse(textresult.Text)).ToString();
                    z = textresult.Text;
                    lista.Add(z);
                    break;
                case "-":
                    textresult.Text = (result1 - Double.Parse(textresult.Text)).ToString();
                    z = textresult.Text;
                    lista.Add(z);
                    break;
                case "X":
                    textresult.Text= (result1 * Double.Parse(textresult.Text)).ToString();
                    z = textresult.Text;
                    lista.Add(z);
                    break;
                case "/":
                    if (textresult.Text == "0")
                    {
                        textresult.Text = "Math Error";
                    }
                    else
                    {
                        if (textresult.Text == "")
                        {
                            textresult.Text = "Syntax Error";
                        }
                        else
                        {
                            textresult.Text = (result1 / Double.Parse(textresult.Text)).ToString();
                            z = textresult.Text;
                            lista.Add(z);
                        }
                       
                    }
                    break;

            }

        }

        private void buttonpoint_Click(object sender, EventArgs e)
        {
            if (op)
                textresult.Clear();
            
            op = false;
            Button button = (Button)sender;
            if (button.Text==",")
            {
                if (!textresult.Text.Contains(","))
                {
                    textresult.Text = textresult.Text + button.Text;
                }
            }
            else
            {
                textresult.Text = textresult.Text + button.Text;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textresult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
