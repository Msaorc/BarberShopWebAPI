using System;
using System.ComponentModel.DataAnnotations;

namespace BarberShop.Api.DTOs;

public class CustomerDTO
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é Obrigatório")]
    [StringLength(250, ErrorMessage = "O campo {0} precisa ter no mínimo {2} caracteres e no máximo {1}", MinimumLength = 6)]
    public string Name { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(11, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} numeros", MinimumLength = 10)]
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public int? IdDocument { get; set;}
}
