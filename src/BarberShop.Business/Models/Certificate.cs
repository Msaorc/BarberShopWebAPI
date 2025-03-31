using System;

namespace BarberShop.Business.Models;

public class Certificate : ModelBase
{
    public Guid ProviderId { get; set; }
    public string Name { get; set; }
    public string Institution { get; set; }
    public string ImagePath { get; set; }
    public Provider Provider { get; set; }
}
