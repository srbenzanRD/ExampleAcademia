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
    public List<Estudiante> GetAll()
    {
        return _context.Estudiantes
        .AsNoTracking()
        .ToList();
    }

/// <summary>
/// Obtiene un estudiante por su Id
/// </summary>
/// <param name="id">El Id del estudiante</param>
/// <returns>El estudiante correspondiente al Id proporcionado, o null si no se encuentra</returns>
    public Estudiante? GetById(int id)
    {
        return _context.Estudiantes.FirstOrDefault(x => x.Id == id);
    }
/// <summary>
/// Crea un nuevo estudiante en la base de datos
/// </summary>
/// <param name="estudiante">El estudiante a crear</param>
/// <returns>True si el estudiante se creó correctamente, false en caso contrario</returns>
    public bool Create(Estudiante estudiante)
    {
        _context.Estudiantes.Add(estudiante);
        return _context.SaveChanges() > 0;
    }
/// <summary>
/// Actualiza un estudiante existente en la base de datos
/// </summary>
/// <param name="estudiante">El estudiante a actualizar</param>
/// <returns>True si el estudiante se actualizó correctamente, false en caso contrario</returns>
    public bool Update(Estudiante estudiante)
    {
        _context.Estudiantes.Update(estudiante);
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