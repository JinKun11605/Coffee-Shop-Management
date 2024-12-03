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
    public partial class frmReportSales : UserControl
    {
        public frmReportSales()
        {
            InitializeComponent();
        }

        private void frmReportSales_Load(object sender, EventArgs e)
        {

        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStartTime.Value;
            DateTime end = dtpEndTime.Value;
            if (start > end)
            {
                MessageBox.Show("Vui lòng chon ngày hợp lệ");
                return;
            }
            ManagerInfo managerInfo = new ManagerInfo();
            Decimal TotalIncom = managerInfo.GetTotalSales(start, end) ;        
            lblDoanhThu.Text = $"{TotalIncom.ToString("N0")} VND";

        }
    }
}
