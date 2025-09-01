using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class DatosSemillaCompletos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoriales", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoRol = table.Column<int>(type: "int", nullable: false),
                    FechaRegistracion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Dni = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Domicilio = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EditorialId = table.Column<int>(type: "int", nullable: false),
                    Paginas = table.Column<int>(type: "int", nullable: false),
                    Sinopsis = table.Column<string>(type: "Text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnioPublicacion = table.Column<int>(type: "int", nullable: false),
                    Portada = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Libros_Editoriales_EditorialId",
                        column: x => x.EditorialId,
                        principalTable: "Editoriales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuarioCarreras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    CarreraId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioCarreras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioCarreras_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioCarreras_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ejemplares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LibroId = table.Column<int>(type: "int", nullable: false),
                    Disponible = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejemplares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ejemplares_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LibroAutores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LibroId = table.Column<int>(type: "int", nullable: false),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroAutores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibroAutores_Autores_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibroAutores_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LibroGeneros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LibroId = table.Column<int>(type: "int", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroGeneros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibroGeneros_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibroGeneros_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    EjemplarId = table.Column<int>(type: "int", nullable: false),
                    FechaPrestamo = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamos_Ejemplares_EjemplarId",
                        column: x => x.EjemplarId,
                        principalTable: "Ejemplares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Gabriel García Márquez" },
                    { 2, false, "Isabel Allende" },
                    { 3, false, "Mario Vargas Llosa" },
                    { 4, false, "Jorge Luis Borges" },
                    { 5, false, "Pablo Neruda" },
                    { 6, false, "Julio Cortázar" },
                    { 7, false, "Laura Esquivel" },
                    { 8, false, "Carlos Fuentes" },
                    { 9, false, "Miguel de Cervantes" },
                    { 10, false, "Federico García Lorca" }
                });

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Profesorado de Educación Inicial" },
                    { 2, false, "Profesorado de Educ. Secundaria en Cs de la Administración" },
                    { 3, false, "Profesorado de Educ. Secundaria en Economía" },
                    { 4, false, "Profesorado de Educación Tecnológica" },
                    { 5, false, "Técnico Superior en Desarrollo de Software" },
                    { 6, false, "Técnico Superior en Enfermería" },
                    { 7, false, "Tecnicatura Superior en Gestión de Energías Renovables" },
                    { 8, false, "Técnico Superior en Gestión de las Organizaciones" },
                    { 9, false, "Técnico Superior en Soporte de Infraestructura en Tecnologías de la Información" },
                    { 10, false, "Licenciatura en Cooperativismo y Mutualismo" }
                });

            migrationBuilder.InsertData(
                table: "Editoriales",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Penguin Random House" },
                    { 2, false, "HarperCollins" },
                    { 3, false, "Simon & Schuster" },
                    { 4, false, "Hachette Book Group" },
                    { 5, false, "Macmillan Publishers" },
                    { 6, false, "Scholastic" },
                    { 7, false, "Bloomsbury Publishing" },
                    { 8, false, "Oxford University Press" },
                    { 9, false, "Cambridge University Press" },
                    { 10, false, "Wiley" }
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Ficción" },
                    { 2, false, "No Ficción" },
                    { 3, false, "Misterio" },
                    { 4, false, "Ciencia Ficción" },
                    { 5, false, "Fantasía" },
                    { 6, false, "Romance" },
                    { 7, false, "Terror" },
                    { 8, false, "Aventura" },
                    { 9, false, "Historia" },
                    { 10, false, "Biografía" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Dni", "Domicilio", "Email", "FechaRegistracion", "IsDeleted", "Nombre", "Observacion", "Password", "Telefono", "TipoRol" },
                values: new object[,]
                {
                    { 1, "11111111", "Calle 1", "juan1@mail.com", new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(488), false, "Juan Pérez", "", "pass1", "111111111", 0 },
                    { 2, "22222222", "Calle 2", "ana2@mail.com", new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(491), false, "Ana Gómez", "", "pass2", "222222222", 0 },
                    { 3, "33333333", "Calle 3", "luis3@mail.com", new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(493), false, "Luis Martínez", "", "pass3", "333333333", 0 },
                    { 4, "44444444", "Calle 4", "maria4@mail.com", new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(495), false, "María López", "", "pass4", "444444444", 0 },
                    { 5, "55555555", "Calle 5", "carlos5@mail.com", new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(497), false, "Carlos Ruiz", "", "pass5", "555555555", 0 },
                    { 6, "66666666", "Calle 6", "sofia6@mail.com", new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(499), false, "Sofía Torres", "", "pass6", "666666666", 0 },
                    { 7, "77777777", "Calle 7", "miguel7@mail.com", new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(500), false, "Miguel Castro", "", "pass7", "777777777", 0 },
                    { 8, "88888888", "Calle 8", "lucia8@mail.com", new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(502), false, "Lucía Fernández", "", "pass8", "888888888", 0 },
                    { 9, "99999999", "Calle 9", "pedro9@mail.com", new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(504), false, "Pedro Sánchez", "", "pass9", "999999999", 0 },
                    { 10, "10101010", "Calle 10", "valentina10@mail.com", new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(506), false, "Valentina Romero", "", "pass10", "101010101", 0 }
                });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "Id", "AnioPublicacion", "Descripcion", "EditorialId", "IsDeleted", "Paginas", "Portada", "Sinopsis", "Titulo" },
                values: new object[,]
                {
                    { 1, 1967, "", 1, false, 417, "", "La historia de la familia Buendía en Macondo.", "Cien años de soledad" },
                    { 2, 1982, "", 2, false, 368, "", "Saga familiar con elementos mágicos.", "La casa de los espíritus" },
                    { 3, 1963, "", 3, false, 336, "", "La vida en un colegio militar peruano.", "La ciudad y los perros" },
                    { 4, 1944, "", 4, false, 224, "", "Relatos fantásticos y filosóficos.", "Ficciones" },
                    { 5, 1924, "", 5, false, 80, "", "Colección de poemas románticos.", "Veinte poemas de amor y una canción desesperada" },
                    { 6, 1963, "", 6, false, 608, "", "Novela experimental sobre la vida y el amor.", "Rayuela" },
                    { 7, 1989, "", 7, false, 256, "", "Historia de amor y cocina en México.", "Como agua para chocolate" },
                    { 8, 1975, "", 8, false, 800, "", "Novela histórica y fantástica.", "Terra Nostra" },
                    { 9, 1605, "", 9, false, 863, "", "Las aventuras del ingenioso hidalgo.", "Don Quijote de la Mancha" },
                    { 10, 1933, "", 10, false, 96, "", "Tragedia teatral sobre el destino.", "Bodas de sangre" }
                });

            migrationBuilder.InsertData(
                table: "UsuarioCarreras",
                columns: new[] { "Id", "CarreraId", "IsDeleted", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, false, 1 },
                    { 2, 2, false, 2 },
                    { 3, 3, false, 3 },
                    { 4, 4, false, 4 },
                    { 5, 5, false, 5 },
                    { 6, 6, false, 6 },
                    { 7, 7, false, 7 },
                    { 8, 8, false, 8 },
                    { 9, 9, false, 9 },
                    { 10, 10, false, 10 }
                });

            migrationBuilder.InsertData(
                table: "Ejemplares",
                columns: new[] { "Id", "Disponible", "Estado", "IsDeleted", "LibroId" },
                values: new object[,]
                {
                    { 1, true, 0, false, 1 },
                    { 2, true, 1, false, 2 },
                    { 3, false, 2, false, 3 },
                    { 4, true, 0, false, 4 },
                    { 5, false, 1, false, 5 },
                    { 6, true, 2, false, 6 },
                    { 7, true, 0, false, 7 },
                    { 8, false, 1, false, 8 },
                    { 9, true, 2, false, 9 },
                    { 10, true, 0, false, 10 }
                });

            migrationBuilder.InsertData(
                table: "LibroAutores",
                columns: new[] { "Id", "AutorId", "IsDeleted", "LibroId" },
                values: new object[,]
                {
                    { 1, 1, false, 1 },
                    { 2, 2, false, 2 },
                    { 3, 3, false, 3 },
                    { 4, 4, false, 4 },
                    { 5, 5, false, 5 },
                    { 6, 6, false, 6 },
                    { 7, 7, false, 7 },
                    { 8, 8, false, 8 },
                    { 9, 9, false, 9 },
                    { 10, 10, false, 10 }
                });

            migrationBuilder.InsertData(
                table: "LibroGeneros",
                columns: new[] { "Id", "GeneroId", "IsDeleted", "LibroId" },
                values: new object[,]
                {
                    { 1, 1, false, 1 },
                    { 2, 2, false, 2 },
                    { 3, 3, false, 3 },
                    { 4, 4, false, 4 },
                    { 5, 5, false, 5 },
                    { 6, 6, false, 6 },
                    { 7, 7, false, 7 },
                    { 8, 8, false, 8 },
                    { 9, 9, false, 9 },
                    { 10, 10, false, 10 }
                });

            migrationBuilder.InsertData(
                table: "Prestamos",
                columns: new[] { "Id", "EjemplarId", "FechaDevolucion", "FechaPrestamo", "IsDeleted", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 29, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(548), new DateTime(2025, 8, 22, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(541), false, 1 },
                    { 2, 2, new DateTime(2025, 8, 30, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(551), new DateTime(2025, 8, 23, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(550), false, 2 },
                    { 3, 3, new DateTime(2025, 8, 31, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(553), new DateTime(2025, 8, 24, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(553), false, 3 },
                    { 4, 4, new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(556), new DateTime(2025, 8, 25, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(555), false, 4 },
                    { 5, 5, new DateTime(2025, 9, 2, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(558), new DateTime(2025, 8, 26, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(557), false, 5 },
                    { 6, 6, new DateTime(2025, 9, 3, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(560), new DateTime(2025, 8, 27, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(559), false, 6 },
                    { 7, 7, new DateTime(2025, 9, 4, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(562), new DateTime(2025, 8, 28, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(561), false, 7 },
                    { 8, 8, new DateTime(2025, 9, 5, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(564), new DateTime(2025, 8, 29, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(563), false, 8 },
                    { 9, 9, new DateTime(2025, 9, 6, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(566), new DateTime(2025, 8, 30, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(566), false, 9 },
                    { 10, 10, new DateTime(2025, 9, 7, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(568), new DateTime(2025, 8, 31, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(568), false, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_LibroId",
                table: "Ejemplares",
                column: "LibroId");

            migrationBuilder.CreateIndex(
                name: "IX_LibroAutores_AutorId",
                table: "LibroAutores",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_LibroAutores_LibroId",
                table: "LibroAutores",
                column: "LibroId");

            migrationBuilder.CreateIndex(
                name: "IX_LibroGeneros_GeneroId",
                table: "LibroGeneros",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_LibroGeneros_LibroId",
                table: "LibroGeneros",
                column: "LibroId");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_EditorialId",
                table: "Libros",
                column: "EditorialId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_EjemplarId",
                table: "Prestamos",
                column: "EjemplarId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_UsuarioId",
                table: "Prestamos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioCarreras_CarreraId",
                table: "UsuarioCarreras",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioCarreras_UsuarioId",
                table: "UsuarioCarreras",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibroAutores");

            migrationBuilder.DropTable(
                name: "LibroGeneros");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "UsuarioCarreras");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Ejemplares");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Editoriales");
        }
    }
}
