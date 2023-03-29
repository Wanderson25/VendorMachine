namespace VendorMachine
{
    partial class QRcodeForm
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
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.doneQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(213, 12);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(415, 343);
            this.pictureBoxQR.TabIndex = 0;
            this.pictureBoxQR.TabStop = false;
            // 
            // doneQR
            // 
            this.doneQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.doneQR.Location = new System.Drawing.Point(277, 381);
            this.doneQR.Name = "doneQR";
            this.doneQR.Size = new System.Drawing.Size(179, 41);
            this.doneQR.TabIndex = 1;
            this.doneQR.Text = "Done";
            this.doneQR.UseVisualStyleBackColor = true;
            this.doneQR.Click += new System.EventHandler(this.doneQR_Click);
            // 
            // QRcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneQR);
            this.Controls.Add(this.pictureBoxQR);
            this.Name = "QRcodeForm";
            this.Text = "QRcode";
            this.Load += new System.EventHandler(this.QRcodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.Button doneQR;
    }
}