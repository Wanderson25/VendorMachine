namespace VendorMachine
{
    partial class CreditCardForm
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
            this.bank = new System.Windows.Forms.Label();
            this.AccNum = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.Label();
            this.textBoxbank = new System.Windows.Forms.TextBox();
            this.textBoxAccNum = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.doneCC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bank.Location = new System.Drawing.Point(54, 53);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(67, 29);
            this.bank.TabIndex = 0;
            this.bank.Text = "Bank";
            // 
            // AccNum
            // 
            this.AccNum.AutoSize = true;
            this.AccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AccNum.Location = new System.Drawing.Point(54, 131);
            this.AccNum.Name = "AccNum";
            this.AccNum.Size = new System.Drawing.Size(191, 29);
            this.AccNum.TabIndex = 1;
            this.AccNum.Text = "Account Number";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.username.Location = new System.Drawing.Point(54, 206);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(124, 29);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // phonenum
            // 
            this.phonenum.AutoSize = true;
            this.phonenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.phonenum.Location = new System.Drawing.Point(54, 282);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(176, 29);
            this.phonenum.TabIndex = 3;
            this.phonenum.Text = "Phone Number";
            // 
            // textBoxbank
            // 
            this.textBoxbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxbank.Location = new System.Drawing.Point(289, 61);
            this.textBoxbank.Name = "textBoxbank";
            this.textBoxbank.Size = new System.Drawing.Size(209, 35);
            this.textBoxbank.TabIndex = 4;
            // 
            // textBoxAccNum
            // 
            this.textBoxAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxAccNum.Location = new System.Drawing.Point(289, 140);
            this.textBoxAccNum.Name = "textBoxAccNum";
            this.textBoxAccNum.Size = new System.Drawing.Size(209, 35);
            this.textBoxAccNum.TabIndex = 5;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxUserName.Location = new System.Drawing.Point(289, 206);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(209, 35);
            this.textBoxUserName.TabIndex = 6;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxPhoneNum.Location = new System.Drawing.Point(289, 282);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(209, 35);
            this.textBoxPhoneNum.TabIndex = 7;
            this.textBoxPhoneNum.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // doneCC
            // 
            this.doneCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.doneCC.Location = new System.Drawing.Point(246, 351);
            this.doneCC.Name = "doneCC";
            this.doneCC.Size = new System.Drawing.Size(252, 54);
            this.doneCC.TabIndex = 8;
            this.doneCC.Text = "Validate Now";
            this.doneCC.UseVisualStyleBackColor = true;
            this.doneCC.Click += new System.EventHandler(this.doneCC_Click);
            // 
            // CreditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneCC);
            this.Controls.Add(this.textBoxPhoneNum);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxAccNum);
            this.Controls.Add(this.textBoxbank);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.username);
            this.Controls.Add(this.AccNum);
            this.Controls.Add(this.bank);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "CreditCardForm";
            this.Text = "CreditCard";
            this.Load += new System.EventHandler(this.CreditCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bank;
        private System.Windows.Forms.Label AccNum;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label phonenum;
        private System.Windows.Forms.TextBox textBoxbank;
        private System.Windows.Forms.TextBox textBoxAccNum;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.Button doneCC;
    }
}