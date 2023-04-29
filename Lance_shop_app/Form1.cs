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
		/// <summary>
		/// 在背景設定好商品及價格
		/// </summary>
		Products twBeer = new Products("台啤", 40);
		Products bwBeer = new Products("百威", 35);
		Products smBeer = new Products("雪山", 50);
		private List<Orders> _orders = new List<Orders>();

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			labelTotalPrice.Text = string.Empty;
			label5.Text = string.Empty;
			dataGridView1.Columns.Add("Name", "商品");
			dataGridView1.Columns.Add("Qty", "數量");
			dataGridView1.Columns.Add("Price", "單價");
			dataGridView1.Columns.Add("TotalPrice", "總金額");
			comboBox1.TextChanged += ComboBox1_TextChanged;
		}

		/// <summary>
		/// 選擇對應商品時，回傳預設好的商品
		/// </summary>
		/// <returns></returns>
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

	

		/// <summary>
		/// 產品價格寫死，選單變動，顯示價格要連動
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		

		/// <summary>
		/// 購買按鈕，當沒選擇商品或是數量就通知異常，購買成功要顯示出來並將按鈕返回預設值
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(comboBox1.Text))
			{
				MessageBox.Show("請選擇商品", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (numericUpDown1.Value <= 0)
			{
				MessageBox.Show("數量不得低於0", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

				var selectedProduct = GetProductByName();
				var qty = (int)numericUpDown1.Value;
				var order = new Orders(selectedProduct, qty);
				_orders.Add(order);

				// 新增一個 dataGridView1 的 row 來顯示訂單資訊
				dataGridView1.Rows.Add(selectedProduct.Name,qty, selectedProduct.Price, order.TotalPrice);


				labelTotalPrice.Text = _orders.GetOrderTotalPrice().ToString();

				comboBox1.Text = string.Empty;
				numericUpDown1.Value = 0;
				return;

		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}


	}
}
