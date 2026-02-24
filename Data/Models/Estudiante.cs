namespace ExampleAcademia.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Estudiantes")]
public class Estudiante
{
    [Key]
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(9)")]//Texto de 9 caracteres
    public string Matricula { get; set; } = null!;
    
    [Column(TypeName = "varchar(100)")]//Texto de 100 caracteres
    public string Nombre { get; set; } = null!;
}
