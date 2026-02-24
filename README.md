# ExampleAcademia
Proyecto educativo desarrollado con **Blazor Web App (.NET 10)**, **Entity Framework Core** y **SQLite**. El objetivo principal es la práctica de operaciones CRUD y el uso de `EditForm` para la gestión de datos.

## 🚀 Arquitectura del Proyecto

### 1. Configuración Principal (`Program.cs`)
- **Blazor Interactive Server**: Configurado para renderizado interactivo desde el servidor.
- **Inyección de Dependencias**: Registro de servicios como `EstudianteService` y el contexto de base de datos.
- **Base de Datos**: Uso de SQLite con una cadena de conexión definida en `appsettings.json`. Incluye `db.Database.EnsureCreated()` para la creación automática al inicio.
- **Identidad**: Sistema de autenticación y autorización preconfigurado.

### 2. Capa de Datos (`Data/`)
- **Modelos (`Models/`)**: 
  - `Estudiante.cs`: Representa la entidad con atributos como `Id`, `Matricula` y `Nombre`. Utiliza Data Annotations para definir tipos de columna en la BD.
- **Servicios (`Services/`)**:
  - `EstudianteService.cs`: Contiene la lógica de persistencia utilizando EF Core (`GetAll`, `GetById`, `Create`, `Update`).

### 3. Componentes y Vistas (`Components/Pages/Estudientes/`)
- **`IndexEstudiantes.razor`**: Página principal para visualizar el listado de estudiantes mediante el servicio inyectado. Implementa estilos de Bootstrap para una interfaz limpia.
- **`_Imports.razor`**: Centralización de directivas `@using` y la inyección de `EstudianteService` para simplificar los componentes de este módulo.

## 🛠️ Tecnologías Utilizadas
- **.NET 10.0** (Blazor Web App)
- **Entity Framework Core** (SQL Server/SQLite)
- **Bootstrap 5.x** (Estilos y Layout)
- **ASP.NET Core Identity** (Seguridad)

## 📋 Próximos Pasos
- Implementar la creación de estudiantes mediante un formulario con `EditForm`.
- Añadir validaciones de modelo (Data Annotations).
- Extender el servicio para incluir la operación `Delete`.
- Mejorar la experiencia de usuario con notificaciones tras cada operación.
