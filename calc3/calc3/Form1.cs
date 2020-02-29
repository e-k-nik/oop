using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button10_Click(object sender, EventArgs e) //кнопка цифры
        {
            if ((textBox1.Text.StartsWith("0")) && !(textBox1.Text.StartsWith("0,")))
            { //0 и 0, 
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }


            textBox1.Text += (sender as Button).Text;  // к текстбоксу добавляется текст нажатой кнопки. 
        }

        double a = 0, b = 0, c = 0;
        char znak = '+';

        private void Button11_Click(object sender, EventArgs e) // Запятая
        {
            if (textBox1.Text.Contains(","))
            {

            }
            else textBox1.Text += (sender as Button).Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) // 
        {

        }

        private void Button18_Click(object sender, EventArgs e) //Удаление
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "0");

        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e) // закрытие программы 
        {
            this.Close();
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e) //справка!
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }


       int n = 0;

        private void Button16_Click(object sender, EventArgs e) //кнопка знака 
        {

            
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            label1.Text = znak.ToString() ; 
            textBox1.Clear();
            
        }
       

        private void Button12_Click(object sender, EventArgs e) //кнопка ответа 
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+':
                    c = a + b;
                    break;

                case '-':
                    c = a - b;
                    break;

                case '*':
                    c = a * b;
                    break;

                case '/':
                    if (b == 0)
                    {
                        MessageBox.Show("Ошибка! На ноль делить нельзя!");
                    }
                    else c = a / b;    
                    break;

                case '%':
                    c = a % b;
                    break;
            }
            textBox1.Text = c.ToString();
        }
    }
}

