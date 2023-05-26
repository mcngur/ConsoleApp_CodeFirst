using ConsoleApp_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CodeFirst.DAL
{
    internal class Context:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

/*
    Db First yaklaşımında 
 * SQL deki tablolar birer sınıfa, bu tablolar içerisinde yer alan sütunlar ise birer property'e dönüşüyor
 
    Code First yaklaşımında
 * C# daki sınıflar SQL de birer tabloya, sınıflar içerisindeki prop lar ise birer tablo sütununa dçönüşüyor
 
    s Takısı
    pluralize olayı

 * Oluşturulan sınıflar ve tablolar birbirine karışmaması için
 * Yalın halini sınıflar alır. Çoğul halini ise tablolar isim olarak alır
 Examp:/ 
    job ==> class
    jobs ==> tablo

küçük Customers ile büyük customers arasındaki fark Visual studio da üzerlerine geldiğimde küçük olan da fields büyük olan da properties yazıyordu. Bu ikisini araştırdım. Fieldslar içinde veri tuttuğumuz bizim tanımladığımız her tipten değişkenlere deniyor int a  gibi mesela ama property ler ise get ve set ile yazılan değişkenler. Get işlemi okuma, set işlemi ise yazdırma ve güncelleme olarak kullanabiliyoruz eğer biz bu propertyi yi private olarak tanımlarsak dışarıdan erişime kapatmış oluyoruz. 
 */
