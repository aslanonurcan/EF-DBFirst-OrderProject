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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();

        }
        NorthwindEntitiesConnectionString db = DbSingleTone.GetInstance();
       
        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbCustomers.SelectedIndex != 0)//cmbCustomers'ta seçili bir değer varsa 
            {
                try
                {
                    Customer secilenCustomer = db.Customers.Find(cmbCustomers.SelectedValue);
                    txtBoxAddress.Text = secilenCustomer.Address;
                    txtBoxCountry.Text = secilenCustomer.City + " " + secilenCustomer.Country;
                }
                catch (Exception)
                {
                    MessageBox.Show("HATA VAR");

                }
            }



        }
        private void Doldur()
        {
            //var clist = db.Customers.Select(x => new
            //{
            //    x.CustomerID,
            //    x.CompanyName
            //}).ToList();
            // yukarıda list oluşturursak istediğimiz kolonları seçeriz.
            //Eğer oluşturmayıp aşağıdaki gibi direk çağırırsak Select*From gibi davranır.
            
            cmbCustomers.DisplayMember = "CompanyName";
            cmbCustomers.ValueMember = "CustomerID";
            cmbCustomers.DataSource = db.Customers.ToList();//ToList() kesin yazmamız lazım yazmazsak comboboxta göstermez.

            var elist = db.Employees.Select(x => new
            {
                FullName = x.FirstName + " " + x.LastName,
                x.EmployeeID
            }).ToList();

           
            cmbEmployees.DisplayMember = "FullName";
            cmbEmployees.ValueMember = "EmployeeID";
            cmbEmployees.DataSource = elist;

            var shlist = db.Shippers.Select(x => new
            {
                x.CompanyName,
                x.ShipperID

            }).ToList();

            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.DataSource = shlist;


        }
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            Order orders = new Order();//Order entity'sinden orders adında bir instance aldık.
            orders.CustomerID = cmbCustomers.SelectedValue.ToString();
            orders.EmployeeID = (int)cmbEmployees.SelectedValue;
            orders.OrderDate = dtpOrderDate.Value;
            orders.RequiredDate = dtpRequiredDate.Value;
            orders.ShipVia = (int)cmbShipVia.SelectedValue;
            orders.Freight = Convert.ToDecimal(txtFreight.Text);
            db.Orders.Add(orders);// aldığımız orders instance'sını Orders Facade'ına ekledik.
            db.SaveChanges();//yapılan değişiklikler database'e de işlenir.
            

            FormOrderHeaderDetail frmOrderHeaderDetail = new FormOrderHeaderDetail(orders.OrderID);
            frmOrderHeaderDetail.Show();
            this.Hide(); //Bir sonraki forma geçince bu formu kapatır.

        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
