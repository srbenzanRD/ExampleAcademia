using ExampleAcademia.Components.ViewModel;
using ExampleAcademia.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleAcademia.Data.Services;

public class EstudianteService
{
    private readonly ApplicationDbContext _context;

    public EstudianteService(ApplicationDbContext context)
    {
        _context = context;
    }

/// <summary>
/// Obtiene una lista de todos los estudiantes en la base de datos
/// </summary>
/// <returns>Una lista de estudiantes</returns>
    public List<EstudianteViewModel> GetAll()
    {
        return _context.Estudiantes
        .AsNoTracking()
        .Select(x => new EstudianteViewModel
        {
            Id = x.Id,
            Matricula = x.Matricula,
            Nombre = x.Nombre
        })
        .ToList();
    }

/// <summary>
/// Obtiene un estudiante por su Id
/// </summary>
/// <param name="id">El Id del estudiante</param>
/// <returns>El estudiante correspondiente al Id proporcionado, o null si no se encuentra</returns>
    public EstudianteViewModel? GetById(int id)
    {
        var estudiante = _context.Estudiantes.FirstOrDefault(x => x.Id == id);
        if (estudiante == null)
            return null;

        return new EstudianteViewModel
        {
            Id = estudiante.Id,
            Matricula = estudiante.Matricula,
            Nombre = estudiante.Nombre
        };
    }
/// <summary>
/// Crea un nuevo estudiante en la base de datos
/// </summary>
/// <param name="estudiante">El estudiante a crear</param>
/// <returns>True si el estudiante se creó correctamente, false en caso contrario</returns>
    public bool Create(EstudianteViewModel estudiante)
    {
        var entity = new Estudiante
        {
            Matricula = estudiante.Matricula,
            Nombre = estudiante.Nombre
        };
        _context.Estudiantes.Add(entity);
        return _context.SaveChanges() > 0;
    }
/// <summary>
/// Actualiza un estudiante existente en la base de datos
/// </summary>
/// <param name="estudiante">El estudiante a actualizar</param>
/// <returns>True si el estudiante se actualizó correctamente, false en caso contrario</returns>
    public bool Update(EstudianteViewModel estudiante)
    {
        var entity = _context.Estudiantes
        .FirstOrDefault(x => x.Id == estudiante.Id);

        if (entity == null)
            return false;

        entity.Matricula = estudiante.Matricula;
        entity.Nombre = estudiante.Nombre;

        _context.Estudiantes.Update(entity);
        return _context.SaveChanges() > 0;
    }
/// <summary>
/// Elimina un estudiante de la base de datos por su Id
/// </summary>
/// <param name="id">El Id del estudiante a eliminar</param>
/// <returns>True si el estudiante se eliminó correctamente, false en caso contrario</returns>
    public bool Delete(int id)
    {
        var estudiante = _context.Estudiantes.FirstOrDefault(x => x.Id == id);
        if (estudiante == null)
            return false;

        _context.Estudiantes.Remove(estudiante);
        return _context.SaveChanges() > 0;
    }
}