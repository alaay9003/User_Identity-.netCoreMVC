using Microsoft.EntityFrameworkCore.Migrations;

namespace User_Identity_.netCore.Data.Migrations
{
    public partial class asignadminallrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles] (UserId,RoleId) SELECT 'f10c5ba4-cbf2-47bc-9da8-712031862be3',Id FROM [security].[Roles]");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserID = 'f10c5ba4-cbf2-47bc-9da8-712031862be3'");
        }
    }
}
