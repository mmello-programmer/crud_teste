using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace teste_crud.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o título do Premium")]
        [StringLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "O titulo deve conter pelo menos 5 caracteres")]
        [DisplayName("Titulo")]
        public string? Name { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayNameAttribute("Inicio")]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Término")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno inválido")]
        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
