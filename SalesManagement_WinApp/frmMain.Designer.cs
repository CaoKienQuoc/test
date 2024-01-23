namespace SalesManagement_WinApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vtProfileView = new System.Windows.Forms.ToolStripMenuItem();
            orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dtgvFlower = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            cbCategory = new System.Windows.Forms.ComboBox();
            txtID = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cbSupplier = new System.Windows.Forms.ComboBox();
            txtStock = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtSearch = new System.Windows.Forms.TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dtgvCart = new System.Windows.Forms.DataGridView();
            nupQuantity = new System.Windows.Forms.NumericUpDown();
            btnAddToCart = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            lbTotalText = new System.Windows.Forms.Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnCheckout = new System.Windows.Forms.Button();
            lbTotalValue = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFlower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupQuantity).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { profileToolStripMenuItem, orderToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1477, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { vtProfileView });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // vtProfileView
            // 
            vtProfileView.Name = "vtProfileView";
            vtProfileView.Size = new System.Drawing.Size(124, 26);
            vtProfileView.Text = "View";
            vtProfileView.Click += vtProfileView_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { historyToolStripMenuItem });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            orderToolStripMenuItem.Text = "Order";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            historyToolStripMenuItem.Text = "History";
            historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
            // 
            // dtgvFlower
            // 
            dtgvFlower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFlower.Location = new System.Drawing.Point(0, 88);
            dtgvFlower.Name = "dtgvFlower";
            dtgvFlower.RowHeadersWidth = 51;
            dtgvFlower.RowTemplate.Height = 29;
            dtgvFlower.Size = new System.Drawing.Size(588, 405);
            dtgvFlower.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(628, 294);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 4;
            label1.Text = "Category";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new System.Drawing.Point(759, 291);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new System.Drawing.Size(179, 28);
            cbCategory.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(759, 106);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(179, 27);
            txtID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(628, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Flower ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(628, 201);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(628, 155);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 20);
            label4.TabIndex = 9;
            label4.Text = "Flower Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(628, 244);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(82, 20);
            label5.TabIndex = 10;
            label5.Text = "Units Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(628, 346);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(64, 20);
            label6.TabIndex = 11;
            label6.Text = "Supplier";
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new System.Drawing.Point(759, 343);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new System.Drawing.Size(179, 28);
            cbSupplier.TabIndex = 12;
            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(759, 237);
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(179, 27);
            txtStock.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(759, 194);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(179, 27);
            txtPrice.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(759, 148);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(179, 27);
            txtName.TabIndex = 15;
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.ForeColor = System.Drawing.Color.Silver;
            txtSearch.Location = new System.Drawing.Point(12, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(165, 30);
            txtSearch.TabIndex = 29;
            txtSearch.Text = "search flower.....";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // dtgvCart
            // 
            dtgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCart.Location = new System.Drawing.Point(1003, 109);
            dtgvCart.Name = "dtgvCart";
            dtgvCart.RowHeadersWidth = 51;
            dtgvCart.RowTemplate.Height = 29;
            dtgvCart.Size = new System.Drawing.Size(413, 307);
            dtgvCart.TabIndex = 30;
            // 
            // nupQuantity
            // 
            nupQuantity.Location = new System.Drawing.Point(759, 418);
            nupQuantity.Name = "nupQuantity";
            nupQuantity.Size = new System.Drawing.Size(179, 27);
            nupQuantity.TabIndex = 31;
            nupQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new System.Drawing.Point(844, 451);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new System.Drawing.Size(94, 29);
            btnAddToCart.TabIndex = 32;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(660, 425);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 20);
            label7.TabIndex = 33;
            label7.Text = "Quantity";
            // 
            // lbTotalText
            // 
            lbTotalText.AutoSize = true;
            lbTotalText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalText.ForeColor = System.Drawing.Color.Green;
            lbTotalText.Location = new System.Drawing.Point(1003, 437);
            lbTotalText.Name = "lbTotalText";
            lbTotalText.Size = new System.Drawing.Size(77, 31);
            lbTotalText.TabIndex = 34;
            lbTotalText.Text = "Total: ";
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new System.Drawing.Point(1322, 439);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(94, 29);
            btnCheckout.TabIndex = 35;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lbTotalValue
            // 
            lbTotalValue.AutoSize = true;
            lbTotalValue.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotalValue.ForeColor = System.Drawing.Color.Green;
            lbTotalValue.Location = new System.Drawing.Point(1065, 437);
            lbTotalValue.Name = "lbTotalValue";
            lbTotalValue.Size = new System.Drawing.Size(41, 31);
            lbTotalValue.TabIndex = 36;
            lbTotalValue.Text = "0₫";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(1003, 75);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(114, 31);
            label8.TabIndex = 37;
            label8.Text = "Your Cart";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.Highlight;
            label9.Location = new System.Drawing.Point(196, 9);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(227, 41);
            label9.TabIndex = 38;
            label9.Text = "FLOWER SHOP";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1477, 512);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lbTotalValue);
            Controls.Add(btnCheckout);
            Controls.Add(lbTotalText);
            Controls.Add(label7);
            Controls.Add(btnAddToCart);
            Controls.Add(nupQuantity);
            Controls.Add(dtgvCart);
            Controls.Add(txtSearch);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(txtStock);
            Controls.Add(cbSupplier);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(cbCategory);
            Controls.Add(label1);
            Controls.Add(dtgvFlower);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFlower).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vtProfileView;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgvFlower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.DataGridView dtgvCart;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotalText;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lbTotalValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}