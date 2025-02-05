namespace SortED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorterWindow));
            this.FileBrowser = new System.Windows.Forms.Panel();
            this.browse = new System.Windows.Forms.Button();
            this.Fileviewers = new System.Windows.Forms.Panel();
            this.view = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Uploaderpanel = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileBrowser.SuspendLayout();
            this.Fileviewers.SuspendLayout();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileBrowser
            // 
            this.FileBrowser.BackColor = System.Drawing.Color.White;
            this.FileBrowser.Controls.Add(this.label2);
            this.FileBrowser.Controls.Add(this.label1);
            this.FileBrowser.Controls.Add(this.browse);
            this.FileBrowser.Location = new System.Drawing.Point(168, 74);
            this.FileBrowser.Name = "FileBrowser";
            this.FileBrowser.Size = new System.Drawing.Size(722, 328);
            this.FileBrowser.TabIndex = 0;
            
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browse.FlatAppearance.BorderSize = 0;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.White;
            this.browse.Location = new System.Drawing.Point(252, 235);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(222, 52);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse Files";
            this.browse.UseVisualStyleBackColor = false;
            // 
            // Fileviewers
            // 
            this.Fileviewers.BackColor = System.Drawing.Color.White;
            this.Fileviewers.Controls.Add(this.view);
            this.Fileviewers.Controls.Add(this.Searchbtn);
            this.Fileviewers.Location = new System.Drawing.Point(925, 48);
            this.Fileviewers.Name = "Fileviewers";
            this.Fileviewers.Size = new System.Drawing.Size(279, 678);
            this.Fileviewers.TabIndex = 1;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(70, 601);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(147, 49);
            this.view.TabIndex = 4;
            this.view.Text = "View More";
            this.view.UseVisualStyleBackColor = false;
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.Gold;
            this.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchbtn.FlatAppearance.BorderSize = 0;
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(70, 152);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(158, 44);
            this.Searchbtn.TabIndex = 3;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            // 
            // Uploaderpanel
            // 
            this.Uploaderpanel.BackColor = System.Drawing.Color.White;
            this.Uploaderpanel.Location = new System.Drawing.Point(178, 463);
            this.Uploaderpanel.Name = "Uploaderpanel";
            this.Uploaderpanel.Size = new System.Drawing.Size(712, 275);
            this.Uploaderpanel.TabIndex = 1;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.White;
            this.navPanel.Controls.Add(this.pictureBox1);
            this.navPanel.Location = new System.Drawing.Point(12, 48);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(141, 609);
            this.navPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 84);
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
            this.sort.Location = new System.Drawing.Point(458, 408);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(152, 49);
            this.sort.TabIndex = 1;
            this.sort.Text = "Sort It";
            this.sort.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drag and Drop your files here ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(309, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Or:";
            // 
            // SorterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 765);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.Uploaderpanel);
            this.Controls.Add(this.Fileviewers);
            this.Controls.Add(this.FileBrowser);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SorterWindow";
            this.Text = "SortED";
            this.FileBrowser.ResumeLayout(false);
            this.FileBrowser.PerformLayout();
            this.Fileviewers.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FileBrowser;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Panel Fileviewers;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Panel Uploaderpanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

