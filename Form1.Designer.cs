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
            this.panel1 = new System.Windows.Forms.Panel();
            this.browse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.view = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sort = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.browse);
            this.panel1.Location = new System.Drawing.Point(168, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 328);
            this.panel1.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(255, 220);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(166, 45);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse Files";
            this.browse.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.view);
            this.panel2.Controls.Add(this.Searchbtn);
            this.panel2.Location = new System.Drawing.Point(925, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 661);
            this.panel2.TabIndex = 1;
            // 
            // view
            // 
            this.view.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(88, 600);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(147, 49);
            this.view.TabIndex = 4;
            this.view.Text = "View More";
            this.view.UseVisualStyleBackColor = true;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(59, 93);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(158, 44);
            this.Searchbtn.TabIndex = 3;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(168, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 290);
            this.panel3.TabIndex = 1;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.White;
            this.navPanel.Controls.Add(this.pictureBox1);
            this.navPanel.Location = new System.Drawing.Point(12, 34);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(141, 609);
            this.navPanel.TabIndex = 2;
            this.navPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navPanel_Paint);
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
            this.sort.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.Location = new System.Drawing.Point(452, 408);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(109, 49);
            this.sort.TabIndex = 1;
            this.sort.Text = "Sort It";
            this.sort.UseVisualStyleBackColor = true;
            // 
            // SorterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 765);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SorterWindow";
            this.Text = "SortED";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

