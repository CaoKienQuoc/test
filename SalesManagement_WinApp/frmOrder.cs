using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalesManagement_WinApp
{
    public partial class frmOrder : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        public frmOrder()
        {
            InitializeComponent();
            LoadOrders();
        }
        #region Methods
        public void BindingOrders(List<object> list)
        {
            dtgvOrder.DataSource = list;
            float total = 0;
            foreach (var order in list)
            {
                decimal demicalValue = (decimal)order.GetType().GetProperty("Total")?.GetValue(order);
                total += Convert.ToSingle(demicalValue);
            }
            lbTotal.Text = "Total: " + total.ToString() + ".0000₫";
        }
        public void LoadOrders()
        {
            var orders = orderRepository.GetOrders();
            BindingOrders((List<object>)orders);
        }
        #endregion
        #region Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var orders = orderRepository.SearchOrdersByDate(Convert.ToDateTime(dtpFrom.Text), Convert.ToDateTime(dtpTo.Text));
            BindingOrders((List<object>)orders);
        }
        #endregion
    }
}
