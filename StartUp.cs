using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortED
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 2; //We might need to change speed

            }
            else
            {
                timer1.Stop();
                Form Form1 = new SorterWindow();
                Form1.Show();
                this.Hide();
            }
        }
        }


}
