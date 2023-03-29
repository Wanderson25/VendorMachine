using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorMachine
{
    public partial class VendorMachine : Form
    {
        public VendorMachine()
        {
            InitializeComponent();
        }

        private void VendorMachine_Load(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) //bus
        {

        }

        private void label2_Click(object sender, EventArgs e) //train
        {

        }

        private void plane_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkListTicket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbTrainDest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListPay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=fICPZt9uEjI");
        }

        private void book_Click(object sender, EventArgs e)
        {
            if (checkedListPay.CheckedItems.Contains("Credit Card"))
            {
                // Open Credit Card form
                CreditCardForm ccForm = new CreditCardForm();
                ccForm.Show();
            }
            else if (checkedListPay.CheckedItems.Contains("QR code"))
            {
                // Open QR code form
                QRcodeForm qrForm = new QRcodeForm();
                qrForm.Show();
            }
        }

        private void ShowTicketInfo(string destination, int seatNumber, int ticketID)
        {
            string message = string.Format("Destination: {0}\nSeat: {1}\nTicket's ID: {2}", destination, seatNumber, ticketID);
            MessageBox.Show(message, "Ticket Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
