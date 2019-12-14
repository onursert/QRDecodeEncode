namespace QRDecodeEncode
{
    partial class QRDecodeEncode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.richTextBoxQR = new System.Windows.Forms.RichTextBox();
            this.buttonImportQRDecode = new System.Windows.Forms.Button();
            this.buttonExportQR = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxQR);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QR";
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQR.TabIndex = 0;
            this.pictureBoxQR.TabStop = false;
            // 
            // richTextBoxQR
            // 
            this.richTextBoxQR.Location = new System.Drawing.Point(274, 12);
            this.richTextBoxQR.Name = "richTextBoxQR";
            this.richTextBoxQR.Size = new System.Drawing.Size(262, 275);
            this.richTextBoxQR.TabIndex = 1;
            this.richTextBoxQR.Text = "";
            // 
            // buttonImportQRDecode
            // 
            this.buttonImportQRDecode.Location = new System.Drawing.Point(12, 293);
            this.buttonImportQRDecode.Name = "buttonImportQRDecode";
            this.buttonImportQRDecode.Size = new System.Drawing.Size(120, 23);
            this.buttonImportQRDecode.TabIndex = 2;
            this.buttonImportQRDecode.Text = "Import QR / Decode";
            this.buttonImportQRDecode.UseVisualStyleBackColor = true;
            this.buttonImportQRDecode.Click += new System.EventHandler(this.buttonImportQRDecode_Click);
            // 
            // buttonExportQR
            // 
            this.buttonExportQR.Location = new System.Drawing.Point(12, 322);
            this.buttonExportQR.Name = "buttonExportQR";
            this.buttonExportQR.Size = new System.Drawing.Size(120, 23);
            this.buttonExportQR.TabIndex = 3;
            this.buttonExportQR.Text = "Export QR";
            this.buttonExportQR.UseVisualStyleBackColor = true;
            this.buttonExportQR.Click += new System.EventHandler(this.buttonExportQR_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(280, 293);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(120, 23);
            this.buttonEncode.TabIndex = 4;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "github.com/onursert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonExportQR);
            this.Controls.Add(this.buttonImportQRDecode);
            this.Controls.Add(this.richTextBoxQR);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QR Decode Encode";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.RichTextBox richTextBoxQR;
        private System.Windows.Forms.Button buttonImportQRDecode;
        private System.Windows.Forms.Button buttonExportQR;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Label label1;
    }
}

