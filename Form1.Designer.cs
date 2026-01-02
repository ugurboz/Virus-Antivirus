namespace Virus_Antivirus
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSimulator = new System.Windows.Forms.TabPage();
            this.grpSimulator = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVirusStatus = new System.Windows.Forms.Label();
            this.btnCreateRandom = new System.Windows.Forms.Button();
            this.btnCreateVirus = new System.Windows.Forms.Button();
            this.tabScanner = new System.Windows.Forms.TabPage();
            this.grpScanner = new System.Windows.Forms.GroupBox();
            this.lblScanStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstInfected = new System.Windows.Forms.ListBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtScanPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabSimulator.SuspendLayout();
            this.grpSimulator.SuspendLayout();
            this.tabScanner.SuspendLayout();
            this.grpScanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimulator);
            this.tabControl1.Controls.Add(this.tabScanner);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 461);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabSimulator
            // 
            this.tabSimulator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabSimulator.Controls.Add(this.grpSimulator);
            this.tabSimulator.Location = new System.Drawing.Point(4, 34);
            this.tabSimulator.Name = "tabSimulator";
            this.tabSimulator.Padding = new System.Windows.Forms.Padding(10);
            this.tabSimulator.Size = new System.Drawing.Size(776, 423);
            this.tabSimulator.TabIndex = 0;
            this.tabSimulator.Text = "☣️ Virus Lab";
            // 
            // grpSimulator
            // 
            this.grpSimulator.Controls.Add(this.label2);
            this.grpSimulator.Controls.Add(this.lblVirusStatus);
            this.grpSimulator.Controls.Add(this.btnCreateRandom);
            this.grpSimulator.Controls.Add(this.btnCreateVirus);
            this.grpSimulator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSimulator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSimulator.ForeColor = System.Drawing.Color.LimeGreen;
            this.grpSimulator.Location = new System.Drawing.Point(10, 10);
            this.grpSimulator.Name = "grpSimulator";
            this.grpSimulator.Size = new System.Drawing.Size(756, 403);
            this.grpSimulator.TabIndex = 0;
            this.grpSimulator.TabStop = false;
            this.grpSimulator.Text = "Malware Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(30, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "TARGET: ~/Desktop/VirusTest (Sandbox Environment)";
            // 
            // lblVirusStatus
            // 
            this.lblVirusStatus.AutoSize = true;
            this.lblVirusStatus.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblVirusStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblVirusStatus.Location = new System.Drawing.Point(30, 200);
            this.lblVirusStatus.Name = "lblVirusStatus";
            this.lblVirusStatus.Size = new System.Drawing.Size(168, 18);
            this.lblVirusStatus.TabIndex = 2;
            this.lblVirusStatus.Text = "> System Ready_     ";
            // 
            // btnCreateRandom
            // 
            this.btnCreateRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCreateRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRandom.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCreateRandom.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCreateRandom.Location = new System.Drawing.Point(33, 110);
            this.btnCreateRandom.Name = "btnCreateRandom";
            this.btnCreateRandom.Size = new System.Drawing.Size(280, 50);
            this.btnCreateRandom.TabIndex = 1;
            this.btnCreateRandom.Text = "💀 Generate Random Swarm";
            this.btnCreateRandom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateRandom.UseVisualStyleBackColor = false;
            this.btnCreateRandom.Click += new System.EventHandler(this.btnCreateRandom_Click);
            // 
            // btnCreateVirus
            // 
            this.btnCreateVirus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCreateVirus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateVirus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCreateVirus.ForeColor = System.Drawing.Color.Crimson;
            this.btnCreateVirus.Location = new System.Drawing.Point(33, 45);
            this.btnCreateVirus.Name = "btnCreateVirus";
            this.btnCreateVirus.Size = new System.Drawing.Size(280, 50);
            this.btnCreateVirus.TabIndex = 0;
            this.btnCreateVirus.Text = "🦠 Create Single Test Virus";
            this.btnCreateVirus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateVirus.UseVisualStyleBackColor = false;
            this.btnCreateVirus.Click += new System.EventHandler(this.btnCreateVirus_Click);
            // 
            // tabScanner
            // 
            this.tabScanner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabScanner.Controls.Add(this.grpScanner);
            this.tabScanner.Location = new System.Drawing.Point(4, 34);
            this.tabScanner.Name = "tabScanner";
            this.tabScanner.Padding = new System.Windows.Forms.Padding(10);
            this.tabScanner.Size = new System.Drawing.Size(776, 423);
            this.tabScanner.TabIndex = 1;
            this.tabScanner.Text = "🛡️ Security Center";
            // 
            // grpScanner
            // 
            this.grpScanner.Controls.Add(this.lblScanStatus);
            this.grpScanner.Controls.Add(this.progressBar1);
            this.grpScanner.Controls.Add(this.btnDelete);
            this.grpScanner.Controls.Add(this.lstInfected);
            this.grpScanner.Controls.Add(this.btnScan);
            this.grpScanner.Controls.Add(this.btnBrowse);
            this.grpScanner.Controls.Add(this.txtScanPath);
            this.grpScanner.Controls.Add(this.label1);
            this.grpScanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpScanner.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpScanner.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grpScanner.Location = new System.Drawing.Point(10, 10);
            this.grpScanner.Name = "grpScanner";
            this.grpScanner.Size = new System.Drawing.Size(756, 403);
            this.grpScanner.TabIndex = 0;
            this.grpScanner.TabStop = false;
            this.grpScanner.Text = "System Protection";
            // 
            // lblScanStatus
            // 
            this.lblScanStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScanStatus.AutoSize = true;
            this.lblScanStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblScanStatus.Location = new System.Drawing.Point(20, 365);
            this.lblScanStatus.Name = "lblScanStatus";
            this.lblScanStatus.Size = new System.Drawing.Size(89, 15);
            this.lblScanStatus.TabIndex = 7;
            this.lblScanStatus.Text = "Status: Waiting";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(20, 335);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(715, 20);
            this.progressBar1.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Location = new System.Drawing.Point(555, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "🗑️ Clean Selected";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstInfected
            // 
            this.lstInfected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInfected.BackColor = System.Drawing.Color.White;
            this.lstInfected.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstInfected.ForeColor = System.Drawing.Color.DarkRed;
            this.lstInfected.FormattingEnabled = true;
            this.lstInfected.ItemHeight = 15;
            this.lstInfected.Location = new System.Drawing.Point(20, 90);
            this.lstInfected.Name = "lstInfected";
            this.lstInfected.Size = new System.Drawing.Size(715, 184);
            this.lstInfected.TabIndex = 4;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(615, 40);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(120, 32);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "🛡️ Start Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.Color.LightGray;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(565, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(40, 32);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "📂";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtScanPath
            // 
            this.txtScanPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScanPath.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtScanPath.Location = new System.Drawing.Point(20, 42);
            this.txtScanPath.Name = "txtScanPath";
            this.txtScanPath.Size = new System.Drawing.Size(535, 27);
            this.txtScanPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Directory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virus | Antivirus Suite 2026";
            this.tabControl1.ResumeLayout(false);
            this.tabSimulator.ResumeLayout(false);
            this.grpSimulator.ResumeLayout(false);
            this.grpSimulator.PerformLayout();
            this.tabScanner.ResumeLayout(false);
            this.grpScanner.ResumeLayout(false);
            this.grpScanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSimulator;
        private System.Windows.Forms.TabPage tabScanner;
        private System.Windows.Forms.GroupBox grpSimulator;
        private System.Windows.Forms.GroupBox grpScanner;
        private System.Windows.Forms.Button btnCreateRandom;
        private System.Windows.Forms.Button btnCreateVirus;
        private System.Windows.Forms.Label lblVirusStatus;
        private System.Windows.Forms.TextBox txtScanPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lstInfected;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblScanStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
    }
}
