﻿using System;
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
using System.Reflection;


namespace SortED
{
    public partial class SorterWindow : Form
    {
        private List<string> selectedFiles = new List<string>();
        private Sorter sortManager = new Sorter();
        private DestMgmer DestMgmer=new DestMgmer();
        

        public SorterWindow()
        {
            InitializeComponent();
            fileUploaded.DrawMode = DrawMode.OwnerDrawFixed;
            fileUploaded.DrawItem += new DrawItemEventHandler(fileUploaded_DrawItem);

            ApplyRoundedCorners(navPanel, 20);
            ApplyRoundedCorners(browse, 20);
            ApplyRoundedCorners(sort, 20);
            ApplyRoundedCorners(view, 20);
            ApplyRoundedCorners(Searchbtn, 20);
            ApplyRoundedCorners(Uploaderpanel, 20);
            ApplyRoundedCorners(Fileviewers, 20);


        }

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
        private void fileUploaded_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            
            FileItem item = (FileItem)fileUploaded.Items[e.Index];

            
            e.DrawBackground();

            
            e.Graphics.DrawIcon(item.FileIcon, e.Bounds.Left, e.Bounds.Top);

            
            Rectangle textBounds = new Rectangle(e.Bounds.Left + item.FileIcon.Width + 5, e.Bounds.Top, e.Bounds.Width - item.FileIcon.Width - 5, e.Bounds.Height);

            e.Graphics.DrawString(item.FileName, e.Font, Brushes.Black, textBounds);

            e.DrawFocusRectangle();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select files to sort";
            ofd.InitialDirectory = @"C:\Desktop";  
            ofd.Multiselect = true;  

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in ofd.FileNames)  
                {
                    string FileGoodName = Path.GetFileName(filePath.Trim());  

                    Icon iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(filePath);


                    selectedFiles.Add(filePath);  
                    fileUploaded.Items.Add(new FileItem { FileName = FileGoodName, FileIcon = iconForFile }); 
                }
            }
        }


        private void FileBrowser_DragDrop(object sender, DragEventArgs e)
        {
            Array filenames;
            Icon iconForFile;

            
            if (e.Data != null)
            {
                filenames = (Array)e.Data.GetData(DataFormats.FileDrop);

                foreach (string i in filenames)
                {
                    string FileGoodName = Path.GetFileName(i.Trim());
                    selectedFiles.Add(FileGoodName);
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(i);


                    fileUploaded.Items.Add(FileGoodName);

                    fileUploaded.Items[fileUploaded.Items.Count - 1] = new FileItem { FileName = FileGoodName, FileIcon = iconForFile };
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
                    fileUploaded.Items.Add(FileGoodName);  
                }
            }
        }

        private void FileBrowser_DragLeave(object sender, EventArgs e)
        {
            FileBrowser.BackColor = Color.White;
            label1.ForeColor = Color.RoyalBlue;
            label2.ForeColor = Color.RoyalBlue;
        }

        private void sort_Click(object sender, EventArgs e)
        {
            if (selectedFiles.Count == 0)
            {
                MessageBox.Show("No files to sort");
                return;
            }
            string destpath = DestMgmer.GetDestination();
            if (string.IsNullOrEmpty(destpath)) return;

            sortManager.SortFiles(selectedFiles,destpath);
            fileUploaded.Items.Clear();
            selectedFiles.Clear();
            using (loadingwindow loading = new loadingwindow())
            {
                loading.ShowDialog();
                MessageBox.Show("Sucefully Sorted");
                loading.Close();


            }

            

        }

      

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            
            using (AboutUs about = new AboutUs())
            {
                about.ShowDialog();


            }
        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            using (Help help = new Help())
            {
                help.ShowDialog();


            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            using (ViewMore history= new ViewMore())
            {
                history.ShowDialog();
            }
        }
    }

    public class Sorter
    {
        public void SortFiles(List<string> files, string destinationPath)
        {
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }
            foreach (var file in files)
            {
                if (!FileHandler.IsValidFile(file)) continue;

                string extension = Path.GetExtension(file).TrimStart('.').ToUpper();
                string folderDestination = Path.Combine(destinationPath, extension);


                if (!Directory.Exists(folderDestination))
                {
                    Directory.CreateDirectory(folderDestination);
                }
                string newDest = Path.Combine(folderDestination, Path.GetFileName(file));

                int filecount = 1;

                while (File.Exists(newDest))
                {
                    newDest = Path.Combine(folderDestination + Path.GetFileNameWithoutExtension(file)+ filecount + Path.GetFileName(file));

                }

                File.Move(file, newDest);

            }


        }
    }
    public class DestMgmer
    {
        public string GetDestination()
        {
            DialogResult rst = MessageBox.Show("Sort it in Default location? ", " Choose Destination",
                MessageBoxButtons.YesNoCancel);
            if (rst == DialogResult.Yes)
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SortED");
            }
            else if(rst == DialogResult.No)
            {
                using (FolderBrowserDialog broswer = new FolderBrowserDialog())
                {
                    if (broswer.ShowDialog() == DialogResult.OK)
                    {
                        return broswer.SelectedPath;
                    };
                }
            }
            return null;



        }
    }
    public static class FileHandler
    {
        public static bool IsValidFile(string filePath)
        {
            return File.Exists(filePath);
        }
    }
    public class FileItem
    {
        public string FileName { get; set; }
        public Icon FileIcon { get; set; }
    }


    public class DatabaseHelper
    {


    }
}



