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
            metroProgressBar1.Minimum = 0;
            metroProgressBar1.Maximum = 100;
            metroProgressBar1.Value = 0;
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroProgressBar1.Value < metroProgressBar1.Maximum)
            {
                metroProgressBar1.Value += 2; // Adjust speed
                metroProgressBar1.ForeColor = ColorTranslator.FromHtml("#5e16ea");
            }
            else
            {
                timer1.Stop();
                Form Form1  = new SorterWindow();
                Form1.Show();
                this.Hide(); // Hide startup form
            }
            
        }
    }
}
