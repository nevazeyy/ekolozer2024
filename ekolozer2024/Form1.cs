using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekolozer2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            panel1.Height = random.Next(150);
            panel2.Height = random.Next(150);
            panel3.Height = random.Next(150);
            panel4.Height = random.Next(150);
            panel5.Height = random.Next(150);
            panel6.Height = random.Next(150);
            panel7.Height = random.Next(150);
        }
    }
}
