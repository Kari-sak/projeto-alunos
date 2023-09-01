using System.ComponentModel.DataAnnotations;

namespace AlunosFIAP_Oracle1.Models
{
    public class Alunos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = null!;

    }
}
