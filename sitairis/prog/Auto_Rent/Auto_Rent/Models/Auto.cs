using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Rent.Models
{
    internal class Auto
    {
        //attributs
        public Guid Id { get; set; }

        public string Brand { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public decimal Price { get; set; } = 0;

        public decimal Coast { get; set; } = 0;

        public string Condition {  get; set; } = string.Empty;

        public DateTime Year { get; set; } = new DateTime();


        //links
        public Guid Id_Provider { get; set; }

        public Provider? Provider { get; set; }


        public List<Order> Orders { get; set; } = [];
    }
}
