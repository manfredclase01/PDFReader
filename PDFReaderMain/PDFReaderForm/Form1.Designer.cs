﻿namespace PDFReaderForm
{
    partial class PDFReaderForm
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
            this.ofdImportFile = new System.Windows.Forms.OpenFileDialog();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.nudStartPage = new System.Windows.Forms.NumericUpDown();
            this.lblStartSplit = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.nudEndPage = new System.Windows.Forms.NumericUpDown();
            this.btnSplit = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblNewFileName = new System.Windows.Forms.Label();
            this.txtSplitFileName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPage)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdImportFile
            // 
            this.ofdImportFile.FileName = "openFileDialog1";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(15, 51);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(15, 25);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(262, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // nudStartPage
            // 
            this.nudStartPage.Location = new System.Drawing.Point(15, 146);
            this.nudStartPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStartPage.Name = "nudStartPage";
            this.nudStartPage.Size = new System.Drawing.Size(120, 20);
            this.nudStartPage.TabIndex = 2;
            this.nudStartPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStartSplit
            // 
            this.lblStartSplit.AutoSize = true;
            this.lblStartSplit.Location = new System.Drawing.Point(12, 130);
            this.lblStartSplit.Name = "lblStartSplit";
            this.lblStartSplit.Size = new System.Drawing.Size(80, 13);
            this.lblStartSplit.TabIndex = 3;
            this.lblStartSplit.Text = "Start split page:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(141, 130);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(77, 13);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "End split page:";
            // 
            // nudEndPage
            // 
            this.nudEndPage.Location = new System.Drawing.Point(144, 146);
            this.nudEndPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEndPage.Name = "nudEndPage";
            this.nudEndPage.Size = new System.Drawing.Size(120, 20);
            this.nudEndPage.TabIndex = 4;
            this.nudEndPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSplit
            // 
            this.btnSplit.Enabled = false;
            this.btnSplit.Location = new System.Drawing.Point(15, 184);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 6;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(12, 9);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(48, 13);
            this.lblFilePath.TabIndex = 7;
            this.lblFilePath.Text = "File URL";
            // 
            // lblNewFileName
            // 
            this.lblNewFileName.AutoSize = true;
            this.lblNewFileName.Location = new System.Drawing.Point(12, 87);
            this.lblNewFileName.Name = "lblNewFileName";
            this.lblNewFileName.Size = new System.Drawing.Size(101, 13);
            this.lblNewFileName.TabIndex = 8;
            this.lblNewFileName.Text = "New PDF file name:";
            // 
            // txtSplitFileName
            // 
            this.txtSplitFileName.Enabled = false;
            this.txtSplitFileName.Location = new System.Drawing.Point(15, 104);
            this.txtSplitFileName.Name = "txtSplitFileName";
            this.txtSplitFileName.Size = new System.Drawing.Size(262, 20);
            this.txtSplitFileName.TabIndex = 9;
            // 
            // PDFReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 224);
            this.Controls.Add(this.txtSplitFileName);
            this.Controls.Add(this.lblNewFileName);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.nudEndPage);
            this.Controls.Add(this.lblStartSplit);
            this.Controls.Add(this.nudStartPage);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnImport);
            this.Name = "PDFReaderForm";
            this.Text = "PDF Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdImportFile;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.NumericUpDown nudStartPage;
        private System.Windows.Forms.Label lblStartSplit;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.NumericUpDown nudEndPage;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblNewFileName;
        private System.Windows.Forms.TextBox txtSplitFileName;
    }
}

