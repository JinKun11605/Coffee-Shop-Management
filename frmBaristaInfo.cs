using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{

    public partial class frmBaristaInfo : UserControl
    {
        private string baristaID;
        public string BaristaID { get => baristaID; set => baristaID = value; }
        public frmBaristaInfo(string baristaID)
        {
            InitializeComponent();
            BaristaID = baristaID;
        }

        private void frmBaristaInfo_Load(object sender, EventArgs e)
        {
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

            var barista = db.Baristas.FirstOrDefault(em => em.BaristaID == BaristaID);

            lblShowFullName.Text = barista.FullName;
            lblShowBirthDay.Text = barista.BirthDay.ToString("dd/MM/yyyy");
            lblShowHireDay.Text = barista.HireDay.ToString("dd/MM/yyyy");
            lblShowPhoneNumber.Text = barista.PhoneNumber;
            lblShowSalary.Text = barista.Salary.ToString();
            lblShowYoW.Text = barista.YoE.ToString();

            lblShowID.Text = barista.BaristaID;
            lblShowPassword.Text = barista.Password;

            if (barista.Image != null)
            {
                try
                {
                    MemoryStream ms = new MemoryStream(barista.Image.ToArray());
                    pictureManager.Image = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi:" + ex.Message);
                }
            }
            else
            {
                pictureManager.Image = null;
            }

            var baristaInfo = new BaristaInfo(barista.BaristaID, barista.Password, barista.FullName, barista.BirthDay, barista.PhoneNumber, barista.HireDay, barista.YoE, barista.Salary);
            MessageBox.Show($"{baristaInfo.PrintDetails()}", "THÔNG TIN NHÂN VIÊN PHA CHẾ");
        }

        private void btnBartending_Click(object sender, EventArgs e)
        {
            frmBaristaMixing frmBaristaUpdate = new frmBaristaMixing(baristaID);
            frmBaristaUpdate.Show();
        }
    }
}
