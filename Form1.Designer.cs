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
            ((System.ComponentModel.ISupportInitialize)(this.numPictureQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF Files Folder:";
            // 
            // txtPDFFolderPath
            // 
            this.txtPDFFolderPath.Location = new System.Drawing.Point(177, 56);
            this.txtPDFFolderPath.Name = "txtPDFFolderPath";
            this.txtPDFFolderPath.Size = new System.Drawing.Size(345, 20);
            this.txtPDFFolderPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result Images File Folder:";
            // 
            // txtResultImageFileFolder
            // 
            this.txtResultImageFileFolder.Location = new System.Drawing.Point(177, 108);
            this.txtResultImageFileFolder.Name = "txtResultImageFileFolder";
            this.txtResultImageFileFolder.Size = new System.Drawing.Size(345, 20);
            this.txtResultImageFileFolder.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(264, 176);
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
            this.linkLabel1.Location = new System.Drawing.Point(86, 149);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Picture Quality:";
            // 
            // numPictureQuality
            // 
            this.numPictureQuality.Location = new System.Drawing.Point(177, 149);
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
            this.btnBrowsePDFFolder.Location = new System.Drawing.Point(529, 52);
            this.btnBrowsePDFFolder.Name = "btnBrowsePDFFolder";
            this.btnBrowsePDFFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePDFFolder.TabIndex = 7;
            this.btnBrowsePDFFolder.Text = "Browse";
            this.btnBrowsePDFFolder.UseVisualStyleBackColor = true;
            this.btnBrowsePDFFolder.Click += new System.EventHandler(this.btnBrowsePDFFolder_Click);
            // 
            // btnBrowseResultImagesFolder
            // 
            this.btnBrowseResultImagesFolder.Location = new System.Drawing.Point(528, 108);
            this.btnBrowseResultImagesFolder.Name = "btnBrowseResultImagesFolder";
            this.btnBrowseResultImagesFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseResultImagesFolder.TabIndex = 8;
            this.btnBrowseResultImagesFolder.Text = "Browse";
            this.btnBrowseResultImagesFolder.UseVisualStyleBackColor = true;
            this.btnBrowseResultImagesFolder.Click += new System.EventHandler(this.btnBrowseResultImagesFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 238);
            this.Controls.Add(this.btnBrowseResultImagesFolder);
            this.Controls.Add(this.btnBrowsePDFFolder);
            this.Controls.Add(this.numPictureQuality);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtResultImageFileFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPDFFolderPath);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(657, 277);
            this.MinimumSize = new System.Drawing.Size(657, 277);
            this.Name = "Form1";
            this.Text = "PDF Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPictureQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

