using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_WinApp
{
    public partial class frmDetailProfile : Form
    {
        ICustomerRepository customerRepository = new CustomerRepository();
        public Customer customer { get; set; }
        public frmDetailProfile(Customer cus)
        {
            InitializeComponent();
            this.customer = cus;
            loadCustomerInfo();
        }
        #region Methods
        private void loadCustomerInfo()
        {
            txtID.Text = customer.CustomerId.ToString();
            txtName.Text = customer.CustomerName;
            txtEmail.Text = customer.Email;
            txtPassword.Text = customer.Password;
            txtCity.Text = customer.City;
            txtCountry.Text = customer.Country;
            dtpBirthDay.Text = customer.Birthday.ToString();
        }
        private bool MessageBoxQuestion(string content)
        {
            bool OK = false;
            DialogResult d = MessageBox.Show(content, Text + " - Notification", MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                OK = true;
            }
            return OK;
        }
        private void MessageBoxWarning(string content)
        {
            MessageBox.Show(content, Text + " - Warning", MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool OK = MessageBoxQuestion("Do you want to update the profile?");
            if (OK = true)
            {
                String name = txtName.Text;
                String city = txtCity.Text;
                String country = txtCountry.Text;
                String email = txtEmail.Text;
                DateTime birthDay = Convert.ToDateTime(dtpBirthDay.Text);
                customerRepository.UpdateInfo(customer.CustomerId, name, email, city, country, birthDay);
            }
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(customer);
            this.Hide();
            frmChangePassword.ShowDialog();
            this.Show();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool OK = MessageBoxQuestion("Do you want to exit?");
            if(OK == true)
            {
                this.Close();
            }
        }
        #endregion



    }
}
