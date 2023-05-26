using ConsoleApp_CodeFirst.DAL;
using ConsoleApp_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CodeFirst
{
    internal class Program
    {
        // Code First Crud İşlemleri
        static void Main(string[] args)
        {
            Context c = new Context();
            var values = c.Customers.ToList();
            void Listele()
            {
                

                foreach (var item in values)
                {
                    Console.WriteLine(item.CustomerName);
                }
            }

            //Ekleme İşlemi
            /*Customer customer = new Customer();
            customer.CustomerName = "Merve Karalar";
            customer.CustomerCity = "Lviv";
            c.Customers.Add(customer);
            c.SaveChanges();
            Listele();*/

            //Silme İşlemi
            /*var values2 = c.Customers.Where(x => x.CustomerID == 4).FirstOrDefault();
            c.Customers.Remove(values2);
            c.SaveChanges();
            Console.WriteLine("Silme İşlemi Gerçekleştirildi.");*/


            //Güncelleme İşlemi
            var values3 = c.Customers.Where(x => x.CustomerID==3).FirstOrDefault();
            values3.CustomerName = "Ahmet Karalı";
            values3.CustomerCity = "Trabzon";
            c.SaveChanges();
            Console.WriteLine("Güncelleme Gerçekleştirildi");

            Console.ReadLine();
        }
    }
}
