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
    public partial class Form2 : Form
    {
        private string text1;
        private string text2;


        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string text1, string text2 , int score1,int score2)
        {
            InitializeComponent();
            this.text1 = text1;
            this.text2 = text2;
            label3.Text = text1;
            label4.Text = text2;
            label1.Text = score1.ToString();
            label2.Text = score2.ToString();
        }

        public int AddTeam1(int a)
        {
            a++;
            label1.Text = a.ToString();
            return a;
        }

        public int DecTeam1(int a)
        {
            a--;
            label1.Text = a.ToString();
            return a;
        }

        public int AddTeam2(int a)
        {
            a++;
            label2.Text = a.ToString();
            return a;
        }

        public int DecTeam2(int a)
        {
            a--;
            label2.Text = a.ToString();
            return a;
        }
    }
}
