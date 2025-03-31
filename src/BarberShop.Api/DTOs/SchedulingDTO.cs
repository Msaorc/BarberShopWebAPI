using System;
using System.ComponentModel.DataAnnotations;

namespace BarberShop.Api.DTOs;

public class SchedulingDTO
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é Obrigatório")]
    public DateTime Date { get; set; }
    [Required(ErrorMessage = "O campo {0} é Obrigatório")]
    public string Time { get; set; }
    [Required(ErrorMessage = "O campo {0} é Obrigatório")]
    public Guid ProviderId { get; set; }
    public Guid CustomerId { get; set; }
    public List<ServicesDTO> Services { get; set; }
    public CustomerDTO Customer { get; set; }
    public ProviderDTO Provider { get; set; }
    public int Confirmed { get; set; }
    public string Observation { get; set; }
}
