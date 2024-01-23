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
    public partial class frmAdmin : Form
    {
        ICustomerRepository customerRepository = new CustomerRepository();
        public frmAdmin()
        {
            InitializeComponent();
            LoadCustomers();
        }
        #region Methods
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
        private void LoadCustomers()
        {
            var customers = customerRepository.GetCustomers();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = customers;

            txtCustomerID.DataBindings.Clear();
            txtCustomerName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            dtpBirthDay.DataBindings.Clear();

            txtCustomerID.DataBindings.Add("Text", bindingSource, "CustomerId");
            txtCustomerName.DataBindings.Add("Text", bindingSource, "CustomerName");
            txtEmail.DataBindings.Add("Text", bindingSource, "Email");
            txtPassword.DataBindings.Add("Text", bindingSource, "Password");
            txtCity.DataBindings.Add("Text", bindingSource, "City");
            txtCountry.DataBindings.Add("Text", bindingSource, "Country");

            dtgvCustomer.DataSource = bindingSource;
            dtgvCustomer.Columns["Orders"].Visible = false;
        }
        #endregion

        #region Events
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCustomerDetail frmCustomerDetail = new frmCustomerDetail();
            frmCustomerDetail.Text = "Create New User";
            frmCustomerDetail.ShowDialog();
            LoadCustomers();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer cus = customerRepository.GetCustomerById(Convert.ToInt32(txtCustomerID.Text));
            frmCustomerDetail frmCustomerDetail = new frmCustomerDetail(cus);
            frmCustomerDetail.ShowDialog();
            LoadCustomers();
        }

        private void tsmiProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
                
            frmProduct.ShowDialog();
            this.Show();
        }
        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRevenue frmOrder = new frmRevenue();
            this.Hide();
            frmOrder.ShowDialog();
            this.Show();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            bool OK = MessageBoxQuestion("Do you want to exit?");
            if (OK == true)
            {
                this.Close();
            }
        }
        #endregion





    }
}
