using System;

namespace BarberShop.Business.Models;

public class ServiceScheduling : ModelBase
{
    public Guid SchedulingId { get; set; }
    public Guid ServicesId { get; set; }
    public Scheduling Scheduling { get; set; }
    public Services Services { get; set; }
}
