using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        {
            try
            {
                double x = double.Parse(textBoxX.Text);
                double y = double.Parse(textBoxY.Text);

                // 1. Определяем выбранную функцию f(x)
                double fx = 0;

                if (radioButtonCos.Checked)
                    fx = Math.Cos(x);
                else if (radioButtonSqr.Checked)
                    fx = Math.Pow(x, 2);
                else if (radioButtonExp.Checked)
                    fx = Math.Exp(x);
                else
                {
                    MessageBox.Show("Выберите функцию f(x)");
                    return;
                }

                // 2. Вычисляем алгоритм
                double a;

                if (x * y > 0)                    // x/y > 0 → x и y одного знака
                {
                    a = Math.Log(y + 2) + fx;
                }
                else if (x * y < 0)               // x/y < 0 → разные знаки
                {
                    a = Math.Log(Math.Abs(y)) - Math.Tan(fx);
                }
                else                               // x/y == 0 → x == 0
                {
                    a = fx * Math.Pow(y, 3);
                }

                // 3. Вывод результата
                textBoxResult.Text =  a.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода. Проверьте X и Y.");
            }
        }
    }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                // Чтение данных из текстовых полей
                double x = double.Parse(textBoxX2.Text);
                double y = double.Parse(textBoxY2.Text);
                double z = double.Parse(textBoxZ2.Text);

                // Вычисление алгоритма
                double numerator = 2 * Math.Cos(x - Math.PI / 6);
                double denominator = 0.5 + Math.Pow(Math.Sin(y), 2);
                double part2 = 1 + (z * z) / (3 - (z * z) / 5);

                double t = (numerator / denominator) * part2;

                // Вывод результата
                textBoxResult2.Text = t.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка: проверьте правильность введённых чисел.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLiner_Click(object sender, EventArgs e)
        {
            panelLinear.Visible = true;
            panelBranching.Visible = false;
        }

        private void btnBranching_Click(object sender, EventArgs e)
        {
            panelLinear.Visible = false;
            panelBranching.Visible = true;
        }
    }
}
        
