using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperDrogueriaFenix.Data.Migrations
{
    public partial class rnorigdeveloper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoTienda_Cliente_ClienteIdCliente",
                table: "ProductoTienda");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoTienda_Tienda_TiendaIdTienda",
                table: "ProductoTienda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tienda",
                table: "Tienda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoTienda",
                table: "ProductoTienda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Iniciado",
                table: "ProductoTienda");

            migrationBuilder.RenameTable(
                name: "Tienda",
                newName: "Tiendas");

            migrationBuilder.RenameTable(
                name: "ProductoTienda",
                newName: "ProductoTiendas");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoTienda_TiendaIdTienda",
                table: "ProductoTiendas",
                newName: "IX_ProductoTiendas_TiendaIdTienda");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoTienda_ClienteIdCliente",
                table: "ProductoTiendas",
                newName: "IX_ProductoTiendas_ClienteIdCliente");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Tiendas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "RUC",
                table: "Tiendas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tiendas",
                table: "Tiendas",
                column: "IdTienda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoTiendas",
                table: "ProductoTiendas",
                column: "IdProductoTienda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoTiendas_Clientes_ClienteIdCliente",
                table: "ProductoTiendas",
                column: "ClienteIdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoTiendas_Tiendas_TiendaIdTienda",
                table: "ProductoTiendas",
                column: "TiendaIdTienda",
                principalTable: "Tiendas",
                principalColumn: "IdTienda",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoTiendas_Clientes_ClienteIdCliente",
                table: "ProductoTiendas");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoTiendas_Tiendas_TiendaIdTienda",
                table: "ProductoTiendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tiendas",
                table: "Tiendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoTiendas",
                table: "ProductoTiendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Tiendas",
                newName: "Tienda");

            migrationBuilder.RenameTable(
                name: "ProductoTiendas",
                newName: "ProductoTienda");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoTiendas_TiendaIdTienda",
                table: "ProductoTienda",
                newName: "IX_ProductoTienda_TiendaIdTienda");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoTiendas_ClienteIdCliente",
                table: "ProductoTienda",
                newName: "IX_ProductoTienda_ClienteIdCliente");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Tienda",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "RUC",
                table: "Tienda",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<bool>(
                name: "Iniciado",
                table: "ProductoTienda",
                type: "bit",
                maxLength: 30,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tienda",
                table: "Tienda",
                column: "IdTienda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoTienda",
                table: "ProductoTienda",
                column: "IdProductoTienda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoTienda_Cliente_ClienteIdCliente",
                table: "ProductoTienda",
                column: "ClienteIdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoTienda_Tienda_TiendaIdTienda",
                table: "ProductoTienda",
                column: "TiendaIdTienda",
                principalTable: "Tienda",
                principalColumn: "IdTienda",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
