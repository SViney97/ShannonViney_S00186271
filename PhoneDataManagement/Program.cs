using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShannonViney_S00186271;

namespace PhoneDataManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone(1,"Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
                Phone p2 = new Phone(2,"iPhone 11", 600, "IOS", "/images/apple.png", "/images/iPhone11.jpg");

                db.Phones.Add(p1);
                db.Phones.Add(p2);
                Console.WriteLine("added PHones to database");
                db.SaveChanges();
                Console.WriteLine("saved to the database");
            }
        }
    }
}
