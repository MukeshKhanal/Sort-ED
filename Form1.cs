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
            ApplyRoundedCorners(navPanel, 25);
            ApplyRoundedCorners(browse, 45);
            ApplyRoundedCorners(sort, 45);
            ApplyRoundedCorners(view, 45);
            ApplyRoundedCorners(Searchbtn, 45);
            ApplyRoundedCorners(Uploaderpanel, 25);
            ApplyRoundedCorners(Fileviewers, 25);
            ApplyRoundedCorners(FileBrowser, 25);

        }

        //this is the custom method which will be used to round corner in any controls in the given form
        private void ApplyRoundedCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            
            Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); // Top-right
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90); // Bottom-left
            path.CloseFigure();

            control.Region = new Region(path);
        }

       
    }
}
