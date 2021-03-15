using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPiEP_laba21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorDialog1.Color = this.BackColor;
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            this.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            if (comboBox1.SelectedIndex == -1)
            {
                button3.BackColor = colorDialog1.Color;
                button4.BackColor = colorDialog1.Color;
                button5.BackColor = colorDialog1.Color;
                button6.BackColor = colorDialog1.Color;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    button3.BackColor = colorDialog1.Color;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        button4.BackColor = colorDialog1.Color;
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 2)
                        {
                            button5.BackColor = colorDialog1.Color;
                        }
                        else
                        {
                            if (comboBox1.SelectedIndex == 3)
                            {
                                button6.BackColor = colorDialog1.Color;
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowMes(sender);
        }

        private static void ShowMes(object sender)
        {
            Button but = sender as Button;
            if (but.BackColor == Color.Yellow)
            {
                MessageBox.Show("Warning", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else if (but.BackColor == Color.Red)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else if (but.BackColor == Color.Blue)
            {
                MessageBox.Show("Question", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (but.BackColor == Color.Green)
            {
                MessageBox.Show("Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowMes(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowMes(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowMes(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;

            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            checkBox5.CheckState = CheckState.Unchecked;

            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Show();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Show();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.CheckState == CheckState.Checked)
                MessageBox.Show("Поздравляшки");
        }
    }
}
