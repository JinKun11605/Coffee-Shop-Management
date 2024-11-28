using CoffeeShopManagement;
using ProjectOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class frmMenu : UserControl
    {
        string CustemerID;
        CoffeeShopDBDataContext context = new CoffeeShopDBDataContext();

        public frmMenu(string custemerID)
        {
            InitializeComponent();
            CustemerID = custemerID;
            LoadData();
            lblCustomerID.Text += CustemerID;
            RegisterComboBoxEvents();
        }

        private List<OrderDetails> cartItems = new List<OrderDetails>();

        private void UpdatePriceDisplay(CheckBox priceCheckBox, ComboBox sizeComboBox, decimal basePrice)
        {
            decimal adjustedPrice = basePrice;
            if (sizeComboBox.SelectedIndex == 1)
            {
                adjustedPrice += 3000;
            }
            else if (sizeComboBox.SelectedIndex == 2)
            {
                adjustedPrice += 5000;
            }

            priceCheckBox.Text = adjustedPrice.ToString("N0") + " VND";
        }

        private double discount(string CustomerID)
        {
            var customers = context.Customers.FirstOrDefault(c => c.CustomerID == CustomerID);
            if (customers == null) return 0;

            if (customers.CustomerLevel == "Kim Cương")
            {
                return 0.1;
            }
            else if (customers.CustomerLevel == "Bạch Kim")
            {
                return 0.07;
            }
            else if (customers.CustomerLevel == "Vàng")
            {
                return 0.05;
            }
            else if (customers.CustomerLevel == "Bạc")
            {
                return 0.03;
            }
            else if (customers.CustomerLevel == "Đồng")
            {
                return 0;
            }
            return 0;
        }

        private OrderDetails GetItem(PictureBox pictureBox, CheckBox priceCheckBox, ComboBox sizeComboBox, NumericUpDown quantityUpDown, string name, decimal basePrice)
        {
            if (priceCheckBox != null && priceCheckBox.Checked)
            {
                if (sizeComboBox.SelectedIndex < 0)
                {
                    sizeComboBox.SelectedIndex = 0;
                }

                if (quantityUpDown.Value == 0)
                {
                    quantityUpDown.Value = 1;
                }

                decimal adjustedPrice = basePrice;
                if (sizeComboBox.SelectedIndex == 1)
                {
                    adjustedPrice += 3000;
                }
                else if (sizeComboBox.SelectedIndex == 2)
                {
                    adjustedPrice += 5000;
                }

                return new OrderDetails
                {
                    ProductName = name,
                    Quantity = (int)quantityUpDown.Value,
                    Price = adjustedPrice * (1 - (decimal)discount(CustemerID)),
                    Size = sizeComboBox.SelectedItem.ToString(),
                    ProductID = pictureBox.Name + sizeComboBox.SelectedItem.ToString(),
                    Discount = discount(CustemerID)
                };
            }
            return null;
        }

        private bool IsAnyCheckBoxChecked()
        {
            return this.Controls.OfType<CheckBox>().Any(cb => cb.Checked);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (!IsAnyCheckBoxChecked())
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để thêm vào giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemsToAdd = new List<OrderDetails>
            {
                GetItem(DRK001, pricecafeden, sizecafeden, quantitycafeden, "Cà phê đen", 20000),
                GetItem(DRK002, pricecafesua, sizecafesua, quantitycafesua, "Cà phê sữa", 25000),
                GetItem(DRK003, priceepcam, sizeepcam, quantityepcam, "Ép cam", 15000),
                GetItem(DRK004, priceepcarot, sizeepcarot, quantityepcarot, "Ép cà rốt", 15000),
                GetItem(DRK005, priceepoi, sizeepoi, quantityepoi, "Ép ổi", 15000),
                GetItem(DRK006, priceepduahau, sizeepduahau, quantityepduahau, "Ép dưa hấu", 15000),
                GetItem(DRK007, pricesinhtodau, sizesinhtodau, quantitysinhtodau, "Sinh tố dâu", 30000),
                GetItem(DRK008, pricesinhtobo, sizesinhtobo, quantitysinhtobo, "Sinh tố bơ", 30000),
                GetItem(DRK009, pricematcha, sizematcha, quantitymatcha, "Trà sữa thái xanh", 35000),
                GetItem(DRK0010, priceduongden, sizeduongden, quantityduongden, "Trà sữa trân châu đường đen", 35000),
            };

            foreach (var item in itemsToAdd)
            {
                if (item != null) cartItems.Add(item);
            }

            CustomerInfo customer = new CustomerInfo();
            customer.Order(cartItems);

            LoadData();
            ClearSelection();
            isBtnAddClicked = true;
        }

        private void ClearSelection()
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = 0;
                }
            }
        }


        private bool isBtnAddClicked = false;

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0 && !IsAnyCheckBoxChecked())
            {
                MessageBox.Show("Giỏ hàng trống! Vui lòng chọn sản phẩm trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isBtnAddClicked)
            {
                isBtnAddClicked = true;
                btnadd.PerformClick();
            }

            frmCheckout thanhtoan = new frmCheckout(cartItems, CustemerID);
            thanhtoan.ShowDialog();

            isBtnAddClicked = false;
            ClearSelection();
            dataGridView1.DataSource = null;
        }


        private void RegisterComboBoxEvents()
        {
            sizecafeden.SelectedIndexChanged += (s, e) => UpdatePriceDisplay(pricecafeden, sizecafeden, 20000);
            sizecafesua.SelectedIndexChanged += (s, e) => UpdatePriceDisplay(pricecafesua, sizecafesua, 25000);
            sizesinhtodau.SelectedIndexChanged += (s, e) => UpdatePriceDisplay(pricesinhtodau, sizesinhtodau, 30000);
            sizesinhtobo.SelectedIndexChanged += (s, e) => UpdatePriceDisplay(pricesinhtobo, sizesinhtobo, 30000);
            sizeepcam.SelectedIndexChanged += (s, e) => UpdatePriceDisplay(priceepcam, sizeepcam, 15000);
            sizeepcarot.SelectedIndexChanged += (s, e) => UpdatePriceDisplay(priceepcarot, sizeepcarot, 15000);
            sizeepoi.SelectedIndexChanged += (s, e) => UpdatePriceDisplay(priceepoi, sizeepoi, 15000);
            sizeepduahau.SelectedIndexChanged += (s, e) => UpdatePriceDisplay(priceepduahau, sizeepduahau, 15000);
            sizeduongden.SelectedIndexChanged += (s, e) => UpdatePriceDisplay(priceduongden, sizeduongden, 35000);
            sizematcha.SelectedIndexChanged += (s, e) => UpdatePriceDisplay(pricematcha, sizematcha, 35000);
        }


        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            if (cartItems.Count > 0)
            {
                dataGridView1.DataSource = cartItems;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}
