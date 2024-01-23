namespace SalesManagement_WinApp
{
    partial class frmOrder
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
            ((System.ComponentModel.ISupportInitialize)dtgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dtgvOrder
            // 
            dtgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOrder.Location = new System.Drawing.Point(12, 53);
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
            // frmOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(816, 487);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(lbTotal);
            Controls.Add(dtgvOrder);
            Name = "frmOrder";
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
    }
}