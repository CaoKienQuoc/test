namespace SalesManagement_WinApp
{
    partial class frmProduct
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
            dtgvFlower = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtStock = new System.Windows.Forms.TextBox();
            cbCategory = new System.Windows.Forms.ComboBox();
            cbSupplier = new System.Windows.Forms.ComboBox();
            txtSearch = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtgvFlower).BeginInit();
            SuspendLayout();
            // 
            // dtgvFlower
            // 
            dtgvFlower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFlower.Location = new System.Drawing.Point(12, 100);
            dtgvFlower.Name = "dtgvFlower";
            dtgvFlower.RowHeadersWidth = 51;
            dtgvFlower.RowTemplate.Height = 29;
            dtgvFlower.Size = new System.Drawing.Size(588, 405);
            dtgvFlower.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(631, 131);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 20);
            label2.TabIndex = 8;
            label2.Text = "Flower ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(631, 179);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 20);
            label4.TabIndex = 10;
            label4.Text = "Flower Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(631, 229);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 11;
            label3.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(631, 287);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(82, 20);
            label5.TabIndex = 12;
            label5.Text = "Units Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(631, 340);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 13;
            label1.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(631, 392);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(64, 20);
            label6.TabIndex = 14;
            label6.Text = "Supplier";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(752, 124);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(179, 27);
            txtID.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(752, 176);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(179, 27);
            txtName.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(752, 226);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(179, 27);
            txtPrice.TabIndex = 17;
            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(752, 280);
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(179, 27);
            txtStock.TabIndex = 18;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new System.Drawing.Point(752, 337);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new System.Drawing.Size(179, 28);
            cbCategory.TabIndex = 19;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new System.Drawing.Point(752, 389);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new System.Drawing.Size(179, 28);
            cbSupplier.TabIndex = 20;
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.ForeColor = System.Drawing.Color.Silver;
            txtSearch.Location = new System.Drawing.Point(12, 64);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(165, 30);
            txtSearch.TabIndex = 30;
            txtSearch.Text = "search flower.....";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(737, 425);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 31;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(837, 425);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(837, 460);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.SystemColors.Highlight;
            label7.Location = new System.Drawing.Point(12, 9);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(359, 41);
            label7.TabIndex = 34;
            label7.Text = "FLOWER MANAGEMENT";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1046, 520);
            Controls.Add(label7);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtSearch);
            Controls.Add(cbSupplier);
            Controls.Add(cbCategory);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dtgvFlower);
            Name = "frmProduct";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Flower Management";
            ((System.ComponentModel.ISupportInitialize)dtgvFlower).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvFlower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
    }
}