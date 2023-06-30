using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        List<int> list = new List<int>();
        int clicks = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Enabled = false;
            timer.Tick += new EventHandler(Show_Clicks);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clicks = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            timer.Interval = 20000; 
            timer.Start();
            timer.Enabled = true;
        }
        private void Show_Clicks(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Кол-во кликов: " + clicks + "");
            timer.Enabled = false;
            list.Add(clicks);
            button1.Enabled = true;
            button2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лучший результат: " + list.Max());
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (timer.Enabled) clicks++;
        }
    }
}