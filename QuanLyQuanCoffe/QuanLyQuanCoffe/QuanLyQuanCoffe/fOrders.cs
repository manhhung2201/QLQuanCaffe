
using QuanLyQuanCoffe.Models;
using QuanLyQuanCoffe.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using QuanLyQuanCoffe.user_controls.Orderf;

namespace QuanLyQuanCoffe
{
    public partial class fOrders : Form
    {
        private Account CurrentSession;

        public fOrders()
        {
        }

        private List<Promotion> listPromo;
        public fOrders(Models.Account session)
        {
            InitializeComponent();
            CurrentSession = session;
            string currentSessionUserDisplay = AccountDAO.Instance.GetNameFromID(CurrentSession.IdEmployee);
            txtSessionUser.Text = currentSessionUserDisplay;
            flowLayoutPanelFoodMenu.Controls.Clear();
            Thread.CurrentThread.CurrentCulture = (new CultureInfo("vi-VN"));

            listPromo = PromotionDAO.Instance.GetListPromotionAvailable();
            listPromo.Insert(0, new Promotion("Không", new DateTime(1990, 01, 01), new DateTime(1990, 01, 02), "Không áp dụng giảm giá", 0));
            cbxPromo.DataSource = listPromo;
            cbxPromo.DisplayMember = "idPromo";
            flowLayoutPanelFoodMenu.Controls.Clear();
            loadAllFood();
            
        }
        void loadAllFood()
        {
            List<Food> AllFood = FoodDAO.Instance.GetListFood();
            foreach (Food item in AllFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;

            }
        }
        void order_Click(object sender, EventArgs e)
        {
            ItemStandbyOrder t = new ItemStandbyOrder((sender as Button).Tag as Food);
            int id = ((sender as Button).Tag as Food).ID;
            t.Name = "OrderOf" + id.ToString();
            
            t.btnDown.Click += new EventHandler(calcTotalPay);
            t.btnUp.Click += new EventHandler(calcTotalPay);

            if (!flowLayoutPanelOrderList.Controls.ContainsKey(t.Name))
            {
                flowLayoutPanelOrderList.Controls.Add(t);
                calcTotalPay(sender, e);
            }



        }
        private void calcTotalPay(object sender, EventArgs e)
        {
            float pay = 0;

            Control.ControlCollection controlsarr = flowLayoutPanelOrderList.Controls;
            foreach (Control t in controlsarr)
            {
                pay += Int32.Parse((t as ItemStandbyOrder).txtAmount.Text) * Int32.Parse((t as ItemStandbyOrder).itemPrice.Text);

            }
            this.LabelTotal.Text = pay.ToString("c", new CultureInfo("vi-VN"));
        }
        private void ButtonCalculateChange_Click(object sender, EventArgs e)
        {
            string temp = LabelTotal.Text.Replace(",00 ₫", string.Empty);
            temp = temp.Replace(".", string.Empty);
            string discount = PromoAmount.Text.Replace("-", string.Empty);
            decimal changeMon = CustomerPayment.Value - (decimal)Int32.Parse(temp) + (decimal)Int32.Parse(discount);
            if ((decimal)Int32.Parse(temp) < (decimal)Int32.Parse(discount))
            {
                LabelChange.Text = CustomerPayment.Value.ToString("c", new CultureInfo("vi-VN"));
                return;
            }
            if (changeMon < 0)
            {
                MessageBox.Show("Tiền trả nhỏ hơn lượng cần thanh toán!");
                LabelChange.Text = 0.ToString("c", new CultureInfo("vi-VN"));
            }
            else
            {
                LabelChange.Text = changeMon.ToString("c", new CultureInfo("vi-VN"));
            }

        }
        private void ButtonProccess_Click(object sender, EventArgs e)
        {
            ButtonCalculateChange_Click(sender, e);
            Control.ControlCollection controlsarr = flowLayoutPanelOrderList.Controls;
            if (controlsarr.Count == 0)
            {
                MessageBox.Show("Order trống!", "Thông báo", MessageBoxButtons.OKCancel);

            }
            else
            {
                if (MessageBox.Show("Bạn muốn thanh toán và xuất hoá đơn?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    string temp = LabelTotal.Text.Replace(",00 ₫", string.Empty);
                    temp = temp.Replace(".", string.Empty);
                    string discount = PromoAmount.Text.Replace("-", string.Empty);
                    decimal changeMon = CustomerPayment.Value - (decimal)Int32.Parse(temp) + (decimal)Int32.Parse(discount);
                    if (changeMon < 0)
                    {
                        MessageBox.Show("Tiền trả nhỏ hơn lượng cần thanh toán!");
                        LabelChange.Text = 0.ToString("c", new CultureInfo("vi-VN"));
                    }
                    else
                    {
                        List<Order> listConfirmed = new List<Order>();

                        int price;
                        if ((CustomerPayment.Value - changeMon) < 0)
                        {
                            price = 0;
                        }
                        else
                        {
                            price = Int32.Parse((CustomerPayment.Value - changeMon).ToString());
                        }


                        BillDAO.Instance.InsertBill(CurrentSession.IdEmployee, listPromo[cbxPromo.SelectedIndex].IdPromo.ToString(), price);

                        foreach (Control t in controlsarr)
                        {
                            ItemStandbyOrder StandbyOrder = (t as ItemStandbyOrder);

                            BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), StandbyOrder.item.ID, Int32.Parse(StandbyOrder.txtAmount.Text));

                            listConfirmed.Add(new Order(StandbyOrder.item.Name, StandbyOrder.item.Price, Int32.Parse(StandbyOrder.txtAmount.Text)));

                        }


                        //fProcessOrder fPO = new fProcessOrder(listConfirmed, CurrentSession.IdEmployee, CustomerPayment.Value.ToString("c", new CultureInfo("vi-VN")), LabelChange.Text.ToString(), BillDAO.Instance.GetTimebyIDBill(BillDAO.Instance.GetMaxIDBill()), PromoAmount.Text, listPromo[cbxPromo.SelectedIndex].IdPromo.ToString());
                        //fPO.ShowDialog();

                    }
                }
            }



        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fChangePassword f = new fChangePassword(CurrentSession);
            f.ShowDialog();

        }
        #region handleFoodLoad
        private void btnCafeMay_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnCafeMay.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btnhongtra_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btnhongtra.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btntrasua_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btntrasua.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btncake_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btncake.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }

        private void btncafevietnam_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFoodMenu.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(CategoryDAO.Instance.GetCategoryIDFromName(btncafevietnam.Text));
            foreach (Food item in listFood)
            {
                ItemOrder t = new ItemOrder(item);
                flowLayoutPanelFoodMenu.Controls.Add(t);
                t.btnAdd.Click += new EventHandler(order_Click);
                t.btnAdd.Tag = item;
            }
        }
        #endregion
    }



}
