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
    public partial class frmOrderDetail : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        public int Id { get; set; }
        public frmOrderDetail(int id)
        {
            InitializeComponent();
            Id = id;
            LoadOrder();
        }
        #region
        private void LoadOrder()
        {
            var order = orderRepository.GetOrderById(Id);
            txtOrderID.Text = order.GetType().GetProperty("OrderId")?.GetValue(order).ToString();
            txtCustomerName.Text = order.GetType().GetProperty("CustomerName")?.GetValue(order).ToString();
            txtTotal.Text = order.GetType().GetProperty("Total")?.GetValue(order).ToString();
            txtOrderStatus.Text = order.GetType().GetProperty("OrderStatus")?.GetValue(order).ToString();
            dtpOrderDate.Text = order.GetType().GetProperty("OrderDate")?.GetValue(order).ToString();
            dtpShippedDate.Text = order.GetType().GetProperty("ShippedDate")?.GetValue(order)?.ToString();
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            orderRepository.UpdateOrder(Convert.ToInt32(txtOrderID.Text), Convert.ToDateTime(dtpShippedDate.Text), txtOrderStatus.Text);
            this.Close();
        }
    }
}
