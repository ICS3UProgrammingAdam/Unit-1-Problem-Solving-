namespace MovingCatAdam
{
    partial class frmMovingCat
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
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBikes = new System.Windows.Forms.ToolStripMenuItem();
            this.mniR1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mni1000rr = new System.Windows.Forms.ToolStripMenuItem();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.picBikes = new System.Windows.Forms.PictureBox();
            this.mnuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBikes)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCat,
            this.mnuBikes});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(800, 24);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(37, 20);
            this.mniCat.Text = "Cat";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(101, 22);
            this.mniCat1.Text = "Cat 1";
            this.mniCat1.Click += new System.EventHandler(this.MniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(101, 22);
            this.mniCat2.Text = "Cat 2";
            this.mniCat2.Click += new System.EventHandler(this.MniCat2_Click);
            // 
            // mnuBikes
            // 
            this.mnuBikes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniR1,
            this.mni1000rr});
            this.mnuBikes.Name = "mnuBikes";
            this.mnuBikes.Size = new System.Drawing.Size(46, 20);
            this.mnuBikes.Text = "Bikes";
            this.mnuBikes.Click += new System.EventHandler(this.MnuBikes_Click);
            // 
            // mniR1
            // 
            this.mniR1.Name = "mniR1";
            this.mniR1.Size = new System.Drawing.Size(180, 22);
            this.mniR1.Text = "Yamaha R1";
            this.mniR1.Click += new System.EventHandler(this.MniR1_Click);
            // 
            // mni1000rr
            // 
            this.mni1000rr.Name = "mni1000rr";
            this.mni1000rr.Size = new System.Drawing.Size(180, 22);
            this.mni1000rr.Text = "Honda CBR100rr";
            this.mni1000rr.Click += new System.EventHandler(this.Mni1000rr_Click);
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingCatAdam.Properties.Resources.cat1;
            this.picCat.Location = new System.Drawing.Point(42, 149);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(206, 245);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat.TabIndex = 1;
            this.picCat.TabStop = false;
            // 
            // picBikes
            // 
            this.picBikes.Image = global::MovingCatAdam.Properties.Resources.yamaha_r1;
            this.picBikes.Location = new System.Drawing.Point(400, 140);
            this.picBikes.Name = "picBikes";
            this.picBikes.Size = new System.Drawing.Size(320, 234);
            this.picBikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBikes.TabIndex = 2;
            this.picBikes.TabStop = false;
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBikes);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat by Adam";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBikes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.ToolStripMenuItem mnuBikes;
        private System.Windows.Forms.ToolStripMenuItem mniR1;
        private System.Windows.Forms.ToolStripMenuItem mni1000rr;
        private System.Windows.Forms.PictureBox picBikes;
    }
}

