using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AtticusPlayGameProject
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

        private void button1_Click(object sender, EventArgs e)
        
        {
            outputLabel.Text = "Game will start in: 5";
            Refresh();
            Thread.Sleep(1000);
            outputLabel.Text = "Game will start in: 4";
            Refresh();
            Thread.Sleep(1000);
            outputLabel.Text = "Game will start in: 3";
            Refresh();
            Thread.Sleep(1000);
            outputLabel.Text = "Game will start in: 2";
            Refresh();
            Thread.Sleep(1000);
            outputLabel.Text = "Game will start in: 1";
            Refresh();
            Thread.Sleep(1000);
            outputLabel.Text = "Go!";
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkOrange;
            Refresh();
            Thread.Sleep(100);
            BackColor = Color.DarkRed;
            outputLabel.Text = "You Win! Good Job!";
            BackColor = Color.Black;
        } 

        private void label2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
