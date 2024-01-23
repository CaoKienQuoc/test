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
    public partial class frmOrdersHistory : Form
    {
        ICustomerRepository customerRepository = new CustomerRepository();
        public Customer customer { get; set; }
        public frmOrdersHistory(Customer cus)
        {
            InitializeComponent();
            this.customer = cus;
            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            var ordershistory = customerRepository.GetOrdersHistory(customer.CustomerId);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ordershistory;
            dtgvOrdersHistory.DataSource = bindingSource;

            int rows = dtgvOrdersHistory.Rows.Count;
            float total = 0;
            foreach (var order in ordershistory)
            {
                decimal demicalValue = (decimal)order.GetType().GetProperty("Price")?.GetValue(order);
                total += Convert.ToSingle(demicalValue);
            }
            lbTotal.Text += total.ToString() + ".0000₫";
        }
    }
}
