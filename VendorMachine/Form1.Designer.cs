namespace VendorMachine
{
    partial class VendorMachine
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
            this.title = new System.Windows.Forms.Label();
            this.bus = new System.Windows.Forms.Label();
            this.train = new System.Windows.Forms.Label();
            this.plane = new System.Windows.Forms.Label();
            this.cbbBusDest = new System.Windows.Forms.ComboBox();
            this.cbbTrainDest = new System.Windows.Forms.ComboBox();
            this.cbbPlaneDest = new System.Windows.Forms.ComboBox();
            this.checkListTicket = new System.Windows.Forms.CheckedListBox();
            this.book = new System.Windows.Forms.Button();
            this.checkedListPay = new System.Windows.Forms.CheckedListBox();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.title.Location = new System.Drawing.Point(304, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(239, 37);
            this.title.TabIndex = 1;
            this.title.Text = "Today\'s Tickets";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // bus
            // 
            this.bus.AutoSize = true;
            this.bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bus.Location = new System.Drawing.Point(12, 59);
            this.bus.Name = "bus";
            this.bus.Size = new System.Drawing.Size(54, 29);
            this.bus.TabIndex = 2;
            this.bus.Text = "Bus";
            this.bus.Click += new System.EventHandler(this.label1_Click);
            // 
            // train
            // 
            this.train.AutoSize = true;
            this.train.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.train.Location = new System.Drawing.Point(308, 60);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(69, 29);
            this.train.TabIndex = 3;
            this.train.Text = "Train";
            this.train.Click += new System.EventHandler(this.label2_Click);
            // 
            // plane
            // 
            this.plane.AutoSize = true;
            this.plane.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plane.Location = new System.Drawing.Point(600, 60);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(75, 29);
            this.plane.TabIndex = 4;
            this.plane.Text = "Plane";
            this.plane.Click += new System.EventHandler(this.plane_Click);
            // 
            // cbbBusDest
            // 
            this.cbbBusDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cbbBusDest.FormattingEnabled = true;
            this.cbbBusDest.Items.AddRange(new object[] {
            "Chợ Lớn - Q6",
            "Chợ Bình Tây - Q6",
            "Chợ Bến Thành - Q1",
            "Chợ Hồ Thị Kỉ - Q10",
            "Tân Sơn Nhất",
            "Đầm Sen",
            "AEON Mall Bình Tân",
            "AEON Mall Tân Bình"});
            this.cbbBusDest.Location = new System.Drawing.Point(72, 57);
            this.cbbBusDest.Name = "cbbBusDest";
            this.cbbBusDest.Size = new System.Drawing.Size(230, 37);
            this.cbbBusDest.TabIndex = 5;
            this.cbbBusDest.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbbTrainDest
            // 
            this.cbbTrainDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cbbTrainDest.FormattingEnabled = true;
            this.cbbTrainDest.Items.AddRange(new object[] {
            "Cà Mau",
            "Đà Lạt",
            "Hà Nội",
            "Sapa",
            "Cao Bằng",
            "Đắk Lắk",
            "Nha Trang",
            "Vũng Tàu",
            "Côn Đảo",
            "Phú Quốc"});
            this.cbbTrainDest.Location = new System.Drawing.Point(383, 56);
            this.cbbTrainDest.Name = "cbbTrainDest";
            this.cbbTrainDest.Size = new System.Drawing.Size(211, 37);
            this.cbbTrainDest.TabIndex = 6;
            this.cbbTrainDest.SelectedIndexChanged += new System.EventHandler(this.cbbTrainDest_SelectedIndexChanged);
            // 
            // cbbPlaneDest
            // 
            this.cbbPlaneDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cbbPlaneDest.FormattingEnabled = true;
            this.cbbPlaneDest.Items.AddRange(new object[] {
            "%n/a%"});
            this.cbbPlaneDest.Location = new System.Drawing.Point(681, 56);
            this.cbbPlaneDest.Name = "cbbPlaneDest";
            this.cbbPlaneDest.Size = new System.Drawing.Size(153, 37);
            this.cbbPlaneDest.TabIndex = 7;
            this.cbbPlaneDest.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // checkListTicket
            // 
            this.checkListTicket.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkListTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.checkListTicket.ForeColor = System.Drawing.SystemColors.Info;
            this.checkListTicket.FormattingEnabled = true;
            this.checkListTicket.Items.AddRange(new object[] {
            "One-Way ",
            "Two-Ways",
            "Monthly",
            "Premium"});
            this.checkListTicket.Location = new System.Drawing.Point(17, 267);
            this.checkListTicket.Name = "checkListTicket";
            this.checkListTicket.Size = new System.Drawing.Size(167, 124);
            this.checkListTicket.TabIndex = 8;
            this.checkListTicket.SelectedIndexChanged += new System.EventHandler(this.checkListTicket_SelectedIndexChanged);
            // 
            // book
            // 
            this.book.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.book.Location = new System.Drawing.Point(383, 353);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(113, 38);
            this.book.TabIndex = 9;
            this.book.Text = "Book";
            this.book.UseVisualStyleBackColor = true;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // checkedListPay
            // 
            this.checkedListPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkedListPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.checkedListPay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListPay.FormattingEnabled = true;
            this.checkedListPay.Items.AddRange(new object[] {
            "Credit Card",
            "QR code"});
            this.checkedListPay.Location = new System.Drawing.Point(681, 327);
            this.checkedListPay.Name = "checkedListPay";
            this.checkedListPay.Size = new System.Drawing.Size(153, 64);
            this.checkedListPay.TabIndex = 10;
            this.checkedListPay.SelectedIndexChanged += new System.EventHandler(this.checkedListPay_SelectedIndexChanged);
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LinkLabel.Location = new System.Drawing.Point(12, 412);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(521, 29);
            this.LinkLabel.TabIndex = 11;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Any thoughts? Click on this link to express them.";
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // VendorMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.checkedListPay);
            this.Controls.Add(this.book);
            this.Controls.Add(this.checkListTicket);
            this.Controls.Add(this.cbbPlaneDest);
            this.Controls.Add(this.cbbTrainDest);
            this.Controls.Add(this.cbbBusDest);
            this.Controls.Add(this.plane);
            this.Controls.Add(this.train);
            this.Controls.Add(this.bus);
            this.Controls.Add(this.title);
            this.Name = "VendorMachine";
            this.Text = "VendorMachine";
            this.Load += new System.EventHandler(this.VendorMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label bus;
        private System.Windows.Forms.Label train;
        private System.Windows.Forms.Label plane;
        private System.Windows.Forms.ComboBox cbbBusDest;
        private System.Windows.Forms.ComboBox cbbTrainDest;
        private System.Windows.Forms.ComboBox cbbPlaneDest;
        private System.Windows.Forms.CheckedListBox checkListTicket;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.CheckedListBox checkedListPay;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

