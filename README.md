# MVC_School_CodeFirst
Proyecto MVC realizado con CodeFirst, pasos a realizar:
1. Crear proyecto de tipo MVC
2. Añadir los modelos "Models" que usaremos para crear la base de datos posteriormente, realizar los Annotations correspondientes y modelos de tablas relacionales (para construir las relaciones seguir: https://entityframework.net/one-to-one-relationship)
3. Asegurar la instalación de los paquetes Nuget:
  - Microsoft.EntityFrameworkCore.Sqlite
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.VisualStudio.Web.CodeGeneration.
4. Añadir los "Controller" para cada modelo. El primer Controller añadirá el Context.
5. Al añadir el Contexto, se crea la carpeta "Data" que contiene el Contexto en sí, dentro de ella las tablas (DbSet) por cada Controller
6. En appsettings.json pordemos modificar la "cadena de conexión a la BD", seleccionar el Server y nombre de la BD, etc. (antes de crearla)
7. En Startup.cs, se añade un servicio: services.AddDbContext......, que inyecta el contexto en nuestro proyecto. 
