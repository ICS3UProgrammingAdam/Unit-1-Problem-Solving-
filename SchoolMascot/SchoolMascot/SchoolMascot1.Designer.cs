namespace SchoolMascot
{
    partial class SchoolMascot1
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
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblMascott = new System.Windows.Forms.Label();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStPatrick = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLisgar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGlebe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgram.SuspendLayout();
            this.grbSchool.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(800, 24);
            this.mnuProgram.TabIndex = 0;
            this.mnuProgram.Text = "School Mascot";
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblMascott);
            this.grbSchool.Controls.Add(this.lblSchool);
            this.grbSchool.Location = new System.Drawing.Point(183, 136);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(399, 199);
            this.grbSchool.TabIndex = 1;
            this.grbSchool.TabStop = false;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(83, 45);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(131, 25);
            this.lblSchool.TabIndex = 2;
            this.lblSchool.Text = "Immaculata";
            // 
            // lblMascott
            // 
            this.lblMascott.AutoSize = true;
            this.lblMascott.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascott.Location = new System.Drawing.Point(84, 101);
            this.lblMascott.Name = "lblMascott";
            this.lblMascott.Size = new System.Drawing.Size(60, 20);
            this.lblMascott.TabIndex = 3;
            this.lblMascott.Text = "Saints";
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniStPatrick,
            this.mniLisgar,
            this.mniGlebe});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(180, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.MniImmaculata_Click);
            // 
            // mniStPatrick
            // 
            this.mniStPatrick.Name = "mniStPatrick";
            this.mniStPatrick.Size = new System.Drawing.Size(180, 22);
            this.mniStPatrick.Text = "St Patrick";
            this.mniStPatrick.Click += new System.EventHandler(this.MniStPatrick_Click);
            // 
            // mniLisgar
            // 
            this.mniLisgar.Name = "mniLisgar";
            this.mniLisgar.Size = new System.Drawing.Size(180, 22);
            this.mniLisgar.Text = "Lisgar";
            this.mniLisgar.Click += new System.EventHandler(this.MniLisgar_Click);
            // 
            // mniGlebe
            // 
            this.mniGlebe.Name = "mniGlebe";
            this.mniGlebe.Size = new System.Drawing.Size(180, 22);
            this.mniGlebe.Text = "Glebe";
            this.mniGlebe.Click += new System.EventHandler(this.MniGlebe_Click);
            // 
            // SchoolMascot1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuProgram);
            this.MainMenuStrip = this.mnuProgram;
            this.Name = "SchoolMascot1";
            this.Text = "School Mascot by Adam";
            this.Load += new System.EventHandler(this.SchoolMascot1_Load);
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.GroupBox grbSchool;
        private System.Windows.Forms.Label lblMascott;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.ToolStripMenuItem mniStPatrick;
        private System.Windows.Forms.ToolStripMenuItem mniLisgar;
        private System.Windows.Forms.ToolStripMenuItem mniGlebe;
    }
}

