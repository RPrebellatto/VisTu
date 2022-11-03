using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisTu.Migrations.VisTu
{
    public partial class TesteSeedRoles : Migration
    {
        //private string AdminRoleId = Guid.NewGuid().ToString();
        //private string UserRoleId = Guid.NewGuid().ToString();

        //private string User1Id = Guid.NewGuid().ToString();
        //private string User2Id = Guid.NewGuid().ToString();

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedRolesMySql(migrationBuilder);
            SeedUser(migrationBuilder);

        }

        private void SeedRolesMySql(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @$"INSERT INTO vistu.aspnetroles
                ( Name, NormalizedName, ConcurrencyStamp)
                VALUES( 'Administrador', 'ADMINISTRADOR', NULL)"
                );
            migrationBuilder.Sql(
                @$"INSERT INTO vistu.aspnetroles
                ( Name, NormalizedName, ConcurrencyStamp)
                VALUES( 'Usuario', 'USUARIO', NULL)"
                );
        }

        private void SeedUser(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @$"INSERT INTO vistu.aspnetroles
                ( Name, NormalizedName, ConcurrencyStamp)
                VALUES( 'Administrador', 'ADMINISTRADOR', NULL)"
                );
            migrationBuilder.Sql(
                @$"INSERT INTO vistu.aspnetusers
(Nome, Sobrenome, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount)
VALUES('ADMIN', 'ADMIN', 'ADMIN', 'ADMIN', 'admin@email.com', '', 0, '', '', '', '', 0, 0, '', 0, 0);
"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
