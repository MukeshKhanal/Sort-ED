using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SortED
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string gitHubUrl = "https://github.com/Ishan-Dahal";

            
            System.Diagnostics.Process.Start(gitHubUrl);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string gitHubUrl = "https://github.com/MukeshKhanal";


            System.Diagnostics.Process.Start(gitHubUrl);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string gitHubUrl = "https://github.com/nbishwok";
            System.Diagnostics.Process.Start(gitHubUrl);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
