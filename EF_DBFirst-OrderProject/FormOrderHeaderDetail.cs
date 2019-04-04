using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EF_DBFirst_OrderProject
{
    
    public partial class FormOrderHeaderDetail : Form
    {
        NorthwindEntitiesConnectionString db = DbSingleTone.GetInstance();
        //Global tanımlandı


        private int gelenOrderID;//diğer formdan gelecek secilenOrderID'ye eşitleyip bu formda kullanmak için
        private Order gelenOrder;// Order entitysinin içindeki alanlara erişebilmemiz için
        private Order_Detail secilenOrderDet;//datagridviewda bi yeri seçtiğimizde o satırdaki kayıtları ilgili textbox,comboboxlarda gösterebilmek için kullanıcaz
        private int secilenProductID;       //ProductID ve Quantity için

        //*******************************************************************************

        //Panelin üst kısmı header, alt kısmı detail kısmı...

        //*********************************************************************************
        public FormOrderHeaderDetail()
        {
            InitializeComponent();
        }

        public FormOrderHeaderDetail(int secilenOrderID) //formlar arası veri gönderme için parametre yöntemini kullandık
        {                                                //Bunun için constractor içinde parametre verdik
            InitializeComponent();
            gelenOrderID = secilenOrderID;
            gelenOrder = db.Orders.Find(gelenOrderID);
            //Find ile entity buluyor.
            //Orders facade'ından gelenOrderID numaralı sipariş numarasını gelenOrder değişkenine atadık.
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {//Header alanında Güncelleme yapmak için
            gelenOrder.CustomerID = cmbCustomers.SelectedValue.ToString();
            gelenOrder.EmployeeID = (int)cmbEmployees.SelectedValue;
            gelenOrder.OrderDate = dtpOrderDate.Value;
            gelenOrder.RequiredDate = dtpRequiredDate.Value;
            gelenOrder.ShipVia = (int)cmbShipVia.SelectedValue;
            gelenOrder.Freight = Convert.ToDecimal(txtFreight.Text);

            db.SaveChanges();//Yapılan değişiklikleri gidip database'e işler.
            OrderDoldur();
            ComboDoldur();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.Orders.Remove(gelenOrder);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                //Verilerin bağlantılı olduğu diğer verileri de (diğer tablolarda) siler.
                //Böylelikle referential integrity(veri bütünlüğü) sağlanmış olur.
            }
            catch (Exception)
            {

                MessageBox.Show("Detayları silin");
            }
        }

        private void btnUpdateDet_Click(object sender, EventArgs e)
        {//Detail alanında Güncelleme yapmak için
            //TextBoxlara girilen değerlere göre butona tıkladığımızda güncelleme yapar.

            db.Order_Details.Remove(secilenOrderDet);
            //Önce secilen satırdaki hepsini temizler.
            Order_Detail od = new Order_Detail();
            od.OrderID = Convert.ToInt32(txtBoxOrderID.Text);
            od.ProductID = (int)cmbBoxProducts.SelectedValue;
            od.Quantity = Convert.ToInt16(txtBoxQuantity.Text);

            Product p = db.Products.Find(od.ProductID);
            od.UnitPrice = (decimal)p.UnitPrice;
            db.Order_Details.Add(od);
            od.Discount = 0;
            //Güncelleme yaptığımızda yeni isimli veya miktarlı ürünün indirimini(discount) 0 yaptık.
            db.SaveChanges();
            OrderDetDoldur();
            MessageBox.Show("Güncelleme Başarılı");

        }

        private void btnDeleteDet_Click(object sender, EventArgs e)
        {//datagridviewda secilen sipariş detay bilgilerini  silmek için
            db.Order_Details.Remove(secilenOrderDet);
            db.SaveChanges();
            OrderDetDoldur();
        }

        private void btnInsertDet_Click(object sender, EventArgs e)
        {//Sipariş bilgilerini eklemek için

            Order_Detail od = new Order_Detail();
            od.OrderID = Convert.ToInt32(txtBoxOrderID.Text);
            od.ProductID = (int)cmbBoxProducts.SelectedValue;
            od.Quantity = Convert.ToInt16(txtBoxQuantity.Text);

            Product p = db.Products.Find(od.ProductID);
            od.UnitPrice = (decimal)p.UnitPrice;
            db.Order_Details.Add(od);
            od.Discount = 0;
            //Güncelleme yaptığımızda yeni isimli veya miktarlı ürünün indirimini(discount) 0 yaptık.
            db.SaveChanges();
            OrderDetDoldur();
        }

        private void FormOrderHeaderDetail_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            OrderDoldur();
            OrderDetDoldur();
        }
        private void ComboDoldur()
        {
            //****************cmbCustomers için******************
            var clist = db.Customers.Select(x => new
            {
                x.CustomerID,
                x.CompanyName
            }).ToList();

            cmbCustomers.SelectedValue = gelenOrder.CustomerID;
            cmbCustomers.DisplayMember = "CompanyName";
            cmbCustomers.ValueMember = "CustomerID";
            cmbCustomers.DataSource = clist;
            //ekran açıldığı gibi gelenOrder'ın OrderId'sine göre Customer-CompanyName- getirecek
            //***************************************************************************************


            //******************cmbEmployees icin**********************
            var elist = db.Employees.Select(x => new
            {
                FullName = x.FirstName + x.LastName,
                x.EmployeeID
            }).ToList();

            cmbEmployees.DataSource = elist;
            cmbEmployees.DisplayMember = "FullName";
            cmbEmployees.ValueMember = "EmployeeID";
            cmbEmployees.SelectedValue = gelenOrder.EmployeeID;
            //******************************************************************************************

            //*******************cmbShipVia için************************
            var shlist = db.Shippers.ToList();
            cmbShipVia.DataSource = shlist;
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.SelectedValue = gelenOrder.ShipVia;
            //********************************************************************************************
        }

        private void OrderDoldur()
        {//girilen sipariş numarasına [gelenOrderID'ye(secilenOrderID)] göre ilgili textBoxları ve comboboxları doldurmak için
            txtBoxOrderID.Text = gelenOrderID.ToString();
            txtFreight.Text = gelenOrder.Freight.ToString();
            txtBoxAddress.Text = gelenOrder.Customer.Address;
            txtBoxCountry.Text = gelenOrder.Customer.City + " " + gelenOrder.Customer.Country;
            dtpOrderDate.Value = gelenOrder.OrderDate.Value;
            dtpRequiredDate.Value = gelenOrder.RequiredDate.Value;
        }

        private void OrderDetDoldur()
        { //OrderDetail için oluşturdu. 

            //----------------------Total Amount TextBoxı için---------------------------------
            var odList = db.Order_Details.Select(x => new
            {
                x.OrderID,
                x.ProductID,
                x.Product.ProductName,
                x.UnitPrice,
                x.Quantity,
                x.Discount,
                Total = x.Quantity + x.UnitPrice
            }).Where(x => x.OrderID == gelenOrderID).ToList();

            txtBoxTotalAmount.Text = odList.Sum(x => x.Total).ToString();
            dataGridView1.DataSource = odList;



            var plist = db.Products.Select(x => new
            {
                x.ProductID,
                x.ProductName
            }).ToList();

            cmbBoxProducts.DataSource = plist;
            cmbBoxProducts.DisplayMember = "ProductName";
            cmbBoxProducts.ValueMember = "ProductID";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dataGridviewda bir yere tıkladığımız zaman tıkladığımız kaydın ProductName'ini cmbBoxProducts'ta, miktarını
            //txtBoxQuantity'de gösterir. *********************************************************************************
            secilenProductID = (int)dataGridView1.CurrentRow.Cells[1].Value;
            secilenOrderDet = db.Order_Details.Find(gelenOrderID, secilenProductID);
            txtBoxQuantity.Text = secilenOrderDet.Quantity.ToString();
            cmbBoxProducts.SelectedValue = secilenProductID;

        }
    }
}
