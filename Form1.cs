using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortED
{
    public partial class SorterWindow : Form
    {
        public SorterWindow()
        {
            InitializeComponent();
        }

        private void navPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, navPanel.Width, navPanel.Height);
            int radius = 25;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
           navPanel.Region = new Region(path);

           
           
        }
    }
}
