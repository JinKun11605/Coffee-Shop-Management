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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                var formManager = new frmManagerInfo(id);
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

        }
    }
}