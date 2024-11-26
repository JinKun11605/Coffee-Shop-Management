using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;

namespace CoffeeShopManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioManager.CheckedChanged += RadioButton_CheckedChanged;
            radioBarista.CheckedChanged += RadioButton_CheckedChanged;
            radioCustomer.CheckedChanged += RadioButton_CheckedChanged;

            txtID.PlaceholderText = "Tài khoản";
            txtID.PlaceholderForeColor = Color.Gray;
            txtID.TextOffset = new Point(10, 0);


            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.PlaceholderForeColor = Color.Gray;
            txtPassword.PasswordChar = '●';
            txtPassword.TextOffset = new Point(10, 0);

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            string imagePath = "";

            if (rb == radioManager)
            {
                imagePath = @"manager-icon.png";
            }
            else if (rb == radioBarista)
            {
                imagePath = @"barista-icon.png";
            }
            else if (rb == radioCustomer)
            {
                imagePath = @"customer-icon.png";
            }
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureOption.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show($"Không tìm thấy ảnh: {imagePath}");
            }
        }


        public bool IsAuthenticated(string id, string password, string role)
        {
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

            if (role == "Customer")
            {
                var customer = db.Customers.FirstOrDefault(u => u.CustomerID == id && u.Password == password);
                return customer != null;
            }

            var employee = db.Employees.FirstOrDefault(u => u.EmployeeID == id && u.Password == password && u.Role == role);
            return employee != null;
        }

        public void ToForm(string id, string role)
        {
            if (role == "Manager")
            {
                var formManager = new frmManager(id);
                formManager.Show();
            }
            else if (role == "Barista")
            {
                var formBarista = new frmBaristaInfo(id);
                formBarista.Show();
            }
            else if (role == "Customer")
            {
                var formCustomer = new frmCustomerInfo(id);
                formCustomer.Show();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = "";

            if (!radioManager.Checked && !radioBarista.Checked && !radioCustomer.Checked)
            {
                MessageBox.Show("Vui lòng chọn vai trò!");
                return;
            }

            if (radioManager.Checked)
            {
                role = "Manager";
            }
            else if (radioBarista.Checked)
            {
                role = "Barista";
            }
            else if (radioCustomer.Checked)
            {
                role = "Customer";
            }

            if (IsAuthenticated(id, password, role))
            {
                MessageBox.Show($"Đăng nhập thành công với tư cách {role}");
                ToForm(id, role);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, kiểm tra lại Tên đăng nhập hoặc Mật khẩu!");
            }
            this.Hide();
        }

        private void piutureGuest_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu("GUEST");
            frm.Show();
        }

        private void pictureEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }
    }
}