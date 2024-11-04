using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Rent.Models
{
    internal class Provider
    {
        //atributs
        public Guid Id { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Addres { get; set; } =string.Empty;


        //links
        public List<Auto> Autos { get; set; } = [];
    }
}
