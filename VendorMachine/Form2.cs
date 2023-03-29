using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorMachine
{
    public partial class CreditCardForm : Form
    {
        public CreditCardForm()
        {
            InitializeComponent();
        }

        private void CreditCardForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void doneCC_Click(object sender, EventArgs e)
        {
            // Display a message box with the "Validated" message
            MessageBox.Show("Validated");

            // Terminate the application
            this.Close();
        }
    }
}
