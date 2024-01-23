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
    public partial class frmMain : Form
    {
        IFlowerBouquetRepository flowerBouquetRepository = new FlowerBouquetRepository();
        ICartRepository cartRepository = new CartRepository();
        public Customer customer { get; set; }
        public frmMain(Customer cus)
        {
            InitializeComponent();
            this.customer = cus;
            LoadCategories();
            LoadSuppliers();
            LoadProducts();
        }
        public frmMain()
        {
            InitializeComponent();
        }

        #region Methods
        private void LoadCategories()
        {
            var categories = flowerBouquetRepository.GetCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
        }
        public void LoadSuppliers()
        {
            var suppliers = flowerBouquetRepository.GetSuppliers();
            cbSupplier.DataSource = suppliers;
            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "SupplierId";

        }
        private void LoadProducts()
        {
            dtgvFlower.DataSource = null;
            try
            {
                var flowers = flowerBouquetRepository.GetFlowerBouquets();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = flowers;


                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtStock.DataBindings.Clear();
                cbCategory.DataBindings.Clear();
                cbSupplier.DataBindings.Clear();




                txtID.DataBindings.Add("Text", bindingSource, "FlowerBouquetId");
                txtName.DataBindings.Add("Text", bindingSource, "FlowerBouquetName");
                txtPrice.DataBindings.Add("Text", bindingSource, "UnitPrice");
                txtStock.DataBindings.Add("Text", bindingSource, "UnitsInStock");
                cbCategory.DataBindings.Add("Text", bindingSource, "CategoryName");
                cbSupplier.DataBindings.Add("Text", bindingSource, "SupplierName");


                dtgvFlower.DataSource = bindingSource;
                dtgvFlower.Columns["CategoryId"].Visible = false;
                dtgvFlower.Columns["SupplierID"].Visible = false;
                dtgvFlower.Columns["Supplier"].Visible = false;
                dtgvFlower.Columns["Category"].Visible = false;
                dtgvFlower.Columns["FlowerBouquetStatus"].Visible = false;
                dtgvFlower.Columns["OrderDetails"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }

        }
        private void LoadCart()
        {
            var cart = cartRepository.GetCart();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = cart;
            dtgvCart.DataSource = bindingSource;
        }
        private void LoadTotal()
        {
            decimal total = cartRepository.GetTotal();
            lbTotalValue.Text = total.ToString() + "₫";
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
        #endregion


        #region Events
        private void vtProfileView_Click(object sender, EventArgs e)
        {
            frmDetailProfile frmDetailProfile = new frmDetailProfile(customer);
            frmDetailProfile.Show();
        }
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdersHistory frmOrdersHistory = new frmOrdersHistory(customer);
            this.Hide();
            frmOrdersHistory.ShowDialog();
            this.Show();
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "search flower.....")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = "search project.....";
                txtSearch.ForeColor = Color.Silver;
                LoadProducts();
                //dtgvFlower.DataSource = flowerBouquetRepository.GetFlowerBouquets();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<FlowerBouquet> list = (List<FlowerBouquet>)flowerBouquetRepository.GetFlowerBouquets();
            dtgvFlower.DataSource = list.Where(f => f.FlowerBouquetName.Contains(txtSearch.Text)).ToList();
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            FlowerBouquet flowerBouquet = flowerBouquetRepository.GetFlowerBouquetById(Convert.ToInt32(txtID.Text));
            int quantity = Convert.ToInt32(nupQuantity.Value);
            cartRepository.AddToCart(flowerBouquet, quantity);
            LoadCart();
            LoadTotal();
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            bool OK = MessageBoxQuestion("Do you want to checkout?");
            if (OK == true)
            {
                decimal total = Convert.ToDecimal(lbTotalValue.Text.Remove(lbTotalValue.Text.Length - 1));
                cartRepository.Checkout(customer.CustomerId, total);
                LoadCart();
                LoadTotal();
            }
        }
        #endregion

    }
}
