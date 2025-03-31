using System;

namespace BarberShop.Api.DTOs;

public class CertificateDTO
{
    public Guid ProviderId { get; set; }
    public string Name { get; set; }
    public string Institution { get; set; }
    public string ImagePath { get; set; }
    public ProviderDTO Provider { get; set; }
}
