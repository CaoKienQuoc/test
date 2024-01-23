using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagement_WinApp
{
    public partial class frmRevenue : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        public frmRevenue()
        {
            InitializeComponent();
            LoadOrders();
        }
        #region Methods
        public void BindingOrders(dynamic orders)
        {

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = orders;


            txtOrderID.DataBindings.Clear();
            txtCustomerName.DataBindings.Clear();
            txtOrderStatus.DataBindings.Clear();
            txtTotal.DataBindings.Clear();
            dtpOrderDate.DataBindings.Clear();
            dtpShippedDate.DataBindings.Clear();

            if (orders.Count > 0)
            {
                txtOrderID.DataBindings.Add("Text", bindingSource, "OrderId");
                txtCustomerName.DataBindings.Add("Text", bindingSource, "CustomerName");
                txtOrderStatus.DataBindings.Add("Text", bindingSource, "OrderStatus");
                txtTotal.DataBindings.Add("Text", bindingSource, "Total");
                dtpShippedDate.DataBindings.Add("Text", bindingSource, "ShippedDate");
                dtpOrderDate.DataBindings.Add("Text", bindingSource, "OrderDate");
            }
            else
            {
                txtOrderID.Text = "";
                txtCustomerName.Text = "";
                txtOrderStatus.Text = "";
                txtTotal.Text = "";
            }

            dtgvOrder.DataSource = null;
            dtgvOrder.DataSource = bindingSource;
            float total = 0;
            foreach (var order in orders)
            {
                decimal demicalValue = (decimal)order.GetType().GetProperty("Total")?.GetValue(order);
                total += Convert.ToSingle(demicalValue);
            }

            lbTotal.Text = "Total: " + total.ToString() + ".0000₫";
        }
        public void LoadOrders()
        {
            var orders = orderRepository.GetOrders();
            BindingOrders(orders);
        }
        #endregion
        #region Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var orders = orderRepository.SearchOrdersByDate(Convert.ToDateTime(dtpFrom.Text), Convert.ToDateTime(dtpTo.Text));
            BindingOrders(orders);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "")
            {
                MessageBox.Show("Choose order to update", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                frmOrderDetail frmOrderDetail = new frmOrderDetail(Convert.ToInt32(txtOrderID.Text));
                frmOrderDetail.ShowDialog();
                LoadOrders();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
        #endregion


    }
}
