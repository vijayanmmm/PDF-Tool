namespace PDF_Tool
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPDFFolderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultImageFileFolder = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.numPictureQuality = new System.Windows.Forms.NumericUpDown();
            this.btnBrowsePDFFolder = new System.Windows.Forms.Button();
            this.btnBrowseResultImagesFolder = new System.Windows.Forms.Button();
            this.btnQRCodereading = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mf_btnBrowseFapiao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mf_txtFapiaoFolder = new System.Windows.Forms.TextBox();
            this.dgFapiao = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.mf_lblFapiaoTotalAmt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPictureQuality)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFapiao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF Files Folder:";
            // 
            // txtPDFFolderPath
            // 
            this.txtPDFFolderPath.Location = new System.Drawing.Point(142, 39);
            this.txtPDFFolderPath.Name = "txtPDFFolderPath";
            this.txtPDFFolderPath.Size = new System.Drawing.Size(345, 20);
            this.txtPDFFolderPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result Images File Folder:";
            // 
            // txtResultImageFileFolder
            // 
            this.txtResultImageFileFolder.Location = new System.Drawing.Point(142, 91);
            this.txtResultImageFileFolder.Name = "txtResultImageFileFolder";
            this.txtResultImageFileFolder.Size = new System.Drawing.Size(345, 20);
            this.txtResultImageFileFolder.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(229, 159);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(198, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert to Image Files";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(51, 132);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Picture Quality:";
            // 
            // numPictureQuality
            // 
            this.numPictureQuality.Location = new System.Drawing.Point(142, 132);
            this.numPictureQuality.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.numPictureQuality.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numPictureQuality.Name = "numPictureQuality";
            this.numPictureQuality.Size = new System.Drawing.Size(66, 20);
            this.numPictureQuality.TabIndex = 6;
            this.numPictureQuality.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // btnBrowsePDFFolder
            // 
            this.btnBrowsePDFFolder.Location = new System.Drawing.Point(494, 35);
            this.btnBrowsePDFFolder.Name = "btnBrowsePDFFolder";
            this.btnBrowsePDFFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePDFFolder.TabIndex = 7;
            this.btnBrowsePDFFolder.Text = "Browse";
            this.btnBrowsePDFFolder.UseVisualStyleBackColor = true;
            this.btnBrowsePDFFolder.Click += new System.EventHandler(this.btnBrowsePDFFolder_Click);
            // 
            // btnBrowseResultImagesFolder
            // 
            this.btnBrowseResultImagesFolder.Location = new System.Drawing.Point(493, 91);
            this.btnBrowseResultImagesFolder.Name = "btnBrowseResultImagesFolder";
            this.btnBrowseResultImagesFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseResultImagesFolder.TabIndex = 8;
            this.btnBrowseResultImagesFolder.Text = "Browse";
            this.btnBrowseResultImagesFolder.UseVisualStyleBackColor = true;
            this.btnBrowseResultImagesFolder.Click += new System.EventHandler(this.btnBrowseResultImagesFolder_Click);
            // 
            // btnQRCodereading
            // 
            this.btnQRCodereading.Location = new System.Drawing.Point(464, 145);
            this.btnQRCodereading.Name = "btnQRCodereading";
            this.btnQRCodereading.Size = new System.Drawing.Size(105, 64);
            this.btnQRCodereading.TabIndex = 9;
            this.btnQRCodereading.Text = "QR Code reading";
            this.btnQRCodereading.UseVisualStyleBackColor = true;
            this.btnQRCodereading.Click += new System.EventHandler(this.btnQRCodereading_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 328);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConvert);
            this.tabPage1.Controls.Add(this.btnQRCodereading);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBrowseResultImagesFolder);
            this.tabPage1.Controls.Add(this.txtPDFFolderPath);
            this.tabPage1.Controls.Add(this.btnBrowsePDFFolder);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numPictureQuality);
            this.tabPage1.Controls.Add(this.txtResultImageFileFolder);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Convert PDF to Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mf_lblFapiaoTotalAmt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgFapiao);
            this.tabPage2.Controls.Add(this.mf_btnBrowseFapiao);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.mf_txtFapiaoFolder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(609, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Fapiao";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mf_btnBrowseFapiao
            // 
            this.mf_btnBrowseFapiao.Location = new System.Drawing.Point(492, 6);
            this.mf_btnBrowseFapiao.Name = "mf_btnBrowseFapiao";
            this.mf_btnBrowseFapiao.Size = new System.Drawing.Size(75, 23);
            this.mf_btnBrowseFapiao.TabIndex = 11;
            this.mf_btnBrowseFapiao.Text = "Browse";
            this.mf_btnBrowseFapiao.UseVisualStyleBackColor = true;
            this.mf_btnBrowseFapiao.Click += new System.EventHandler(this.mf_btnBrowseFapiao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fapiao Folder(IMG/PDF):";
            // 
            // mf_txtFapiaoFolder
            // 
            this.mf_txtFapiaoFolder.Location = new System.Drawing.Point(141, 6);
            this.mf_txtFapiaoFolder.Name = "mf_txtFapiaoFolder";
            this.mf_txtFapiaoFolder.Size = new System.Drawing.Size(345, 20);
            this.mf_txtFapiaoFolder.TabIndex = 10;
            // 
            // dgFapiao
            // 
            this.dgFapiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFapiao.Location = new System.Drawing.Point(9, 64);
            this.dgFapiao.Name = "dgFapiao";
            this.dgFapiao.Size = new System.Drawing.Size(594, 232);
            this.dgFapiao.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fapiao Total:";
            // 
            // mf_lblFapiaoTotalAmt
            // 
            this.mf_lblFapiaoTotalAmt.AutoSize = true;
            this.mf_lblFapiaoTotalAmt.ForeColor = System.Drawing.Color.Maroon;
            this.mf_lblFapiaoTotalAmt.Location = new System.Drawing.Point(249, 33);
            this.mf_lblFapiaoTotalAmt.Name = "mf_lblFapiaoTotalAmt";
            this.mf_lblFapiaoTotalAmt.Size = new System.Drawing.Size(13, 13);
            this.mf_lblFapiaoTotalAmt.TabIndex = 14;
            this.mf_lblFapiaoTotalAmt.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 338);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(657, 277);
            this.Name = "Form1";
            this.Text = "PDF Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPictureQuality)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFapiao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPDFFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultImageFileFolder;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NumericUpDown numPictureQuality;
        private System.Windows.Forms.Button btnBrowsePDFFolder;
        private System.Windows.Forms.Button btnBrowseResultImagesFolder;
        private System.Windows.Forms.Button btnQRCodereading;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button mf_btnBrowseFapiao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mf_txtFapiaoFolder;
        private System.Windows.Forms.DataGridView dgFapiao;
        private System.Windows.Forms.Label mf_lblFapiaoTotalAmt;
        private System.Windows.Forms.Label label4;
    }
}

