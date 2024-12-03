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
    public partial class frmCheckout : Form
    {
        CoffeeShopDBDataContext context = new CoffeeShopDBDataContext();

        List<OrderDetails> orders;
        string CustemerID;
        CustomerInfo customerInfo = new CustomerInfo();
        public frmCheckout(List<OrderDetails> cartItems, string custemerID)
        {
            InitializeComponent();
            dataGridViewBill.DataSource = cartItems; //hien thị
            orders = cartItems;
            CustemerID = custemerID;
            lblCustemerID.Text += CustemerID;
        }
        private decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (var item in orders)
            {
                total += item.Price * item.Quantity;
            }

            return total;
        }
        private void frmCheckout_Load(object sender, EventArgs e)
        {
            decimal totalAmount = CalculateTotal();
            btnconfirm.Text = $"{totalAmount.ToString("N0")} VND";
            SetupPictureBoxes();

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            List<OrderDetail> sanPhamList = orders.Select(order => Convert(order)).ToList();

            Order neworder = new Order();
            neworder.OrderDate = DateTime.Now;
            neworder.Rating = 0;
            neworder.TotalAmount = CalculateTotal();
            neworder.CustomerID = CustemerID;
            neworder.Rating = currentRating;
            context.Orders.InsertOnSubmit(neworder);
            context.SubmitChanges();


            foreach (var item in sanPhamList)
            {
                var product = context.Products.FirstOrDefault(p => p.ProductID == item.ProductID);
                product.Quantity -= item.Quantity;

                item.OrderID = neworder.OrderID;
                context.OrderDetails.InsertOnSubmit(item);
            }
            context.SubmitChanges();

            
            customerInfo.HandlePaymnent(CalculateTotal());

            btnconfirm.Text = "Thanh toán thành công";
            dataGridViewBill.DataSource = null;
            orders.Clear();
            btnconfirm.Enabled = false;
            this.Close();
        }


        private OrderDetail Convert(OrderDetails orderdetails)
        {
            return new OrderDetail
            {
                ProductID = orderdetails.ProductID,
                ProductName = orderdetails.ProductName,
                Price = orderdetails.Price,
                Quantity = orderdetails.Quantity,
                Size = orderdetails.Size,

            };
        }

        private void Thanhtoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridViewBill.DataSource = null;
            orders.Clear();
        }

        private int currentRating = 0;
        private void SetupPictureBoxes()
        {
            Star1.MouseEnter += pictureBox_MouseEnter;
            Star2.MouseEnter += pictureBox_MouseEnter;
            Star3.MouseEnter += pictureBox_MouseEnter;
            Star4.MouseEnter += pictureBox_MouseEnter;
            Star5.MouseEnter += pictureBox_MouseEnter;

            Star1.MouseLeave += pictureBox_MouseLeave;
            Star2.MouseLeave += pictureBox_MouseLeave;
            Star3.MouseLeave += pictureBox_MouseLeave;
            Star4.MouseLeave += pictureBox_MouseLeave;
            Star5.MouseLeave += pictureBox_MouseLeave;

            Star1.Click += pictureBox_Click;
            Star2.Click += pictureBox_Click;
            Star3.Click += pictureBox_Click;
            Star4.Click += pictureBox_Click;
            Star5.Click += pictureBox_Click;

            ResetStars();
        }
        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox hoveredPictureBox = sender as PictureBox;
            int hoveredIndex = int.Parse(hoveredPictureBox.Name.Replace("Star", ""));
            for (int i = 1; i <= hoveredIndex; i++)
            {
                PictureBox pb = (PictureBox)this.Controls["Star" + i];
                pb.Image = new Bitmap(@"star.jpg"); //"C:\Users\dinhv\OneDrive\Downloads\CoffeeShopManagement\bin\Debug\Resources\star.jpg"
            }
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            UpdateStars();
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            currentRating = int.Parse(clickedPictureBox.Name.Replace("Star", ""));
            UpdateStars();
        }

        private void UpdateStars()
        {
            for (int i = 1; i <= 5; i++)
            {
                PictureBox pb = (PictureBox)this.Controls["Star" + i];
                if (i <= currentRating)
                {
                    pb.Image = new Bitmap(@"star.jpg");
                }
                else
                {
                    pb.Image = null;
                }
            }
        }
        private void ResetStars()
        {
            currentRating = 0;
            UpdateStars();
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {

            customerInfo.FeedBack(currentRating, txtFeedback);
            btnSendFeedback.Enabled = false;
            Star1.Enabled = false;
            Star2.Enabled = false;
            Star3.Enabled = false;
            Star4.Enabled = false;
            Star5.Enabled = false;
            txtFeedback.Enabled = false;

        }


    }
}

