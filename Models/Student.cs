using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace teste_crud.Models;

public class Student
{
    [Key]
    [DisplayName("id")]
    public int id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(80, ErrorMessage = "O Nome deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter pelo menos 5 caracteres")]
    [DisplayName("Nome Completo")]
    public string? Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe o E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    [DisplayName("E-mail")]
    public string? Email { get; set; } = string.Empty;

    public List<Premium> Premiums { get; set; } = new List<Premium>();
}
