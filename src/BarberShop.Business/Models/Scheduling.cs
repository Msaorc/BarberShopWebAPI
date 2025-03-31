using System;

namespace BarberShop.Business.Models;

public class Scheduling : ModelBase
{
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public Guid ProviderId { get; set; }
    public Guid CustomerId { get; set; }
    public List<Services> Services { get; set; }
    public Customer Customer { get; set; }
    public Provider Provider { get; set; }
    public int Confirmed { get; set; }
    public string Observation { get; set; }
}
