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
using System.IO;

namespace SortED
{
    public partial class SorterWindow : Form
    {
        public SorterWindow()
        {
            InitializeComponent();
 
            ApplyRoundedCorners(navPanel, 20);
            ApplyRoundedCorners(browse, 20);
            ApplyRoundedCorners(sort, 20);
            ApplyRoundedCorners(view, 20);
            ApplyRoundedCorners(Searchbtn, 20);
            ApplyRoundedCorners(Uploaderpanel, 20);
            ApplyRoundedCorners(Fileviewers, 20);
    
           


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

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select files to sort";
            ofd.InitialDirectory = @"C:\";
            ofd.ShowDialog();
            string FileGoodName = Path.GetFileName(ofd.FileName.Trim());
            if (ofd.FileName != "")
            {
                fileUploaded.Items.Add(FileGoodName);
            }
        }

        private void FileBrowser_DragDrop(object sender, DragEventArgs e)
        {
            Array filenames;
            if (e.Data != null)
            {
                filenames = (Array)e.Data.GetData(DataFormats.FileDrop);
                foreach (string i in filenames)
                {
                    string FileGoodName = Path.GetFileName(i.Trim());
                    fileUploaded.Items.Add(FileGoodName);
                }
            }

        }

        private void FileBrowser_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in filenames)
                {
                    string FileGoodName = Path.GetFileName(file.Trim());
                    fileUploaded.Items.Add(FileGoodName);  // Adds each file as a separate item
                }
            }
        }

        private void FileBrowser_DragLeave(object sender, EventArgs e)
        {
            FileBrowser.BackColor = Color.White;
            label1.ForeColor = Color.RoyalBlue;
            label2.ForeColor = Color.RoyalBlue;
        }
    }
}
