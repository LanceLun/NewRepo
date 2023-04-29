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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			labelTotalPrice = new Label();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			comboBox1 = new ComboBox();
			numericUpDown1 = new NumericUpDown();
			label5 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(28, 70);
			label1.Name = "label1";
			label1.Size = new Size(39, 19);
			label1.TabIndex = 0;
			label1.Text = "產品";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(28, 131);
			label2.Name = "label2";
			label2.Size = new Size(39, 19);
			label2.TabIndex = 0;
			label2.Text = "數量";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(28, 191);
			label3.Name = "label3";
			label3.Size = new Size(39, 19);
			label3.TabIndex = 0;
			label3.Text = "單價";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(472, 423);
			label4.Name = "label4";
			label4.Size = new Size(72, 25);
			label4.TabIndex = 0;
			label4.Text = "總金額";
			// 
			// labelTotalPrice
			// 
			labelTotalPrice.AutoSize = true;
			labelTotalPrice.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
			labelTotalPrice.Location = new Point(632, 423);
			labelTotalPrice.Name = "labelTotalPrice";
			labelTotalPrice.Size = new Size(106, 25);
			labelTotalPrice.TabIndex = 0;
			labelTotalPrice.Text = "totalPrice";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(312, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(548, 396);
			dataGridView1.TabIndex = 2;
			// 
			// button1
			// 
			button1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(28, 252);
			button1.Name = "button1";
			button1.Size = new Size(229, 72);
			button1.TabIndex = 3;
			button1.Text = "訂購";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "台啤", "百威", "雪山" });
			comboBox1.Location = new Point(106, 70);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 27);
			comboBox1.TabIndex = 4;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(106, 131);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(150, 27);
			numericUpDown1.TabIndex = 5;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(150, 191);
			label5.Name = "label5";
			label5.Size = new Size(43, 19);
			label5.TabIndex = 6;
			label5.Text = "price";
			label5.Click += label5_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(911, 460);
			Controls.Add(label5);
			Controls.Add(numericUpDown1);
			Controls.Add(comboBox1);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(labelTotalPrice);
			Controls.Add(label4);
			Controls.Add(label1);
			Name = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label labelTotalPrice;
		private DataGridView dataGridView1;
		private Button button1;
		private ComboBox comboBox1;
		private NumericUpDown numericUpDown1;
		private Label label5;
	}
}