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
    /*
    Siparişler MenuStrip'inde Sipariş Girişe tıkladığımız zaman FormGiris form sayfası açılacak.
    Bu açılan sayfada sıfırdan bir Order oluşturulabilecek.
    Sipariş Düzeltme/Görüntüleme dediğimizde flowLayoutPanel1 içinde label,button ve textbox belirecek. Buradan var olan bir sipariş numarası girilip 
    Siparişi aç butonuna tıklandığında eğer sipariş numarası veritabanında yoksa "BULUNAMADI" diye mesaj verecek, varsa FormOrderHeaderDetail form sayfası açılacak.
    Açılan bu form sayfasında girilen OrderID'ye göre ilgili comboBoxlar ve TextBoxlara sipariş bilgileri dolacak ve sipariş bilgileri bir tablo halinde 
    alttaki dataGridView1'de görünecek.
    Burada panelin üzerinde sipariş için silme ve güncelleme işlemleri, panelin altında da o siparişe ait detay bilgileri için silme, güncelleme ve ekleme
    işlemleri yapılacak.
    */
    public partial class Form1 : Form
    {
        public static string gonderilecekveri;

        public Form1()
        {
            InitializeComponent();
        }

        //MenuStript'te Siparişi Düzeltme/Görüntüleme dediğimizde flowLayoutPanel1 buton, textboxlar ve labellar gelecek.
        NorthwindEntitiesConnectionString db = DbSingleTone.GetInstance();
        //Oluşturduğumuz bağlantının yolunu burda entitylere ulaşmak için çağırıyoruz.
        //Modele ulaşmayı sağlayan araçtır.
        //Entity ve facadelara bununla ulaşılır.
        //Bütün entity frameworkte bu var.
        Label lblOrderId = new Label();
        TextBox txtBoxOrderID = new TextBox();
        Button btnGonder = new Button();
        //Bunlar Form üzerinde ilk başta gözükmüyor. MenuStript'te Siparişi Düzeltme/Görüntüleme dediğimizde
        //görünecek. O yüzden burda şimdiden Label,Button ve TextBox sınıflarından instance aldık.
        //Aldığımız instanceları flowLayoutPanel1 içine butonları eklemek için kullanıcaz.
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void OrderCheck()
        {
            //MenuStript'te Siparişi Düzeltme/Görüntüleme dediğimizde görünecek olan txtBoxOrderID textBoxına gireceğimiz 
            //orderID için işlem yapılır. 
            int secilenOrderID;
            secilenOrderID = Convert.ToInt32(txtBoxOrderID.Text);

            try
            {
                List<Order_Detail> orderDetailList = db.Order_Details.Where(x => x.OrderID == secilenOrderID).ToList();
                //List<Order_Detail> list içindeki Order_Detail entity. Bunu Order_Details facadeı olarak liste attık.
                //Seçilenleri ToListe çevirdik. 

                if (orderDetailList.Count == 0)
                {
                    MessageBox.Show(secilenOrderID + "numaralı sipariş bulunamadı.");
                }
                else
                {
                    gonderilecekveri = secilenOrderID.ToString();
                    FormOrderHeaderDetail frm = new FormOrderHeaderDetail(secilenOrderID);
                    //parametreyle Formlar arası veri gönderme için  burada parantez içinde parametre verdik
                    //Diğer Formda bu parametreyi kullanıcaz.
                    frm.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Girilen sipariş için veri okuma yapılamadı.");
            }
        }

        private void siparişDüzeltmeGörüntülemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Bunlar Form üzerinde ilk başta gözükmüyor. MenuStript'te Siparişi Düzeltme/Görüntüleme dediğimizde
            //aşağıdaki buton,textbox ve label gelecek.
            lblOrderId.Text = "Sipariş No";
            btnGonder.Text = "Siparişi Aç";
            //Bunları flowLayoutPanel1 içine ekliyorum
            flowLayoutPanel1.Controls.Add(lblOrderId);
            flowLayoutPanel1.Controls.Add(txtBoxOrderID);
            flowLayoutPanel1.Controls.Add(btnGonder);
            btnGonder.Click += new EventHandler(btnGonder_Click);
            //btnGonder_Click eventine yukarıdakileri ekledim

        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            OrderCheck();
        }

        private void siparişGirişToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FormGiris frmgiris = new FormGiris();
            frmgiris.Show();

            //sipariş giriş'e tıklandığında FormGiris formunu açacak.
        }
    }
}
