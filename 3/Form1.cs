using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        int teamScore1 = 0, teamScore2 = 0;
        Form2 form;
        public Form1()
        {
            InitializeComponent();
            label3.Text = teamScore1.ToString();
            label4.Text = teamScore2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teamScore2=form.AddTeam2(teamScore2);
            label4.Text = teamScore2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            teamScore1=form.AddTeam1(teamScore1);
            label3.Text = teamScore1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teamScore1=form.DecTeam1(teamScore1);
            label3.Text = teamScore1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            teamScore2=form.DecTeam2(teamScore2);
            label4.Text = teamScore2.ToString();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            form = new Form2(textBox1.Text,textBox2.Text,teamScore1,teamScore2);
            form.Show();
        }
    }
}
