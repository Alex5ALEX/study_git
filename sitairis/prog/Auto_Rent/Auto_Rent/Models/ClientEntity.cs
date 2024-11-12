using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Rent.Models;

public class ClientEntity
{
    //atributs
    public Guid Id {  get; set; }   

    public string Name { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public int Age { get; set; } = 0;

    public string Phone {  get; set; } = string.Empty;  

    public string Email { get; set; } = string.Empty;

    public string Addres { get; set; } = string.Empty;



    //links
    public List<OrderEntity> Orders { get; set; } = [];
}
