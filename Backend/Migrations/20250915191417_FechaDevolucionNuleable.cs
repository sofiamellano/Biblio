using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class FechaDevolucionNuleable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDevolucion",
                table: "Prestamos",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 12, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9765), new DateTime(2025, 9, 5, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 13, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9769), new DateTime(2025, 9, 6, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 14, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9771), new DateTime(2025, 9, 7, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9773), new DateTime(2025, 9, 8, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 16, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9775), new DateTime(2025, 9, 9, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 17, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9778), new DateTime(2025, 9, 10, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 18, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9780), new DateTime(2025, 9, 11, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 19, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9783), new DateTime(2025, 9, 12, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 20, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9832), new DateTime(2025, 9, 13, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 21, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9834), new DateTime(2025, 9, 14, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 15, 16, 14, 16, 624, DateTimeKind.Local).AddTicks(9719));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaDevolucion",
                table: "Prestamos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 8, 29, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(548), new DateTime(2025, 8, 22, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 8, 30, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(551), new DateTime(2025, 8, 23, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 8, 31, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(553), new DateTime(2025, 8, 24, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(556), new DateTime(2025, 8, 25, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 2, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(558), new DateTime(2025, 8, 26, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 3, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(560), new DateTime(2025, 8, 27, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 4, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(562), new DateTime(2025, 8, 28, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 5, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(564), new DateTime(2025, 8, 29, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 6, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(566), new DateTime(2025, 8, 30, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 9, 7, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(568), new DateTime(2025, 8, 31, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaRegistracion",
                value: new DateTime(2025, 9, 1, 16, 22, 24, 737, DateTimeKind.Local).AddTicks(506));
        }
    }
}
