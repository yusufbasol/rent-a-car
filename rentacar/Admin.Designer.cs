namespace rentacar
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSözleşmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmeBelgesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.araçToolStripMenuItem,
            this.sözleşmeToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1452, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriTablosuToolStripMenuItem});
            this.müşteriToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // müşteriTablosuToolStripMenuItem
            // 
            this.müşteriTablosuToolStripMenuItem.Name = "müşteriTablosuToolStripMenuItem";
            this.müşteriTablosuToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.müşteriTablosuToolStripMenuItem.Text = "Müşteri Tablosu";
            this.müşteriTablosuToolStripMenuItem.Click += new System.EventHandler(this.müşteriTablosuToolStripMenuItem_Click);
            // 
            // araçToolStripMenuItem
            // 
            this.araçToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçTablosuToolStripMenuItem});
            this.araçToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araçToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.araçToolStripMenuItem.Name = "araçToolStripMenuItem";
            this.araçToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.araçToolStripMenuItem.Text = "Araç";
            // 
            // araçTablosuToolStripMenuItem
            // 
            this.araçTablosuToolStripMenuItem.Name = "araçTablosuToolStripMenuItem";
            this.araçTablosuToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.araçTablosuToolStripMenuItem.Text = "Araç Tablosu";
            this.araçTablosuToolStripMenuItem.Click += new System.EventHandler(this.araçTablosuToolStripMenuItem_Click);
            // 
            // sözleşmeToolStripMenuItem
            // 
            this.sözleşmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniSözleşmeToolStripMenuItem,
            this.sözleşmeBelgesiToolStripMenuItem});
            this.sözleşmeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sözleşmeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sözleşmeToolStripMenuItem.Name = "sözleşmeToolStripMenuItem";
            this.sözleşmeToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.sözleşmeToolStripMenuItem.Text = "Sözleşme";
            // 
            // yeniSözleşmeToolStripMenuItem
            // 
            this.yeniSözleşmeToolStripMenuItem.Name = "yeniSözleşmeToolStripMenuItem";
            this.yeniSözleşmeToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.yeniSözleşmeToolStripMenuItem.Text = "Yeni Sözleşme";
            this.yeniSözleşmeToolStripMenuItem.Click += new System.EventHandler(this.yeniSözleşmeToolStripMenuItem_Click);
            // 
            // sözleşmeBelgesiToolStripMenuItem
            // 
            this.sözleşmeBelgesiToolStripMenuItem.Name = "sözleşmeBelgesiToolStripMenuItem";
            this.sözleşmeBelgesiToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.sözleşmeBelgesiToolStripMenuItem.Click += new System.EventHandler(this.sözleşmeBelgesiToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yardımToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.yardımToolStripMenuItem.Text = "Hakkında";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(404, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 93);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rent A Car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1273, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1273, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent A Car ";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem müşteriTablosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçTablosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSözleşmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeBelgesiToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

