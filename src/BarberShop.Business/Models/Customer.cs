using System;
using System.ComponentModel.DataAnnotations;

namespace BarberShop.Business.Models;

public class Customer : ModelBase
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public int? IdDocument { get; set;}
}
