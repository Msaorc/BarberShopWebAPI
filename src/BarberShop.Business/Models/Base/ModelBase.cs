using System;

namespace BarberShop.Business.Models;

public abstract class ModelBase
{
    protected ModelBase()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
}
