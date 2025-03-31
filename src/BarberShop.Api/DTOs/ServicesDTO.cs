using System;
using System.ComponentModel.DataAnnotations;

namespace BarberShop.Api.DTOs;

public class ServicesDTO
{
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Description { get; set; }
    public int? Active { get; set; }
}
