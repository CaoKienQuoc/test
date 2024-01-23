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
    public partial class frmCustomerDetail : Form
    {
        public Customer customer { get; set; }
        ICustomerRepository customerRepository = new CustomerRepository();
        public frmCustomerDetail(Customer cus)
        {
            InitializeComponent();
            this.customer = cus;
            LoadCustomer();
            txtCustomerID.Enabled = false;
            btnAction.Text = "Update";
            btnAction.Click += btnUpdate_Click;
        }
        public frmCustomerDetail()
        {
            InitializeComponent();
            lbCustomerID.Visible = false;
            txtCustomerID.Visible = false;
            btnAction.Text = "Create";
            btnAction.Click += btnCreate_Click;
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
        #region Methods
        private void LoadCustomer()
        {
            txtCustomerID.Text = customer.CustomerId.ToString();
            txtCustomerName.Text = customer.CustomerName;
            txtEmail.Text = customer.Email;
            txtPassword.Text = customer.Password;
            txtCity.Text = customer.City;
            txtCountry.Text = customer.Country;
            dtpBirthDay.Text = customer.Birthday.ToString();
        }
        #endregion
        #region Events
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Length == 0 || txtEmail.Text.Length == 0 || txtPassword.Text.Length == 0 || txtCity.Text.Length == 0 || txtCountry.Text.Length == 0)
            {
                MessageBox.Show("Invalid Input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                customerRepository.CreateNewCustomer(0, txtCustomerName.Text, txtEmail.Text, txtPassword.Text, txtCity.Text, txtCountry.Text, Convert.ToDateTime(dtpBirthDay.Text));
                this.Close();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Length == 0 || txtEmail.Text.Length == 0 || txtPassword.Text.Length == 0 || txtCity.Text.Length == 0 || txtCountry.Text.Length == 0)
            {
                MessageBox.Show("Invalid Input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool OK = MessageBoxQuestion("Do you want to update the customer?");
                if (OK == true)
                {
                    customerRepository.UpdateInfo(Convert.ToInt32(txtCustomerID.Text), txtCustomerName.Text, txtEmail.Text, txtCity.Text, txtCountry.Text, Convert.ToDateTime(dtpBirthDay.Text));
                    this.Close();
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
