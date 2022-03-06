namespace oop_qrCode
{
    partial class qr
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qr));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.camera = new System.Windows.Forms.PictureBox();
            this.scan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camera)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.camera, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.scan, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // camera
            // 
            this.camera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.camera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera.Location = new System.Drawing.Point(3, 3);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(578, 385);
            this.camera.TabIndex = 0;
            this.camera.TabStop = false;
            // 
            // scan
            // 
            this.scan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scan.Location = new System.Drawing.Point(3, 394);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(578, 64);
            this.scan.TabIndex = 1;
            this.scan.Text = "Scan";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // qr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "qr";
            this.Text = "QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.qr_FormClosing);
            this.Load += new System.EventHandler(this.qr_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox camera;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.Timer timer1;
    }
}
