using CoffeeShopManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class frmInventory : UserControl
    {
        CoffeeShopDBDataContext context = new CoffeeShopDBDataContext();

        private List<Tuple<CheckBox, NumericUpDown>> Items;
        public frmInventory()
        {
            InitializeComponent();
            LoadData();
            Items = new List<Tuple<CheckBox, NumericUpDown>>
            {
                Tuple.Create(ID001, quantityID001),
                Tuple.Create(ID002, quantityID002),
                Tuple.Create(ID003, quantityID003),
                Tuple.Create(ID004, quantityID004),
                Tuple.Create(ID005, quantityID005),
                Tuple.Create(ID006, quantityID006),
                Tuple.Create(ID007, quantityID007),
                Tuple.Create(ID008, quantityID008),
                Tuple.Create(ID009, quantityID009),
                Tuple.Create(ID010, quantityID010),
                Tuple.Create(ID011, quantityID011),
                Tuple.Create(ID012, quantityID012),
                Tuple.Create(ID013, quantityID013)
            };

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!Items.Any(cb => cb.Item1.Checked))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một mục để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            foreach (var cb in Items)
            {

                if (cb.Item1.Checked)
                {
                    CheckBox id = cb.Item1;
                    NumericUpDown quantity = cb.Item2;

                    string ingredientID = id.Name;

                    var inventory = context.Inventories.FirstOrDefault(p => p.IngredientID == ingredientID);
                    inventory.Quantity += (int)quantity.Value;
                    id.Checked = false;
                    quantity.Value = 0;
                }
            }
            try
            {
                context.SubmitChanges();
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu thay đổi: " + ex.Message);
            }
        }


       
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            try
            {
                var inventory = context.Inventories.ToList();
                dataGridView1.DataSource = inventory;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}