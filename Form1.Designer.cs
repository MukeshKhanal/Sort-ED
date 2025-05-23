﻿namespace SortED
{
    partial class SorterWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorterWindow));
            this.FileBrowser = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.Fileviewers = new System.Windows.Forms.Panel();
            this.sorted = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.Uploaderpanel = new System.Windows.Forms.Panel();
            this.fileUploaded = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.navPanel = new System.Windows.Forms.Panel();
            this.aboutbtn = new System.Windows.Forms.PictureBox();
            this.helpbtn = new System.Windows.Forms.PictureBox();
            this.homebtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sort = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.hometip = new System.Windows.Forms.ToolTip(this.components);
            this.tiphelp = new System.Windows.Forms.ToolTip(this.components);
            this.abouttip = new System.Windows.Forms.ToolTip(this.components);
            this.FileBrowser.SuspendLayout();
            this.Fileviewers.SuspendLayout();
            this.Uploaderpanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileBrowser
            // 
            this.FileBrowser.AllowDrop = true;
            this.FileBrowser.BackColor = System.Drawing.Color.White;
            this.FileBrowser.Controls.Add(this.label2);
            this.FileBrowser.Controls.Add(this.label1);
            this.FileBrowser.Controls.Add(this.browse);
            this.FileBrowser.Location = new System.Drawing.Point(134, 74);
            this.FileBrowser.Name = "FileBrowser";
            this.FileBrowser.Size = new System.Drawing.Size(1030, 289);
            this.FileBrowser.TabIndex = 0;
            this.FileBrowser.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileBrowser_DragDrop);
            this.FileBrowser.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileBrowser_DragEnter);
            this.FileBrowser.DragLeave += new System.EventHandler(this.FileBrowser_DragLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(450, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Or:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(220, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drag and Drop your files here ";
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse.FlatAppearance.BorderSize = 0;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.White;
            this.browse.Location = new System.Drawing.Point(390, 194);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(222, 52);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse Files";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // Fileviewers
            // 
            this.Fileviewers.BackColor = System.Drawing.Color.White;
            this.Fileviewers.Controls.Add(this.sorted);
            this.Fileviewers.Controls.Add(this.view);
            this.Fileviewers.Location = new System.Drawing.Point(943, 487);
            this.Fileviewers.Name = "Fileviewers";
            this.Fileviewers.Size = new System.Drawing.Size(268, 175);
            this.Fileviewers.TabIndex = 1;
            // 
            // sorted
            // 
            this.sorted.AutoSize = true;
            this.sorted.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorted.ForeColor = System.Drawing.Color.DarkBlue;
            this.sorted.Location = new System.Drawing.Point(34, 31);
            this.sorted.Name = "sorted";
            this.sorted.Size = new System.Drawing.Size(175, 31);
            this.sorted.TabIndex = 6;
            this.sorted.Text = "Recently Sorted";
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(62, 89);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(147, 49);
            this.view.TabIndex = 4;
            this.view.Text = "View More";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // Uploaderpanel
            // 
            this.Uploaderpanel.BackColor = System.Drawing.Color.White;
            this.Uploaderpanel.Controls.Add(this.fileUploaded);
            this.Uploaderpanel.Controls.Add(this.label3);
            this.Uploaderpanel.Location = new System.Drawing.Point(134, 454);
            this.Uploaderpanel.Name = "Uploaderpanel";
            this.Uploaderpanel.Size = new System.Drawing.Size(787, 303);
            this.Uploaderpanel.TabIndex = 1;
            // 
            // fileUploaded
            // 
            this.fileUploaded.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileUploaded.FormattingEnabled = true;
            this.fileUploaded.ItemHeight = 28;
            this.fileUploaded.Location = new System.Drawing.Point(148, 54);
            this.fileUploaded.Name = "fileUploaded";
            this.fileUploaded.Size = new System.Drawing.Size(587, 200);
            this.fileUploaded.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(357, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uploaded Files:";
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.White;
            this.navPanel.Controls.Add(this.aboutbtn);
            this.navPanel.Controls.Add(this.helpbtn);
            this.navPanel.Controls.Add(this.homebtn);
            this.navPanel.Controls.Add(this.pictureBox1);
            this.navPanel.Location = new System.Drawing.Point(12, 74);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(86, 476);
            this.navPanel.TabIndex = 2;
            // 
            // aboutbtn
            // 
            this.aboutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutbtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutbtn.Image")));
            this.aboutbtn.Location = new System.Drawing.Point(9, 391);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(69, 63);
            this.aboutbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutbtn.TabIndex = 3;
            this.aboutbtn.TabStop = false;
            this.abouttip.SetToolTip(this.aboutbtn, "About Us");
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // helpbtn
            // 
            this.helpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpbtn.Image = ((System.Drawing.Image)(resources.GetObject("helpbtn.Image")));
            this.helpbtn.Location = new System.Drawing.Point(9, 265);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(66, 63);
            this.helpbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.helpbtn.TabIndex = 2;
            this.helpbtn.TabStop = false;
            this.tiphelp.SetToolTip(this.helpbtn, "Help");
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebtn.Image = ((System.Drawing.Image)(resources.GetObject("homebtn.Image")));
            this.homebtn.Location = new System.Drawing.Point(9, 143);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(69, 63);
            this.homebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homebtn.TabIndex = 1;
            this.homebtn.TabStop = false;
            this.hometip.SetToolTip(this.homebtn, "Home");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sort
            // 
            this.sort.BackColor = System.Drawing.Color.SteelBlue;
            this.sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sort.FlatAppearance.BorderSize = 0;
            this.sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.ForeColor = System.Drawing.Color.White;
            this.sort.Location = new System.Drawing.Point(571, 379);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(152, 49);
            this.sort.TabIndex = 1;
            this.sort.Text = "Sort It";
            this.sort.UseVisualStyleBackColor = false;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // SorterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::SortED.Properties.Resources.bckg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1223, 786);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.Uploaderpanel);
            this.Controls.Add(this.Fileviewers);
            this.Controls.Add(this.FileBrowser);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SorterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SortED";
            this.FileBrowser.ResumeLayout(false);
            this.FileBrowser.PerformLayout();
            this.Fileviewers.ResumeLayout(false);
            this.Fileviewers.PerformLayout();
            this.Uploaderpanel.ResumeLayout(false);
            this.Uploaderpanel.PerformLayout();
            this.navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aboutbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FileBrowser;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Panel Fileviewers;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Panel Uploaderpanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sorted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox fileUploaded;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.PictureBox aboutbtn;
        private System.Windows.Forms.PictureBox helpbtn;
        private System.Windows.Forms.PictureBox homebtn;
        private System.Windows.Forms.ToolTip hometip;
        private System.Windows.Forms.ToolTip abouttip;
        private System.Windows.Forms.ToolTip tiphelp;
    }
}

