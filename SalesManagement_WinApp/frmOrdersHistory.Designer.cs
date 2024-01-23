namespace SalesManagement_WinApp
{
    partial class frmOrdersHistory
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
            dtgvOrdersHistory = new System.Windows.Forms.DataGridView();
            label4 = new System.Windows.Forms.Label();
            lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtgvOrdersHistory).BeginInit();
            SuspendLayout();
            // 
            // dtgvOrdersHistory
            // 
            dtgvOrdersHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOrdersHistory.Location = new System.Drawing.Point(12, 78);
            dtgvOrdersHistory.Name = "dtgvOrdersHistory";
            dtgvOrdersHistory.RowHeadersWidth = 51;
            dtgvOrdersHistory.RowTemplate.Height = 29;
            dtgvOrdersHistory.Size = new System.Drawing.Size(654, 263);
            dtgvOrdersHistory.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.Highlight;
            label4.Location = new System.Drawing.Point(23, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(270, 41);
            label4.TabIndex = 7;
            label4.Text = "ORDERS HISTORY";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotal.ForeColor = System.Drawing.Color.ForestGreen;
            lbTotal.Location = new System.Drawing.Point(12, 359);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new System.Drawing.Size(79, 31);
            lbTotal.TabIndex = 8;
            lbTotal.Text = "Total: ";
            // 
            // frmOrdersHistory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(726, 456);
            Controls.Add(lbTotal);
            Controls.Add(label4);
            Controls.Add(dtgvOrdersHistory);
            Name = "frmOrdersHistory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Orders History";
            ((System.ComponentModel.ISupportInitialize)dtgvOrdersHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvOrdersHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
    }
}