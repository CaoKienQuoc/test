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
    public partial class frmProduct : Form
    {
        IFlowerBouquetRepository flowerBouquetRepository = new FlowerBouquetRepository();
        public frmProduct()
        {
            InitializeComponent();
            LoadCategories();
            LoadSuppliers();
            LoadProducts();
            txtID.Enabled = false;
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            FlowerBouquet flowerBouquet = flowerBouquetRepository.GetFlowerBouquetById(Convert.ToInt32(txtID.Text));
            frmProductDetail frmProductDetail = new frmProductDetail(flowerBouquet);
            frmProductDetail.ShowDialog();
            LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<FlowerBouquet> list = (List<FlowerBouquet>)flowerBouquetRepository.GetFlowerBouquets();
            dtgvFlower.DataSource = list.Where(f => f.FlowerBouquetName.Contains(txtSearch.Text)).ToList();
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
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail();
            frmProductDetail.ShowDialog();
            LoadProducts();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool OK = MessageBoxQuestion("Do you want to delete the flower");
            flowerBouquetRepository.DeleteFlowerBouquet(Convert.ToInt32(txtID.Text));
            LoadProducts();
        }
        #endregion


    }
}
