using Lance_shop_app.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lance_shop_app
{
	public partial class Form1 : Form
	{
		Products twBeer = new Products("台啤", 40);
		Products bwBeer = new Products("百威", 35);
		Products smBeer = new Products("雪山", 50);
		private List<Orders> orders = new List<Orders>();

		public Form1()
		{
			InitializeComponent();
			this.Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			labelTotalPrice.Text = string.Empty;
			dataGridView1.Columns.Add("Name", "商品");
			dataGridView1.Columns.Add("Qty", "數量");
			dataGridView1.Columns.Add("Price", "單價");
			dataGridView1.Columns.Add("TotalPrice", "總金額");
			label5.Text = string.Empty;
			comboBox1.TextChanged += ComboBox1_TextChanged;
		}

		private Products GetProductByName()
		{
			switch (comboBox1.Text)
			{
				case "台啤": return twBeer;
				case "百威": return bwBeer;
				case "雪山": return smBeer;
				default: return null;
			}
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			UpdateTotalPrice();
		}


		private void UpdateTotalPrice()
		{
			var totalPrice = orders.GetOrderTotalPrice();
			labelTotalPrice.Text = $"總金額：{totalPrice}元";
		}

		private void ComboBox1_TextChanged(object sender, EventArgs e)
		{
			switch (comboBox1.Text)
			{
				case "台啤": label5.Text = "40"; break;
				case "百威": label5.Text = "35"; break;
				case "雪山": label5.Text = "50"; break;
				default: label5.Text = ""; break;
			}
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var selectedProduct = GetProductByName();
			var qty = (int)numericUpDown1.Value;
			var order = new Orders(selectedProduct, qty);
			orders.Add(order);

			// 新增一個 dataGridView1 的 row 來顯示訂單資訊
			var row = new DataGridViewRow();
			row.CreateCells(dataGridView1);
			row.Cells[0].Value = selectedProduct.Name;
			row.Cells[1].Value = qty;
			row.Cells[2].Value = selectedProduct.Price;
			row.Cells[3].Value = order.TotalPrice;
			dataGridView1.Rows.Add(row);

			labelTotalPrice.Text = orders.GetOrderTotalPrice().ToString();
		}
	}
}
