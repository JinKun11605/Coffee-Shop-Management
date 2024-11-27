using CoffeeShopManagement;
using ProjectOOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoffeeShopManagement
{
    public partial class frmBaristaMixing : UserControl
    {
        CoffeeShopDBDataContext context = new CoffeeShopDBDataContext();

        private List<Tuple<CheckBox, ComboBox, NumericUpDown>> Items;

        private List<Recipe> recipes;

        private string BaristaID;

        private Boolean update = false;
        public frmBaristaMixing(string baristaID)
        {
            InitializeComponent();
            LoadData();
            BaristaID = baristaID;
            lblBaristaID.Text += BaristaID;
            Items = new List<Tuple<CheckBox, ComboBox, NumericUpDown>>
            {
                Tuple.Create(DRK001, sizeDRK001, quantityDRK001),
                Tuple.Create(DRK002, sizeDRK002, quantityDRK002),
                Tuple.Create(DRK003, sizeDRK003, quantityDRK003),
                Tuple.Create(DRK004, sizeDRK004, quantityDRK004),
                Tuple.Create(DRK005, sizeDRK005, quantityDRK005),
                Tuple.Create(DRK006, sizeDRK006, quantityDRK006),
                Tuple.Create(DRK007, sizeDRK007, quantityDRK007),
                Tuple.Create(DRK008, sizeDRK008, quantityDRK008),
                Tuple.Create(DRK009, sizeDRK009, quantityDRK009),
                Tuple.Create(DRK010, sizeDRK010, quantityDRK010)
            };

            recipes = new List<Recipe>
            {
                new Recipe("DRK001M", new Dictionary<string, int>
                {
                    { "Cà phê", 50 },
                    { "Đá", 200 }
                }),
                new Recipe("DRK001L", new Dictionary<string, int>
                {
                    { "Cà phê", 75 },
                    { "Đá", 300 }
                }),
                new Recipe("DRK001XL", new Dictionary<string, int>
                {
                    { "Cà phê", 100 },
                    { "Đá", 400 }
                }),

                new Recipe("DRK002M", new Dictionary<string, int>
                {
                    { "Cà phê", 50 },
                    { "Sữa đặc", 30 },
                    { "Đường", 10 },
                    { "Đá", 200 }
                }),
                new Recipe("DRK002L", new Dictionary<string, int>
                {
                    { "Cà phê", 75 },
                    { "Sữa đặc", 45 },
                    { "Đường", 15 },
                    { "Đá", 300 }
                }),
                new Recipe("DRK002XL", new Dictionary<string, int>
                {
                    { "Cà phê", 100 },
                    { "Sữa đặc", 60 },
                    { "Đường", 20 },
                    { "Đá", 400 }
                }),

                new Recipe("DRK003M", new Dictionary<string, int>
                {
                    { "Cam", 200 },
                    { "Đường", 10 },
                    { "Đá", 150 }
                }),
                new Recipe("DRK003L", new Dictionary<string, int>
                {
                    { "Cam", 300 },
                    { "Đường", 15 },
                    { "Đá", 225 }
                }),
                new Recipe("DRK003XL", new Dictionary<string, int>
                {
                    { "Cam", 400 },
                    { "Đường", 20 },
                    { "Đá", 300 }
                }),

                new Recipe("DRK004M", new Dictionary<string, int>
                {
                    { "Cà rốt", 200 },
                    { "Đường", 10 },
                    { "Đá", 200 }
                }),
                new Recipe("DRK004L", new Dictionary<string, int>
                {
                    { "Cà rốt", 300 },
                    { "Đường", 15 },
                    { "Đá", 300 }
                }),
                new Recipe("DRK004XL", new Dictionary<string, int>
                {
                    { "Cà rốt", 400 },
                    { "Đường", 20 },
                    { "Đá", 400 }
                }),

                new Recipe("DRK005M", new Dictionary<string, int>
                {
                    { "Ổi", 100 },
                    { "Đường", 10 },
                    { "Đá", 150 }
                }),
                new Recipe("DRK005L", new Dictionary<string, int>
                {
                    { "Ổi", 150 },
                    { "Đường", 15 },
                    { "Đá", 225 }
                }),
                new Recipe("DRK005XL", new Dictionary<string, int>
                {
                    { "Ổi", 200 },
                    { "Đường", 20 },
                    { "Đá", 300 }
                }),

                new Recipe("DRK006M", new Dictionary<string, int>
                {
                    { "Dưa hấu", 200 },
                    { "Đường", 10 },
                    { "Đá", 150 }
                }),
                new Recipe("DRK006L", new Dictionary<string, int>
                {
                    { "Dưa hấu", 300 },
                    { "Đường", 15 },
                    { "Đá", 225 }
                }),
                new Recipe("DRK006XL", new Dictionary<string, int>
                {
                    { "Dưa hấu", 400 },
                    { "Đường", 20 },
                    { "Đá", 300 }
                }),

                new Recipe("DRK007M", new Dictionary<string, int>
                {
                    { "Dâu", 100 },
                    { "Sữa đặc", 50 },
                    { "Sữa tươi", 100 },
                    { "Đường", 20 },
                    { "Đá", 150 }
                }),
                new Recipe("DRK007L", new Dictionary<string, int>
                {
                    { "Dâu", 150 },
                    { "Sữa đặc", 75 },
                    { "Sữa tươi", 150 },
                    { "Đường", 30 },
                    { "Đá", 225 }
                }),
                new Recipe("DRK007XL", new Dictionary<string, int>
                {
                    { "Dâu", 200 },
                    { "Sữa đặc", 100 },
                    { "Sữa tươi", 200 },
                    { "Đường", 40 },
                    { "Đá", 300 }
                }),

                new Recipe("DRK008M", new Dictionary<string, int>
                {
                    { "Bơ", 100 },
                    { "Sữa đặc", 50 },
                    { "Sữa tươi", 100 },
                    { "Đường", 20 },
                    { "Đá", 150 }
                }),
                new Recipe("DRK008L", new Dictionary<string, int>
                {
                    { "Bơ", 150 },
                    { "Sữa đặc", 75 },
                    { "Sữa tươi", 150 },
                    { "Đường", 30 },
                    { "Đá", 225 }
                }),
                new Recipe("DRK008XL", new Dictionary<string, int>
                {
                    { "Bơ", 200 },
                    { "Sữa đặc", 100 },
                    { "Sữa tươi", 200 },
                    { "Đường", 40 },
                    { "Đá", 300 }
                }),

                new Recipe("DRK009M", new Dictionary<string, int>
                {
                    { "Sữa tươi", 100 },
                    { "Đường", 50 },
                    { "Chân châu", 50 },
                    { "Đá", 150 }
                }),
                new Recipe("DRK009L", new Dictionary<string, int>
                {
                    { "Sữa tươi", 150 },
                    { "Đường", 75 },
                    { "Chân châu", 75 },
                     { "Đá", 225 }
                }),
                new Recipe("DRK009XL", new Dictionary<string, int>
                {
                    { "Sữa tươi", 200 },
                    { "Đường", 100 },
                    { "Chân châu", 100 },
                    { "Đá", 300 }
                }),

                new Recipe("DRK010M", new Dictionary<string, int>
                {
                    { "Matcha", 150 },
                    { "Sữa tươi", 100 },
                    { "Đường", 20 },
                    { "Chân châu", 50 },
                    { "Đá", 150 }
                }),
                new Recipe("DRK010L", new Dictionary<string, int>
                {
                    { "Matcha", 225 },
                    { "Sữa tươi", 150 },
                    { "Đường", 30 },
                    { "Chân châu", 75 },
                     { "Đá", 225 }
                }),
                new Recipe("DRK010XL", new Dictionary<string, int>
                {
                    { "Matcha", 300 },
                    { "Sữa tươi", 200 },
                    { "Đường", 40 },
                    { "Chân châu", 100 },
                    { "Đá", 300 }
                })
            };


        }

        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!Items.Any(cb => cb.Item1.Checked))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một mục để pha chế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var cb in Items)
            {

                if (cb.Item1.Checked && cb.Item2.SelectedItem != null)
                {
                    CheckBox id = cb.Item1;
                    ComboBox size = cb.Item2;
                    NumericUpDown quantity = cb.Item3;

                    string productID = id.Name + size.SelectedItem.ToString();
                    substractIngredient(productID, (int)quantity.Value);
                    if (update == false) return;
                    var product = context.Products.FirstOrDefault(p => p.ProductID == productID);
                    product.Quantity += (int)quantity.Value;


                    id.Checked = false;
                    size.SelectedIndex = -1;
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var products = context.Products
                             .Select(p => new
                             {
                                 ProductID = p.ProductID,
                                 ProductName = p.ProductName,
                                 Quantity = p.Quantity
                             })
                             .ToList();
                dataGridView1.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                var ingredient = context.Inventories
                                .Select(p => new
                                {
                                    IngredientName = p.IngredientName,
                                    Quantity = p.Quantity
                                })
                                .ToList();

                dataGridView2.DataSource = ingredient;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void substractIngredient(string productID, int count)
        {
            foreach (var repice in recipes)
            {
                if (repice.ProductID == productID)
                {
                    foreach (var ingredient in repice.Igredients)
                    {
                        var ingredients = context.Inventories.FirstOrDefault(p => p.IngredientName == ingredient.Key);
                        int totalRequired = count * ingredient.Value;
                        if (totalRequired > ingredients.Quantity)
                        {
                            MessageBox.Show($"Nguyên liệu '{ingredient.Key}' không đủ.\nYêu cầu: {totalRequired}\nCó: {ingredients.Quantity}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            update = false;
                            return;
                        }
                        ingredients.Quantity -= totalRequired;
                    }
                }
            }
            context.SubmitChanges();
            update = true;
        }
    }
}
