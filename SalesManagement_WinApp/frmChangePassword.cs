using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_WinApp
{
    public partial class frmChangePassword : Form
    {
        ICustomerRepository customerRepository = new CustomerRepository();
        public Customer customer { get; set; }
        public frmChangePassword(Customer cus)
        {
            InitializeComponent();
            this.customer = cus;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text == customer.Password)
            {
                if (txtNewPassword.Text == txtNewPassword.Text && txtNewPassword.Text.Trim() != "")
                {
                    DialogResult d = MessageBox.Show("Do you want to change password", "Notification", MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question);
                    if (d == DialogResult.OK)
                    {
                        customerRepository.ChangePassword(customer.CustomerId, txtNewPassword.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Password confirmation does not match", "Notification", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Invalid Current Password", "Notification", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
