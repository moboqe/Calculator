using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double a, b;
        string oper;
        bool f;
        public Form1()
        {
            InitializeComponent();

        }

        private void Buttonnum_click(object sender, EventArgs e)
        {
            if (!f) textBox1.Clear(); //поле ввода очищается перед вводом числа
            f = true; // признак ввода числа
                      //MessageBox.Show((sender as Button).Text);
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            // textBox1.Clear();      // второй способ
        }

        private void OFFbutton_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
        }

        private void ONbutton_click(object sender, EventArgs e)
        {
            button1.Enabled = !false;
            button2.Enabled = !false;
            button3.Enabled = !false;
            button4.Enabled = !false;
            button5.Enabled = !false;
            button6.Enabled = !false;
            button7.Enabled = !false;
            button8.Enabled = !false;
            button9.Enabled = !false;
            button10.Enabled = !false;
            button11.Enabled = !false;
            button12.Enabled = !false;
            button13.Enabled = !false;
            button14.Enabled = !false;
            button16.Enabled = !false;
            button17.Enabled = !false;
            button18.Enabled = !false;
            button19.Enabled = !false;
            button20.Enabled = !false;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(textBox1.Text);
            p = -p;
            textBox1.Text = Convert.ToString(p);
            /* if (textBox1.Text.StartsWith("-"))
            {
                //It negative now, so strip the '-' sign to make it positive
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(textBox1.Text) && decimal.Parse(textBox1.Text) != 0)
            {
                //It positive now, so prefix the value with the '-' sign to make it negative
                textBox1.Text = "-" + textBox1.Text;
            }*/
        }

        private void Rezbutton_click(object sender, EventArgs e)
        {
            if (f)  //определяем результата только после ввода числа
            {
                b = Convert.ToDouble(textBox1.Text); //сохраняем число во втором операнде
                switch (oper)
                {
                    case "+":
                        textBox1.Text = Convert.ToString(a + b);
                        break;
                    case "-":
                        textBox1.Text = Convert.ToString(a - b);
                        break;
                    case "*":
                        textBox1.Text = Convert.ToString(a * b);
                        break;
                    case "/":
                        if (b == 0) textBox1.Text = "error"; else textBox1.Text = Convert.ToString(a / b);
                        break;
                }
            }
            f = false;
        }

        private void OPbutton_click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            f = false;
            oper = (sender as Button).Text;
        }

        private int Zap()
        {
            int result = 0;
            for (byte i = 0; i < textBox1.Text.Length; i++)
                if (textBox1.Text[i] == ',') result++; //result возвращает кол-во запятых
            return (result);
        }

        private void BtnZap_click(object sender, EventArgs e)
        {
            if (Zap() < 1) // если кол-во запятых < 1
            {
                if (textBox1.Text != "") // если textbox не пустой
                    textBox1.Text = textBox1.Text + (sender as Button).Text; // вставить запятую
            }
        }
    }
}
