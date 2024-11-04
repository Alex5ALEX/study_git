using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Rent.Models
{
    internal class Order
    {
        //atributs
        public Guid Id { get; set; }

        public DateTime Date { get; set; } = new DateTime();

        public DateTime RentalPeriod { get; set; } = new DateTime();

        public decimal StartDeposit { get; set; } = 0;


        //links
        public Guid Id_Client { get; set; }

        public Client? Client { get; set; }


        public Guid Id_Employee {  get; set; }

        public Employee? Employee { get; set; }


        public Guid Id_Auto { get; set; }

        public Auto? Auto { get; set; }
    }
}
