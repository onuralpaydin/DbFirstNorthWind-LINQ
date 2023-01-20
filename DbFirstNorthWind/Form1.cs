using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFirstNorthWind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindENGDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindENGDataSet.Products);
            NorthwindENGEntities db = new NorthwindENGEntities();
            //    List<Product> urunListem = new List<Product>();
            //foreach (var item in db.Products)
            //{
            //    urunListem.Add(item);
            //}
            //dataGridView1.DataSource = urunListem;
            dataGridView1.DataSource = db.Shippers.ToList();


        }
        //EF DB FİRST NORTHWIND PRODUCTS TABLOSUNDAKİ VERİLERİ DGV DE GÖSTERİNİZ.

    }
}
