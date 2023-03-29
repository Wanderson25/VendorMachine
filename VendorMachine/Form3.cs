﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace VendorMachine
{
    public partial class QRcodeForm : Form
    {
        public QRcodeForm()
        {
            InitializeComponent();
            GenerateQRcode("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void GenerateQRcode(string text)
        {
            // Create QR code writer
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 300,
                    Width = 300,
                    Margin = 0
                }
            };

            // Encode text into QR code
            var matrix = writer.Encode(text);

            // Create Bitmap from BitMatrix
            var bitmap = new Bitmap(matrix.Width, matrix.Height);
            for (int x = 0; x < matrix.Width; x++)
            {
                for (int y = 0; y < matrix.Height; y++)
                {
                    bitmap.SetPixel(x, y, matrix[x, y] ? Color.Black : Color.White);
                }
            }

            // Set PictureBox's Image to the generated Bitmap
            pictureBoxQR.Image = bitmap;
        }

        private void QRcodeForm_Load(object sender, EventArgs e)
        {

        }

        private void doneQR_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
