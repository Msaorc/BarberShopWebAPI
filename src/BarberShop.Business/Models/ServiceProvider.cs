using System;

namespace BarberShop.Business.Models;

public class ServiceProvider : ModelBase
{
    public Guid ProviderId { get; set; }
    public Guid ServicesId { get; set; }
    public Provider Provider { get; set; }
    public Services Services { get; set; }
}
