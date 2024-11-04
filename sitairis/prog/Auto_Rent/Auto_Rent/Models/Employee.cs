using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Rent.Models
{
    internal class Employee
    {
        //atributs
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public int Age { get; set; } = 0;

        public string JobTitle { get; set; } = string.Empty;

        public string Addres { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;


        //enterance in program
        public string Login { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;


        //links
        public List<Order> Orders { get; set; } = [];

    }
}
