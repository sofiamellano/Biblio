using Microsoft.EntityFrameworkCore;
using Service.Enums;
using Service.Models;

namespace Backend.DataContext
{
    public class BiblioContext : DbContext
    {
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Autor> Autores { get; set; }
        public virtual DbSet<Editorial> Editoriales { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<LibroAutor> LibroAutores { get; set; }
        public virtual DbSet<LibroGenero> LibroGeneros { get; set; }
        public virtual DbSet<UsuarioCarrera> UsuarioCarreras { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Prestamo> Prestamos { get; set; }
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Ejemplar> Ejemplares { get; set; }

        public BiblioContext() { }

        public BiblioContext(DbContextOptions<BiblioContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .Build();
                var connectionString = configuration.GetConnectionString("mysqlRemoto");
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Datos Semilla de 10 Autores
            // datos semilla de autores 10
            modelBuilder.Entity<Autor>().HasData(
                new Autor { Id = 1, Nombre = "Gabriel García Márquez" },
                new Autor { Id = 2, Nombre = "Isabel Allende" },
                new Autor { Id = 3, Nombre = "Mario Vargas Llosa" },
                new Autor { Id = 4, Nombre = "Jorge Luis Borges" },
                new Autor { Id = 5, Nombre = "Pablo Neruda" },
                new Autor { Id = 6, Nombre = "Julio Cortázar" },
                new Autor { Id = 7, Nombre = "Laura Esquivel" },
                new Autor { Id = 8, Nombre = "Carlos Fuentes" },
                new Autor { Id = 9, Nombre = "Miguel de Cervantes" },
                new Autor { Id = 10, Nombre = "Federico García Lorca" }
            );
            #endregion
            #region Datos Semilla de 10 Editoriales
            // datos semilla de editoriales 10
            modelBuilder.Entity<Editorial>().HasData(
                new Editorial { Id = 1, Nombre = "Penguin Random House" },
                new Editorial { Id = 2, Nombre = "HarperCollins" },
                new Editorial { Id = 3, Nombre = "Simon & Schuster" },
                new Editorial { Id = 4, Nombre = "Hachette Book Group" },
                new Editorial { Id = 5, Nombre = "Macmillan Publishers" },
                new Editorial { Id = 6, Nombre = "Scholastic" },
                new Editorial { Id = 7, Nombre = "Bloomsbury Publishing" },
                new Editorial { Id = 8, Nombre = "Oxford University Press" },
                new Editorial { Id = 9, Nombre = "Cambridge University Press" },
                new Editorial { Id = 10, Nombre = "Wiley" }
            );
            #endregion
            #region Datos Semilla de 10 Generos
            //datos semillas de generos 10
            modelBuilder.Entity<Genero>().HasData(
                new Genero { Id = 1, Nombre = "Ficción" },
                new Genero { Id = 2, Nombre = "No Ficción" },
                new Genero { Id = 3, Nombre = "Misterio" },
                new Genero { Id = 4, Nombre = "Ciencia Ficción" },
                new Genero { Id = 5, Nombre = "Fantasía" },
                new Genero { Id = 6, Nombre = "Romance" },
                new Genero { Id = 7, Nombre = "Terror" },
                new Genero { Id = 8, Nombre = "Aventura" },
                new Genero { Id = 9, Nombre = "Historia" },
                new Genero { Id = 10, Nombre = "Biografía" }
            );
            #endregion
            #region Datos Semilla de 10 Ejemplares
            modelBuilder.Entity<Ejemplar>().HasData(
                new Ejemplar { Id = 1, LibroId = 1, Disponible = true, Estado = EstadoEnum.Exelente },
                new Ejemplar { Id = 2, LibroId = 2, Disponible = true, Estado = EstadoEnum.MuyBueno },
                new Ejemplar { Id = 3, LibroId = 3, Disponible = false, Estado = EstadoEnum.Bueno },
                new Ejemplar { Id = 4, LibroId = 4, Disponible = true, Estado = EstadoEnum.Exelente },
                new Ejemplar { Id = 5, LibroId = 5, Disponible = false, Estado = EstadoEnum.MuyBueno },
                new Ejemplar { Id = 6, LibroId = 6, Disponible = true, Estado = EstadoEnum.Bueno },
                new Ejemplar { Id = 7, LibroId = 7, Disponible = true, Estado = EstadoEnum.Exelente },
                new Ejemplar { Id = 8, LibroId = 8, Disponible = false, Estado = EstadoEnum.MuyBueno },
                new Ejemplar { Id = 9, LibroId = 9, Disponible = true, Estado = EstadoEnum.Bueno },
                new Ejemplar { Id = 10, LibroId = 10, Disponible = true, Estado = EstadoEnum.Exelente }
            );
            #endregion
            #region Datos Semilla de 10 Libros
            modelBuilder.Entity<Libro>().HasData(
                new Libro { Id = 1, Titulo = "Cien años de soledad", EditorialId = 1, Paginas = 417, Sinopsis = "La historia de la familia Buendía en Macondo.", AnioPublicacion = 1967 },
                new Libro { Id = 2, Titulo = "La casa de los espíritus", EditorialId = 2, Paginas = 368, Sinopsis = "Saga familiar con elementos mágicos.", AnioPublicacion = 1982 },
                new Libro { Id = 3, Titulo = "La ciudad y los perros", EditorialId = 3, Paginas = 336, Sinopsis = "La vida en un colegio militar peruano.", AnioPublicacion = 1963 },
                new Libro { Id = 4, Titulo = "Ficciones", EditorialId = 4, Paginas = 224, Sinopsis = "Relatos fantásticos y filosóficos.", AnioPublicacion = 1944 },
                new Libro { Id = 5, Titulo = "Veinte poemas de amor y una canción desesperada", EditorialId = 5, Paginas = 80, Sinopsis = "Colección de poemas románticos.", AnioPublicacion = 1924 },
                new Libro { Id = 6, Titulo = "Rayuela", EditorialId = 6, Paginas = 608, Sinopsis = "Novela experimental sobre la vida y el amor.", AnioPublicacion = 1963 },
                new Libro { Id = 7, Titulo = "Como agua para chocolate", EditorialId = 7, Paginas = 256, Sinopsis = "Historia de amor y cocina en México.", AnioPublicacion = 1989 },
                new Libro { Id = 8, Titulo = "Terra Nostra", EditorialId = 8, Paginas = 800, Sinopsis = "Novela histórica y fantástica.", AnioPublicacion = 1975 },
                new Libro { Id = 9, Titulo = "Don Quijote de la Mancha", EditorialId = 9, Paginas = 863, Sinopsis = "Las aventuras del ingenioso hidalgo.", AnioPublicacion = 1605 },
                new Libro { Id = 10, Titulo = "Bodas de sangre", EditorialId = 10, Paginas = 96, Sinopsis = "Tragedia teatral sobre el destino.", AnioPublicacion = 1933 }
            );
            #endregion
            #region Datos Semilla de 10 Usuarios
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Nombre = "Juan Pérez", Email = "juan1@mail.com", Password = "pass1", TipoRol = TipoRolEnum.Alumno, FechaRegistracion = DateTime.Now, Dni = "11111111", Domicilio = "Calle 1", Telefono = "111111111", Observacion = "" },
                new Usuario { Id = 2, Nombre = "Ana Gómez", Email = "ana2@mail.com", Password = "pass2", TipoRol = TipoRolEnum.Alumno, FechaRegistracion = DateTime.Now, Dni = "22222222", Domicilio = "Calle 2", Telefono = "222222222", Observacion = "" },
                new Usuario { Id = 3, Nombre = "Luis Martínez", Email = "luis3@mail.com", Password = "pass3", TipoRol = TipoRolEnum.Alumno, FechaRegistracion = DateTime.Now, Dni = "33333333", Domicilio = "Calle 3", Telefono = "333333333", Observacion = "" },
                new Usuario { Id = 4, Nombre = "María López", Email = "maria4@mail.com", Password = "pass4", TipoRol = TipoRolEnum.Alumno, FechaRegistracion = DateTime.Now, Dni = "44444444", Domicilio = "Calle 4", Telefono = "444444444", Observacion = "" },
                new Usuario { Id = 5, Nombre = "Carlos Ruiz", Email = "carlos5@mail.com", Password = "pass5", TipoRol = TipoRolEnum.Alumno, FechaRegistracion = DateTime.Now, Dni = "55555555", Domicilio = "Calle 5", Telefono = "555555555", Observacion = "" },
                new Usuario { Id = 6, Nombre = "Sofía Torres", Email = "sofia6@mail.com", Password = "pass6", TipoRol = TipoRolEnum.Alumno, FechaRegistracion = DateTime.Now, Dni = "66666666", Domicilio = "Calle 6", Telefono = "666666666", Observacion = "" },
                new Usuario { Id = 7, Nombre = "Miguel Castro", Email = "miguel7@mail.com", Password = "pass7", TipoRol = TipoRolEnum.Alumno, FechaRegistracion = DateTime.Now, Dni = "77777777", Domicilio = "Calle 7", Telefono = "777777777", Observacion = "" },
                new Usuario { Id = 8, Nombre = "Lucía Fernández", Email = "lucia8@mail.com", Password = "pass8", TipoRol = TipoRolEnum.Alumno, FechaRegistracion = DateTime.Now, Dni = "88888888", Domicilio = "Calle 8", Telefono = "888888888", Observacion = "" },
                new Usuario { Id = 9, Nombre = "Pedro Sánchez", Email = "pedro9@mail.com", Password = "pass9", TipoRol = TipoRolEnum.Alumno, FechaRegistracion = DateTime.Now, Dni = "99999999", Domicilio = "Calle 9", Telefono = "999999999", Observacion = "" },
                new Usuario { Id = 10, Nombre = "Valentina Romero", Email = "valentina10@mail.com", Password = "pass10", TipoRol = TipoRolEnum.Alumno, FechaRegistracion = DateTime.Now, Dni = "10101010", Domicilio = "Calle 10", Telefono = "101010101", Observacion = "" }
            );
            #endregion
            #region Datos Semilla de 10 Prestamos
            modelBuilder.Entity<Prestamo>().HasData(
                new Prestamo { Id = 1, UsuarioId = 1, EjemplarId = 1, FechaPrestamo = DateTime.Now.AddDays(-10), FechaDevolucion = DateTime.Now.AddDays(-3) },
                new Prestamo { Id = 2, UsuarioId = 2, EjemplarId = 2, FechaPrestamo = DateTime.Now.AddDays(-9), FechaDevolucion = DateTime.Now.AddDays(-2) },
                new Prestamo { Id = 3, UsuarioId = 3, EjemplarId = 3, FechaPrestamo = DateTime.Now.AddDays(-8), FechaDevolucion = DateTime.Now.AddDays(-1) },
                new Prestamo { Id = 4, UsuarioId = 4, EjemplarId = 4, FechaPrestamo = DateTime.Now.AddDays(-7), FechaDevolucion = DateTime.Now },
                new Prestamo { Id = 5, UsuarioId = 5, EjemplarId = 5, FechaPrestamo = DateTime.Now.AddDays(-6), FechaDevolucion = DateTime.Now.AddDays(1) },
                new Prestamo { Id = 6, UsuarioId = 6, EjemplarId = 6, FechaPrestamo = DateTime.Now.AddDays(-5), FechaDevolucion = DateTime.Now.AddDays(2) },
                new Prestamo { Id = 7, UsuarioId = 7, EjemplarId = 7, FechaPrestamo = DateTime.Now.AddDays(-4), FechaDevolucion = DateTime.Now.AddDays(3) },
                new Prestamo { Id = 8, UsuarioId = 8, EjemplarId = 8, FechaPrestamo = DateTime.Now.AddDays(-3), FechaDevolucion = DateTime.Now.AddDays(4) },
                new Prestamo { Id = 9, UsuarioId = 9, EjemplarId = 9, FechaPrestamo = DateTime.Now.AddDays(-2), FechaDevolucion = DateTime.Now.AddDays(5) },
                new Prestamo { Id = 10, UsuarioId = 10, EjemplarId = 10, FechaPrestamo = DateTime.Now.AddDays(-1), FechaDevolucion = DateTime.Now.AddDays(6) }
            );
            #endregion
            #region Datos Semilla de 10 LibroAutor
            modelBuilder.Entity<LibroAutor>().HasData(
                new LibroAutor { Id = 1, LibroId = 1, AutorId = 1 },
                new LibroAutor { Id = 2, LibroId = 2, AutorId = 2 },
                new LibroAutor { Id = 3, LibroId = 3, AutorId = 3 },
                new LibroAutor { Id = 4, LibroId = 4, AutorId = 4 },
                new LibroAutor { Id = 5, LibroId = 5, AutorId = 5 },
                new LibroAutor { Id = 6, LibroId = 6, AutorId = 6 },
                new LibroAutor { Id = 7, LibroId = 7, AutorId = 7 },
                new LibroAutor { Id = 8, LibroId = 8, AutorId = 8 },
                new LibroAutor { Id = 9, LibroId = 9, AutorId = 9 },
                new LibroAutor { Id = 10, LibroId = 10, AutorId = 10 }
            );
            #endregion
            #region Datos Semilla de 10 LibroGenero
            modelBuilder.Entity<LibroGenero>().HasData(
                new LibroGenero { Id = 1, LibroId = 1, GeneroId = 1 },
                new LibroGenero { Id = 2, LibroId = 2, GeneroId = 2 },
                new LibroGenero { Id = 3, LibroId = 3, GeneroId = 3 },
                new LibroGenero { Id = 4, LibroId = 4, GeneroId = 4 },
                new LibroGenero { Id = 5, LibroId = 5, GeneroId = 5 },
                new LibroGenero { Id = 6, LibroId = 6, GeneroId = 6 },
                new LibroGenero { Id = 7, LibroId = 7, GeneroId = 7 },
                new LibroGenero { Id = 8, LibroId = 8, GeneroId = 8 },
                new LibroGenero { Id = 9, LibroId = 9, GeneroId = 9 },
                new LibroGenero { Id = 10, LibroId = 10, GeneroId = 10 }
            );
            #endregion
            #region Datos Semilla de 10 UsuarioCarrera
            modelBuilder.Entity<UsuarioCarrera>().HasData(
                new UsuarioCarrera { Id = 1, UsuarioId = 1, CarreraId = 1 },
                new UsuarioCarrera { Id = 2, UsuarioId = 2, CarreraId = 2 },
                new UsuarioCarrera { Id = 3, UsuarioId = 3, CarreraId = 3 },
                new UsuarioCarrera { Id = 4, UsuarioId = 4, CarreraId = 4 },
                new UsuarioCarrera { Id = 5, UsuarioId = 5, CarreraId = 5 },
                new UsuarioCarrera { Id = 6, UsuarioId = 6, CarreraId = 6 },
                new UsuarioCarrera { Id = 7, UsuarioId = 7, CarreraId = 7 },
                new UsuarioCarrera { Id = 8, UsuarioId = 8, CarreraId = 8 },
                new UsuarioCarrera { Id = 9, UsuarioId = 9, CarreraId = 9 },
                new UsuarioCarrera { Id = 10, UsuarioId = 10, CarreraId = 10 }
            );
            #endregion
            #region Datos Semillas de 10 Carreras
            modelBuilder.Entity<Carrera>().HasData(
                new Carrera { Id = 1, Nombre = "Profesorado de Educación Inicial" },
                new Carrera { Id = 2, Nombre = "Profesorado de Educ. Secundaria en Cs de la Administración" },
                new Carrera { Id = 3, Nombre = "Profesorado de Educ. Secundaria en Economía" },
                new Carrera { Id = 4, Nombre = "Profesorado de Educación Tecnológica" },
                new Carrera { Id = 5, Nombre = "Técnico Superior en Desarrollo de Software" },
                new Carrera { Id = 6, Nombre = "Técnico Superior en Enfermería" },
                new Carrera { Id = 7, Nombre = "Tecnicatura Superior en Gestión de Energías Renovables" },
                new Carrera { Id = 8, Nombre = "Técnico Superior en Gestión de las Organizaciones" },
                new Carrera { Id = 9, Nombre = "Técnico Superior en Soporte de Infraestructura en Tecnologías de la Información" },
                new Carrera { Id = 10, Nombre = "Licenciatura en Cooperativismo y Mutualismo" }
           );
            #endregion

            // configuramos los query filters para que no traigan los registros eliminados
            modelBuilder.Entity<Autor>().HasQueryFilter(a => !a.IsDeleted);
            modelBuilder.Entity<Editorial>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Genero>().HasQueryFilter(g => !g.IsDeleted);
            modelBuilder.Entity<Libro>().HasQueryFilter(l => !l.IsDeleted);
            modelBuilder.Entity<Carrera>().HasQueryFilter(l => !l.IsDeleted);
            modelBuilder.Entity<Ejemplar>().HasQueryFilter(l => !l.IsDeleted);
            modelBuilder.Entity<LibroAutor>().HasQueryFilter(l => !l.IsDeleted);
            modelBuilder.Entity<LibroGenero>().HasQueryFilter(l => !l.IsDeleted);
            modelBuilder.Entity<Prestamo>().HasQueryFilter(l => !l.IsDeleted);
            modelBuilder.Entity<Usuario>().HasQueryFilter(l => !l.IsDeleted);
            modelBuilder.Entity<UsuarioCarrera>().HasQueryFilter(l => !l.IsDeleted); 
        }
    }
}
