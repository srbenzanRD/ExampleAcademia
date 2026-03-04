using System.ComponentModel.DataAnnotations;

namespace ExampleAcademia.Components.ViewModel;
public class EstudianteViewModel
{
    public int Id { get; set; } = 0;

    [MaxLength(10, ErrorMessage = "La matrícula no puede exceder los 10 caracteres.")]
    [Required(ErrorMessage = "La matrícula es requerida.")]
    public string Matricula { get; set; } = null!;

    [Required(ErrorMessage = "El nombre es requerido.")]
    [MaxLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
    public string Nombre { get; set; }= null!;
}