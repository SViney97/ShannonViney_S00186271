using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShannonViney_S00186271
{
    public class Phone
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public decimal IncreasePrice (decimal percent, decimal price)
        {
            decimal Percent = (price / percent)*100;
            decimal Price = price + Percent;
            return Price;
        }
    }
}
