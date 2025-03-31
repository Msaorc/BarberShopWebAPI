using System;

namespace BarberShop.Business.Models;

public class Services : ModelBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int? Active { get; set; }
}
