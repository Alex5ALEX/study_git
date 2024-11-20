using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Rent.Models;

public class OrderEntity
{
    //atributs
    public Guid Id { get; set; } = Guid.NewGuid();

    public DateTime Date { get; set; } = new DateTime();

    public DateTime RentalPeriod { get; set; } = new DateTime();

    public decimal StartDeposit { get; set; } = 0;


    //links
    public Guid Id_Client { get; set; }

    public ClientEntity? Client { get; set; }


    public Guid Id_Employee {  get; set; }

    public EmployeeEntity? Employee { get; set; }


    public Guid Id_Auto { get; set; }

    public AutoEntity? Auto { get; set; }
}
