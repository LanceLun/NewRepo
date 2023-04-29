using Lance_shop_app.model;
using Newtonsoft.Json;
using System;
using System.Collections;
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
        private List<Order> _orders;
        private List<Product> _products;
        private List<Product> _filterproducts;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化 你這個沒有綁到Form1_Load事件
		/// 所以你沒有初始化到，但因為妳都是用UI設定所以感覺沒事
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // init
                labelTotalPrice.Text = String.Empty;
                _orders = new List<Order>();

                // 產品下拉選單           
                _products = new List<Product>()
                {
                  new Product("請選擇","0", 0),
                  new Product("台啤","1", 40),
                  new Product("百威","2", 35),
                  new Product("雪山","3", 50)
                };
                cbProduct.DataSource = _products;
                cbProduct.DisplayMember = "Name";
                cbProduct.ValueMember = "Value";

                // 預設第一筆
                cbProduct.SelectedValue = "0";
                this.cbProduct.SelectedValueChanged += new System.EventHandler(this.cbProduct_SelectedValueChanged);
                this.cbProduct_SelectedValueChanged(this.cbProduct, new EventArgs());

                // 篩選產品下拉選單
                _filterproducts = new List<Product>()
                {
                  new Product("全部","0", 0),
                  new Product("台啤","1", 40),
                  new Product("百威","2", 35),
                  new Product("雪山","3", 50)
                };
                cbFilterProduct.DataSource = _filterproducts;
                cbFilterProduct.DisplayMember = "Name";
                cbFilterProduct.ValueMember = "Value";

                // 綁定Submit
                this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

                // 篩選
                this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系統初始錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbFilterProduct.SelectedValue == "0")
            {
                DataBind(_orders);
            }
            else
            {
                var filterProduct = _filterproducts.FirstOrDefault(f => f.Value == cbFilterProduct.SelectedValue);
                var filterOrders = _orders.Where(o => o.ProductName == filterProduct.Name).ToList();

                if (filterOrders.Count() == 0)
                {
                    MessageBox.Show("查無此資料", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataBind(filterOrders);
                }
            }

        }

        /// <summary>
        /// 購買按鈕，當沒選擇商品或是數量就通知異常，購買成功要顯示出來並將按鈕返回預設值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // 驗證
                List<string> errMsgs = GetErrMsg();
                if (errMsgs.Count() > 0)
                {
                    MessageBox.Show(String.Join("\n", errMsgs), "驗證錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 新增商品訂單
                var selectedProduct = _products.FirstOrDefault(p => p.Value == cbProduct.SelectedValue);
                int qty = (int)numUDCount.Value;
                Order order = new Order(selectedProduct.Name, selectedProduct.Price, qty);
                _orders.Add(order);
                DataBind(_orders);

                // Init
                Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "新增商品有誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            // sender 代表自己
            var cbProduct = sender as ComboBox;
            if (cbProduct.SelectedValue == "0")
            {
                lableUnitPrice.Text = String.Empty;
            }
            else
            {
                var userSelectedProduct = _products.FirstOrDefault(p => p.Value == cbProduct.SelectedValue);
                lableUnitPrice.Text = userSelectedProduct.Price.ToString();
            }
        }

        private List<string> GetErrMsg()
        {
            List<string> errMsgs = new List<string>();
            if (cbProduct.SelectedValue == "0")
                errMsgs.Add("請選擇商品");

            if (numUDCount.Value <= 0)
                errMsgs.Add("數量不得低於0");
            return errMsgs;
        }

        private void Init()
        {
            cbProduct.SelectedValue = "0";
            numUDCount.Value = 0;
        }

        private void DataBind(List<Order> orders)
        {
            string jsonOrders = JsonConvert.SerializeObject(orders);
            DataTable dtOrders = JsonConvert.DeserializeObject<DataTable>(jsonOrders);
            dGVDetail.DataSource = dtOrders;
            labelTotalPrice.Text = orders.Sum(p => p.TotalPrice).ToString();
        }
    }
}
