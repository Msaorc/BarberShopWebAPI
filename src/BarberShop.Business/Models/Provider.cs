using System;

namespace BarberShop.Business.Models;

public class Provider : ModelBase
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public int IdDocument { get; set;}
    public List<Certificate> Certificates { get; set; }
}
