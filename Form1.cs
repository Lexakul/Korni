using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            answerBox.Visible = false;
            goBackBox.Visible = false;
        }

        double a, b, c;
        double answer1, answer2;
        string finalAnswer;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-'))
                e.Handled = true;
            if ((enterAbox.Text.Length > 0) && (e.KeyChar == '-'))
                e.Handled = true;
            if (((enterAbox.Text == "-") || (enterAbox.Text == "")) && (e.KeyChar == '0'))
                e.Handled = true;
            if ((enterAbox.Text.Length > 5) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Tab))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            createEquation();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-'))
                e.Handled = true;
            if ((enterBbox.Text.Length > 0) && (e.KeyChar == '-'))
                e.Handled = true;
            if (((enterBbox.Text == "-") || (enterBbox.Text == "")) && (e.KeyChar == '0'))
                e.Handled = true;
            if ((enterBbox.Text.Length > 5) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Tab))
                e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            createEquation();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-'))
                e.Handled = true;
            if ((enterCbox.Text.Length > 0) && (e.KeyChar == '-'))
                e.Handled = true;
            if (((enterCbox.Text == "-") || (enterCbox.Text == "")) && (e.KeyChar == '0'))
                e.Handled = true;
            if ((enterCbox.Text.Length > 5) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Tab))
                e.Handled = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down))
                e.Handled = true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down))
                e.Handled = true;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down))
                e.Handled = true;
        }

        private void goBackBox_Click(object sender, EventArgs e)
        {
            backGround1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            equationBox.Visible = true;
            button1.Visible = true;
            enterAbox.Visible = true;
            enterBbox.Visible = true;
            enterCbox.Visible = true;

            answerBox.Visible = false;
            goBackBox.Visible = false;

            enterAbox.Text = "";
            enterBbox.Text = "";
            enterCbox.Text = "";
            answerBox.Text = "";
            createEquation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            finalAnswer = "";
            if (a == 0)
            {
                if (b != 0)
                {
                    answer1 = (c * (-1)) / b;
                    answer1 = Math.Round(answer1, 5);
                    finalAnswer = string.Concat("x1 = ", answer1);
                }
                else
                    finalAnswer = "корней нет";
            }
            else
            {
                double D = b * b - 4 * a * c;
                if (D == 0)
                {
                    answer1 = -1 * b / (2 * a);
                    answer1 = Math.Round(answer1, 5);
                    finalAnswer = string.Concat("x1 = ", answer1);
                }
                else
                {
                    if (D < 0)
                        finalAnswer = "корней нет";
                    else
                    {
                        answer1 = (-1 * b + Math.Sqrt(D)) / (2 * a);
                        answer1 = Math.Round(answer1, 5);
                        answer2 = (-1 * b - Math.Sqrt(D)) / (2 * a);
                        answer2 = Math.Round(answer2, 5);
                        finalAnswer = string.Concat("x1 = ", answer1, "\n", "x2 = ", answer2);
                    }
                }
            }

            backGround1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            equationBox.Visible = false;
            button1.Visible = false;
            enterAbox.Visible = false;
            enterBbox.Visible = false;
            enterCbox.Visible = false;

            answerBox.Visible = true;
            goBackBox.Visible = true;
            answerBox.Text = string.Concat(equationBox.Text, "\n", "\n", "Ответ: ", "\n", "\n", finalAnswer);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            createEquation();
        }

        private void createEquation()
        {
            if ((enterAbox.Text == "") || (enterAbox.Text == "-"))
                a = 0;
            else
                a = Convert.ToInt32(enterAbox.Text);

            if ((enterBbox.Text == "") || (enterBbox.Text == "-"))
                b = 0;
            else
                b = Convert.ToInt32(enterBbox.Text);

            if ((enterCbox.Text == "") || (enterCbox.Text == "-"))
                c = 0;
            else
                c = Convert.ToInt32(enterCbox.Text);

            string equation = "Уравнение:";
            if (a != 0)
            {
                if (a < 0)
                        equation = string.Concat(equation, " -");
                    else
                        equation = string.Concat(equation, " ");
                if ((a == -1) || (a == 1))
                    equation = string.Concat(equation, "x^2");
                else
                    equation = string.Concat(equation, Math.Abs(a), "x^2");
            }

            if (b != 0)
            {
                if (a != 0)
                {
                    if (b < 0)
                        equation = string.Concat(equation, " - ");
                    else
                        equation = string.Concat(equation, " + ");
                }
                else
                {
                    if (b < 0)
                        equation = string.Concat(equation, " -");
                }
                if ((b == -1) || (b == 1))
                    equation = string.Concat(equation, "x");
                else
                    equation = string.Concat(equation, Math.Abs(b), "x");
            }

            if (c != 0)
            {
                if ((a != 0) || (b != 0))
                {
                    if (c < 0)
                        equation = string.Concat(equation, " - ");
                    else
                        equation = string.Concat(equation, " + ");
                }
                else
                {
                    if (c < 0)
                        equation = string.Concat(equation, " -");
                }
                equation = string.Concat(equation, Math.Abs(c));
            }
            if ((a != 0) || (b != 0) || (c != 0))
                equation = string.Concat(equation, " = 0");
            equationBox.Text = equation;
            equationBox.Left = 181 - equationBox.Size.Width / 2;
        }


    }
}
