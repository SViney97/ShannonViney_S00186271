using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShannonViney_S00186271
{
    public class Phone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }
        public virtual List<Phone> Phones { get; set; }

        public void IncreasePrice (decimal percent)
        {
            decimal Percent = (Price / percent)*100;
             Price = Price + Percent;
            
        }

        public Phone()
        {

        }
        public Phone(int id, string name, decimal price, string operatingsystem, string os_image, string phone_image)
        {

        }
    }

    public class PhoneData :DbContext
    {
        public PhoneData() : base("PhoneData") { }
        public DbSet<Phone> Phones { get; set; }
    }
}
