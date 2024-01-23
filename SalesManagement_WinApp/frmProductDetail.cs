using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_WinApp
{
    public partial class frmProductDetail : Form
    {
        IFlowerBouquetRepository flowerBouquetRepository = new FlowerBouquetRepository();
        public FlowerBouquet flowerBouquet { get; set; }
        public frmProductDetail(FlowerBouquet flowerBouquet)
        {
            InitializeComponent();
            this.flowerBouquet = flowerBouquet;
            btnAction.Text = "Update";
            LoadProduct();
            LoadCategories();
            LoadSuppliers();
            btnAction.Click += btnUpdate_Click;
        }
        public frmProductDetail()
        {
            InitializeComponent();
            btnAction.Text = "Create";
            lbFlowerID.Visible = false;
            txtFlowerID.Visible = false;
            nupPrice.Maximum = Decimal.MaxValue;
            nupPrice.DecimalPlaces = 4;
            LoadCategories();
            LoadSuppliers();
            btnAction.Click += btnCreate_Click;
        }
        #region Methods
        private void LoadProduct()
        {
            txtFlowerID.Text = flowerBouquet.FlowerBouquetId.ToString();
            txtFlowerID.Enabled = false;
            txtFlowerName.Text = flowerBouquet.FlowerBouquetName;
            txtDescription.Text = flowerBouquet.Description;
            nupPrice.Maximum = Decimal.MaxValue;
            nupPrice.DecimalPlaces = 4;
            nupStock.Maximum = Decimal.MaxValue;
            nupPrice.Value = Convert.ToDecimal(flowerBouquet.UnitPrice);
            nupStock.Value = Convert.ToDecimal(flowerBouquet.UnitsInStock);
            cbCategory.Text = flowerBouquet.CategoryName;
            if (flowerBouquet.FlowerBouquetStatus == 1)
            {
                rbtnActive.Checked = true;
            }
            else
            {
                rbtnInactive.Checked = true;
            }
            //var categories = flowerBouquetRepository.GetCategories();
            //foreach (var category in categories)
            //{
            //    if (flowerBouquet.CategoryId == category.CategoryId)
            //    {
            //        cbCategory.Text = category.CategoryName;
            //    }
            //}
        }
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
            if (txtFlowerName.Text.Length == 0 || txtDescription.Text.Length == 0)
            {
                MessageBox.Show("Invalid input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                bool OK = MessageBoxQuestion("Do you want to update the flower");
                if (OK == true)
                {
                    bool status = false;
                    RadioButton radioButton = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                    if (radioButton != null)
                    {
                        status = true;
                    }
                    flowerBouquetRepository.UpdateFlowerBouquet(Convert.ToInt32(txtFlowerID.Text), txtFlowerName.Text, txtDescription.Text, nupPrice.Value, Convert.ToInt32(nupStock.Value), status, Convert.ToInt32(cbCategory.SelectedValue), Convert.ToInt32(cbSupplier.SelectedValue));
                    this.Close();
                }
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtFlowerName.Text.Length == 0 || txtDescription.Text.Length == 0)
            {
                MessageBox.Show("Invalid input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                bool status = false;
                RadioButton radioButton = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radioButton != null)
                {
                    status = true;
                }
                flowerBouquetRepository.CreateNewFlowerBouquet(txtFlowerName.Text, txtDescription.Text, nupPrice.Value, Convert.ToInt32(nupStock.Value), status, Convert.ToInt32(cbCategory.SelectedValue), Convert.ToInt32(cbSupplier.SelectedValue));
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
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
