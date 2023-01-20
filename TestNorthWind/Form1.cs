using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNorthWind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindENGEntities db = new NorthwindENGEntities();
            //birim fiyatı 50 den büyük olan kaç adet ürün var?
            //algoritmik yazım şekli
            //int kacAdetUrunVar = 0;
            //List<Product> urunler = db.Products.ToList();
            //List<Product> urunlerEllidenBuyuk = new List<Product>();
            //foreach (var item in urunler)
            //{
            //    if (item.UnitPrice>50)
            //    {
            //        kacAdetUrunVar++;
            //        urunlerEllidenBuyuk.Add(item);

            //    }
            //}
            //dataGridView1.DataSource = urunlerEllidenBuyuk;
            //MessageBox.Show("50 den büyük ürün sayısı:"+kacAdetUrunVar);
            //methodSyntax
            //dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 50).ToList();
            dataGridView1.DataSource = db.Suppliers.ToList();
            dataGridView2.DataSource = db.Categories.ToList();
            List<Employee> calisanListesi = new List<Employee>();
            foreach (Employee item in db.Employees)
            {
                calisanListesi.Add(item);
            }
            dataGridView3.DataSource = calisanListesi;

            //dgv 4 te supplier Tokyo Traders olanı getirin.
            //dgv 5 te ürün id si 10 olanı getirin
            //dgv 6 da!!
            //query syntax
            dataGridView4.DataSource = db.Products.Where(x => x.UnitPrice > 50).ToList();

            List<Product> urunler = (from u in db.Products
                           where
                           u.UnitPrice > 50 && u.ProductID< 40
                                     select u).ToList(); 
            dataGridView5.DataSource = urunler;

            dataGridView6.DataSource = db.Products.Where(x => x.UnitPrice > 50 && x.UnitsInStock > 39).ToList();

            //dgv7 method syntax ile employeeName=>nancy
            //dgv8 query syntax ile employeeName => nancy
            //dgv9 2 koşul kombinleme.


        }
    }
}
