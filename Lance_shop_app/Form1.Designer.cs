namespace Lance_shop_app
{
	partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.dGVDetail = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.numUDCount = new System.Windows.Forms.NumericUpDown();
            this.lableUnitPrice = new System.Windows.Forms.Label();
            this.cbFilterProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "產品";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "單價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(602, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "總金額";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelTotalPrice.Location = new System.Drawing.Point(728, 334);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(81, 20);
            this.labelTotalPrice.TabIndex = 0;
            this.labelTotalPrice.Text = "totalPrice";
            // 
            // dGVDetail
            // 
            this.dGVDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Qty,
            this.Price,
            this.TotalPrice});
            this.dGVDetail.Location = new System.Drawing.Point(542, 11);
            this.dGVDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dGVDetail.Name = "dGVDetail";
            this.dGVDetail.ReadOnly = true;
            this.dGVDetail.RowHeadersWidth = 51;
            this.dGVDetail.RowTemplate.Height = 29;
            this.dGVDetail.Size = new System.Drawing.Size(453, 298);
            this.dGVDetail.TabIndex = 2;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "商品名稱";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "數量";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "單價";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "總價格";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(22, 171);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 57);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "訂購";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(82, 22);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(118, 23);
            this.cbProduct.TabIndex = 4;
            // 
            // numUDCount
            // 
            this.numUDCount.Location = new System.Drawing.Point(83, 73);
            this.numUDCount.Margin = new System.Windows.Forms.Padding(2);
            this.numUDCount.Name = "numUDCount";
            this.numUDCount.Size = new System.Drawing.Size(117, 23);
            this.numUDCount.TabIndex = 5;
            // 
            // lableUnitPrice
            // 
            this.lableUnitPrice.AutoSize = true;
            this.lableUnitPrice.Location = new System.Drawing.Point(116, 123);
            this.lableUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableUnitPrice.Name = "lableUnitPrice";
            this.lableUnitPrice.Size = new System.Drawing.Size(35, 15);
            this.lableUnitPrice.TabIndex = 6;
            this.lableUnitPrice.Text = "price";
            // 
            // cbFilterProduct
            // 
            this.cbFilterProduct.FormattingEnabled = true;
            this.cbFilterProduct.Location = new System.Drawing.Point(350, 22);
            this.cbFilterProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterProduct.Name = "cbFilterProduct";
            this.cbFilterProduct.Size = new System.Drawing.Size(118, 23);
            this.cbFilterProduct.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "產品";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Location = new System.Drawing.Point(290, 171);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(178, 57);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "篩選";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbFilterProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lableUnitPrice);
            this.Controls.Add(this.numUDCount);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dGVDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label labelTotalPrice;
		private DataGridView dGVDetail;
		private Button btnSubmit;
		private ComboBox cbProduct;
		private NumericUpDown numUDCount;
		private Label lableUnitPrice;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
        private ComboBox cbFilterProduct;
        private Label label5;
        private Button btnFilter;
    }
}