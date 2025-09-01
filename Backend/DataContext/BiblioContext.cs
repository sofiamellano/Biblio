using Microsoft.EntityFrameworkCore;
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
