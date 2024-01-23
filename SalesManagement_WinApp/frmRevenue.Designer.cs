namespace SalesManagement_WinApp
{
    partial class frmRevenue
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
            dtgvOrder = new System.Windows.Forms.DataGridView();
            lbTotal = new System.Windows.Forms.Label();
            dtpFrom = new System.Windows.Forms.DateTimePicker();
            dtpTo = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnSearch = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.TextBox();
            dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtTotal = new System.Windows.Forms.TextBox();
            txtOrderStatus = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dtgvOrder
            // 
            dtgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOrder.Location = new System.Drawing.Point(12, 60);
            dtgvOrder.Name = "dtgvOrder";
            dtgvOrder.RowHeadersWidth = 51;
            dtgvOrder.RowTemplate.Height = 29;
            dtgvOrder.Size = new System.Drawing.Size(792, 384);
            dtgvOrder.TabIndex = 0;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotal.ForeColor = System.Drawing.Color.ForestGreen;
            lbTotal.Location = new System.Drawing.Point(12, 447);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new System.Drawing.Size(0, 31);
            lbTotal.TabIndex = 1;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new System.Drawing.Point(92, 16);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(250, 27);
            dtpFrom.TabIndex = 2;
            // 
            // dtpTo
            // 
            dtpTo.Location = new System.Drawing.Point(425, 16);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(250, 27);
            dtpTo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(23, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 25);
            label2.TabIndex = 4;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(365, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 25);
            label3.TabIndex = 5;
            label3.Text = "To";
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(698, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 33);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(842, 85);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 20);
            label1.TabIndex = 7;
            label1.Text = "OrderID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(842, 130);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(116, 20);
            label4.TabIndex = 8;
            label4.Text = "Customer Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(842, 173);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Order Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(842, 222);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 20);
            label6.TabIndex = 10;
            label6.Text = "Shipped Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(842, 264);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 20);
            label7.TabIndex = 11;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(842, 303);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(87, 20);
            label8.TabIndex = 12;
            label8.Text = "OrderStatus";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new System.Drawing.Point(990, 82);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(250, 27);
            txtOrderID.TabIndex = 13;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new System.Drawing.Point(990, 168);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new System.Drawing.Size(250, 27);
            dtpOrderDate.TabIndex = 14;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new System.Drawing.Point(990, 217);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new System.Drawing.Size(250, 27);
            dtpShippedDate.TabIndex = 15;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(990, 123);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(250, 27);
            txtCustomerName.TabIndex = 16;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(990, 257);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(250, 27);
            txtTotal.TabIndex = 17;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new System.Drawing.Point(990, 300);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new System.Drawing.Size(250, 27);
            txtOrderStatus.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(1146, 353);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(710, 449);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(94, 29);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.Highlight;
            label9.Location = new System.Drawing.Point(823, 17);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(336, 41);
            label9.TabIndex = 21;
            label9.Text = "ORDER MANEGEMENT";
            // 
            // frmRevenue
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1284, 487);
            Controls.Add(label9);
            Controls.Add(btnReset);
            Controls.Add(btnUpdate);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtTotal);
            Controls.Add(txtCustomerName);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtOrderID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(lbTotal);
            Controls.Add(dtgvOrder);
            Name = "frmRevenue";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Report Statistic";
            ((System.ComponentModel.ISupportInitialize)dtgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvOrder;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpShippedDate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label label9;
    }
}