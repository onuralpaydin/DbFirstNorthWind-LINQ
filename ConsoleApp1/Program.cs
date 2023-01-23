using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///1)dbFirst ile NorthWind'e bağlanın.
            NorthwindEntities db = new NorthwindEntities();

            ///2)Products tablosundaki ürünleri console'a yazdırınız (2 yol vardı.)
            //foreach (Product urun in db.Products)
            //{
            //    Console.WriteLine($"{urun.ProductID} {urun.ProductName} {urun.UnitPrice} {urun.Discontinued} ");
            //}
            //var urunler = from urun in db.Products
            //              select urun;
            //foreach (var urun in urunler)
            //{
            //     Console.WriteLine($"{urun.ProductID} {urun.ProductName} {urun.UnitPrice} {urun.Discontinued} ");
            //}
            ///3)UnitPrice 100 den büyük olan ürünleri yazdırınız.
            //var unitprice = db.Products.Where(urun => urun.UnitPrice >= 100).ToList();
            //var sorgu = from urun in db.Products
            //            where urun.UnitPrice >= 100
            //            select urun;
            //foreach (var item in unitPrice)
            //{
            //    Console.WriteLine(item.UnitPrice) ;
            //}
            //foreach (var item in sorgu)
            //{
            //    Console.WriteLine(item.ProductID+" "+item.ProductName);
            //}
            //Console.WriteLine(unitPrice);
            ///4)Employees içerisinde Şehri Seattle olan personelleri listeleyiniz.
            //var result = db.Employees.Where(calisan => calisan.City.Contains("sea")).ToList();
            //var result = from calisan in db.Employees
            //             where calisan.City == "seattle" select calisan;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.FirstName+" "+item.LastName+" "+item.City);
            //}
            ///5)Personellerin sadece adlarını listeleyiniz.
            //var personelAd = db.Employees.Select(personel => new { adlar = personel.FirstName }).ToList();
            //foreach (var item in personelAd)
            //{
            //    Console.WriteLine(item.adlar);
            //}
            //var personeller = from personel in db.Employees
            //                  select new { personel.FirstName }  ; 
            //foreach (var item in personeller)
            //{
            //    Console.WriteLine("ADLAR: "+item.FirstName);
            //}
            /// 6)Personellerin adını soyadını şehrini listeleyiniz.

            //var personelAdSoyad = db.Employees.Select(personel => new Employee { FirstName = personel.FirstName, LastName = personel.LastName, City = personel.City }).ToList();
            //var personelAdSoyad = db.Employees.Select(personel => new Personel { Ad = personel.FirstName, Soyad = personel.LastName, Sehir = personel.City }).ToList();
            //var personelAdSoyad = from personel in db.Employees
            //                      select new { Ad = personel.FirstName, Soyad = personel.LastName,Sehiri=personel.City };

            //foreach (var item in personelAdSoyad.ToList())
            //{
            //    Console.WriteLine(item.Ad+" "+item.Soyad+" "+item.Sehiri);
            //    //Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.City);
            //}
            ///7)Kategorileri , kategori adına göre sıralayınız.
            //var kategorilerOrderBy = from kategori in db.Categories
            //                         orderby kategori.CategoryName ascending
            //                         select kategori;
            //var kategorilerOrderBy = db.Categories.OrderByDescending(kategori => kategori.CategoryName).ToList();
            ////var kategorilerOrderBy = db.Categories.OrderBy(kategori => kategori.CategoryName).ToList();
            //foreach (var item in kategorilerOrderBy)
            //{
            //    Console.WriteLine(item.CategoryID+" "+item.CategoryName);
            //}
            ///8)Kategorileri kategori adına göre sıralayınız. Sıralama 4. elemandan başlasın.
            //var kategoriOrderBy = db.Categories.OrderBy(kategori => kategori.CategoryName).Skip(3).ToList();
            //var kategoriOrderBy = (from k in db.Categories
            //                       orderby k.CategoryName
            //                       //skip 3 gibi bir ifade yazılamıyor
            //                       select k).Skip(3).ToList();

            //foreach (var item in kategoriOrderBy)
            //{
            //    Console.WriteLine(item.CategoryID+" "+item.CategoryName);
            //}
            ///9)Urunler listesindeki ilk 5 elemanı ekrana yazdırınız.
            var urunler = db.Products.Take(5).ToList();
            //var urunler = (from u in db.Products
            //               select u).Take(5);
            foreach (var item in urunler)
            {
                Console.WriteLine(item.ProductID+" "+item.ProductName);
            }
            ///10)ÖDEV
            ///takeWhile , skipWhile
            ///sorguları dgv ye basın.
           
            
            Console.ReadKey();


        }
        public class Personel
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Sehir { get; set; }
        }
    }
}
