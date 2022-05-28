using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarjCredito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LimitCredito = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TandaLabor = table.Column<int>(type: "int", nullable: false),
                    PorcientoComision = table.Column<double>(type: "float", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCombustibles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCombustibles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposVehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposVehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    MarcasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelos_Marcas_MarcasId",
                        column: x => x.MarcasId,
                        principalTable: "Marcas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NChasis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NMotor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NPlaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiposVehiculosId = table.Column<int>(type: "int", nullable: true),
                    MarcasId = table.Column<int>(type: "int", nullable: true),
                    ModelosId = table.Column<int>(type: "int", nullable: true),
                    TiposCombustiblesId = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Marcas_MarcasId",
                        column: x => x.MarcasId,
                        principalTable: "Marcas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Modelos_ModelosId",
                        column: x => x.ModelosId,
                        principalTable: "Modelos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculos_TiposCombustibles_TiposCombustiblesId",
                        column: x => x.TiposCombustiblesId,
                        principalTable: "TiposCombustibles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculos_TiposVehiculos_TiposVehiculosId",
                        column: x => x.TiposVehiculosId,
                        principalTable: "TiposVehiculos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inspeccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiculosId = table.Column<int>(type: "int", nullable: true),
                    ClientesId = table.Column<int>(type: "int", nullable: true),
                    Ralladuras = table.Column<bool>(type: "bit", nullable: false),
                    CantidaCombustible = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    GomaRespuesta = table.Column<bool>(type: "bit", nullable: false),
                    Gato = table.Column<bool>(type: "bit", nullable: false),
                    RoturaCristal = table.Column<bool>(type: "bit", nullable: false),
                    GomaDelanteraLeft = table.Column<bool>(type: "bit", nullable: false),
                    GomaDelanteraRight = table.Column<bool>(type: "bit", nullable: false),
                    GomaTraseraLeft = table.Column<bool>(type: "bit", nullable: false),
                    GomaTraseraRight = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadosId = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspeccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inspeccion_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inspeccion_Empleados_EmpleadosId",
                        column: x => x.EmpleadosId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inspeccion_Vehiculos_VehiculosId",
                        column: x => x.VehiculosId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RentaDevolucion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Renta = table.Column<int>(type: "int", nullable: false),
                    EmpleadosId = table.Column<int>(type: "int", nullable: false),
                    VehiculosId = table.Column<int>(type: "int", nullable: true),
                    ClientesId = table.Column<int>(type: "int", nullable: true),
                    FechaRenta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoDia = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    CantidadDias = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentaDevolucion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentaDevolucion_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RentaDevolucion_Empleados_EmpleadosId",
                        column: x => x.EmpleadosId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentaDevolucion_Vehiculos_VehiculosId",
                        column: x => x.VehiculosId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_ClientesId",
                table: "Inspeccion",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_EmpleadosId",
                table: "Inspeccion",
                column: "EmpleadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_VehiculosId",
                table: "Inspeccion",
                column: "VehiculosId");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MarcasId",
                table: "Modelos",
                column: "MarcasId");

            migrationBuilder.CreateIndex(
                name: "IX_RentaDevolucion_ClientesId",
                table: "RentaDevolucion",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_RentaDevolucion_EmpleadosId",
                table: "RentaDevolucion",
                column: "EmpleadosId");

            migrationBuilder.CreateIndex(
                name: "IX_RentaDevolucion_VehiculosId",
                table: "RentaDevolucion",
                column: "VehiculosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_MarcasId",
                table: "Vehiculos",
                column: "MarcasId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ModelosId",
                table: "Vehiculos",
                column: "ModelosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TiposCombustiblesId",
                table: "Vehiculos",
                column: "TiposCombustiblesId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TiposVehiculosId",
                table: "Vehiculos",
                column: "TiposVehiculosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inspeccion");

            migrationBuilder.DropTable(
                name: "RentaDevolucion");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "TiposCombustibles");

            migrationBuilder.DropTable(
                name: "TiposVehiculos");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
