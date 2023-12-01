
namespace PROJECT_AKHIR
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanDataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanDataStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDataToolStripMenuItem,
            this.bookInformationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1357, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentDataToolStripMenuItem
            // 
            this.studentDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peminjamanToolStripMenuItem,
            this.pengembalianToolStripMenuItem});
            this.studentDataToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDataToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.studentDataToolStripMenuItem.Name = "studentDataToolStripMenuItem";
            this.studentDataToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.studentDataToolStripMenuItem.Text = "Student Data";
            this.studentDataToolStripMenuItem.Click += new System.EventHandler(this.studentDataToolStripMenuItem_Click);
            // 
            // peminjamanToolStripMenuItem
            // 
            this.peminjamanToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.peminjamanToolStripMenuItem.Name = "peminjamanToolStripMenuItem";
            this.peminjamanToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.peminjamanToolStripMenuItem.Text = "Peminjaman";
            this.peminjamanToolStripMenuItem.Click += new System.EventHandler(this.peminjamanToolStripMenuItem_Click);
            // 
            // pengembalianToolStripMenuItem
            // 
            this.pengembalianToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSalmon;
            this.pengembalianToolStripMenuItem.Name = "pengembalianToolStripMenuItem";
            this.pengembalianToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.pengembalianToolStripMenuItem.Text = "Pengembalian";
            this.pengembalianToolStripMenuItem.Click += new System.EventHandler(this.pengembalianToolStripMenuItem_Click);
            // 
            // bookInformationToolStripMenuItem
            // 
            this.bookInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.bookDataToolStripMenuItem,
            this.allReportToolStripMenuItem,
            this.notesToolStripMenuItem});
            this.bookInformationToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookInformationToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.bookInformationToolStripMenuItem.Name = "bookInformationToolStripMenuItem";
            this.bookInformationToolStripMenuItem.Size = new System.Drawing.Size(209, 29);
            this.bookInformationToolStripMenuItem.Text = "Book Information";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBukuToolStripMenuItem,
            this.peminjamanToolStripMenuItem1,
            this.pengembalianToolStripMenuItem1,
            this.staffToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.historyToolStripMenuItem.ForeColor = System.Drawing.Color.Salmon;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.historyToolStripMenuItem.Text = "Data View";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // dataBukuToolStripMenuItem
            // 
            this.dataBukuToolStripMenuItem.ForeColor = System.Drawing.Color.YellowGreen;
            this.dataBukuToolStripMenuItem.Name = "dataBukuToolStripMenuItem";
            this.dataBukuToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.dataBukuToolStripMenuItem.Text = "Data Buku";
            this.dataBukuToolStripMenuItem.Click += new System.EventHandler(this.dataBukuToolStripMenuItem_Click);
            // 
            // peminjamanToolStripMenuItem1
            // 
            this.peminjamanToolStripMenuItem1.ForeColor = System.Drawing.Color.ForestGreen;
            this.peminjamanToolStripMenuItem1.Name = "peminjamanToolStripMenuItem1";
            this.peminjamanToolStripMenuItem1.Size = new System.Drawing.Size(241, 30);
            this.peminjamanToolStripMenuItem1.Text = "Peminjaman";
            this.peminjamanToolStripMenuItem1.Click += new System.EventHandler(this.peminjamanToolStripMenuItem1_Click);
            // 
            // pengembalianToolStripMenuItem1
            // 
            this.pengembalianToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.pengembalianToolStripMenuItem1.Name = "pengembalianToolStripMenuItem1";
            this.pengembalianToolStripMenuItem1.Size = new System.Drawing.Size(241, 30);
            this.pengembalianToolStripMenuItem1.Text = "Pengembalian";
            this.pengembalianToolStripMenuItem1.Click += new System.EventHandler(this.pengembalianToolStripMenuItem1_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // bookDataToolStripMenuItem
            // 
            this.bookDataToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSalmon;
            this.bookDataToolStripMenuItem.Name = "bookDataToolStripMenuItem";
            this.bookDataToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.bookDataToolStripMenuItem.Text = "Book Data";
            this.bookDataToolStripMenuItem.Click += new System.EventHandler(this.bookDataToolStripMenuItem_Click);
            // 
            // allReportToolStripMenuItem
            // 
            this.allReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanDataBukuToolStripMenuItem,
            this.laporanDataStudentToolStripMenuItem});
            this.allReportToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.allReportToolStripMenuItem.Name = "allReportToolStripMenuItem";
            this.allReportToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.allReportToolStripMenuItem.Text = "Laporan";
            this.allReportToolStripMenuItem.Click += new System.EventHandler(this.allReportToolStripMenuItem_Click);
            // 
            // laporanDataBukuToolStripMenuItem
            // 
            this.laporanDataBukuToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.laporanDataBukuToolStripMenuItem.Name = "laporanDataBukuToolStripMenuItem";
            this.laporanDataBukuToolStripMenuItem.Size = new System.Drawing.Size(352, 30);
            this.laporanDataBukuToolStripMenuItem.Text = "Laporan Data Buku";
            this.laporanDataBukuToolStripMenuItem.Click += new System.EventHandler(this.laporanDataBukuToolStripMenuItem_Click);
            // 
            // laporanDataStudentToolStripMenuItem
            // 
            this.laporanDataStudentToolStripMenuItem.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.laporanDataStudentToolStripMenuItem.Name = "laporanDataStudentToolStripMenuItem";
            this.laporanDataStudentToolStripMenuItem.Size = new System.Drawing.Size(352, 30);
            this.laporanDataStudentToolStripMenuItem.Text = "Laporan Data Peminjam";
            this.laporanDataStudentToolStripMenuItem.Click += new System.EventHandler(this.laporanDataStudentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1357, 712);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pengembalianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanDataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanDataStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}