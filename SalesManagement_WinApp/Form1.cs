using BusinessObjects;
using Microsoft.Extensions.Configuration;
using Repositories;
using System;
using System.IO;
using System.Windows.Forms;

namespace SalesManagement_WinApp
{
    public partial class Form1 : Form
    {
        ICustomerRepository customerRepository = new CustomerRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Email: DavidCopperfield@fuflowerbouquetsystem.com
            //password: 2
            Customer cus = customerRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
            if (cus != null)
            {
                frmMain frmMain = new frmMain(cus);
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else
            {
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true).Build();
                var email = config["AdminAccount:Email"];
                var password = config["AdminAccount:Password"];
                if (txtEmail.Text == email && txtPassword.Text == password)
                {
                    frmAdmin frmAdmin = new frmAdmin();
                    this.Hide();
                    frmAdmin.ShowDialog();
                    this.Show();
                }
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("Invalid Email or Password", "Login Notification",
                                               MessageBoxButtons.OKCancel, MessageBoxIcon.Error,
                                               MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
