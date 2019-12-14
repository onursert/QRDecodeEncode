using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QRDecodeEncode
{
    public partial class QRDecodeEncode : Form
    {
        public QRDecodeEncode()
        {
            InitializeComponent();
        }

        private void buttonImportQRDecode_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image|*.jpg; *.png; *.bmp; *.jpeg; *.PNG;";
            openFileDialog1.Title = "Import QR";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxQR.Image = Image.FromFile(openFileDialog1.FileName.ToString());
            }

            QRCodeDecoder decode = new QRCodeDecoder();
            richTextBoxQR.Text = decode.Decode(new QRCodeBitmapImage(pictureBoxQR.Image as Bitmap));
        }

        private void buttonExportQR_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image|*.jpg; *.png; *.bmp; *.jpeg; *.PNG;";
            saveFileDialog1.Title = "Export QR";
            saveFileDialog1.FileName = "Untitled QR";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int width = pictureBoxQR.Size.Width;
                int height = pictureBoxQR.Size.Height;

                Bitmap bmDecode = new Bitmap(width, height);
                pictureBoxQR.DrawToBitmap(bmDecode, new Rectangle(0, 0, width, height));

                bmDecode.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encode = new QRCodeEncoder();
            Bitmap bmEncode = encode.Encode(richTextBoxQR.Text);
            pictureBoxQR.Image = bmEncode as Image;
        }
    }
}