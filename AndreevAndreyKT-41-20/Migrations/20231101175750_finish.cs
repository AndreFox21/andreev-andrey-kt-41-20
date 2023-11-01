using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AndreevAndreyKT_41_20.Migrations
{
    /// <inheritdoc />
    public partial class finish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademGroups",
                columns: table => new
                {
                    group_id = table.Column<int>(type: "integer", nullable: false, comment: "ID группы")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    group_name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Название группы"),
                    group_description = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "Описание группы")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_db_AcademGroups_group_id", x => x.group_id);
                });

            migrationBuilder.CreateTable(
                name: "db_Students",
                columns: table => new
                {
                    student_id = table.Column<int>(type: "integer", nullable: false, comment: "ID студента")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    student_name = table.Column<string>(type: "varchar", maxLength: 100, nullable: false, comment: "ФИО студента"),
                    academ_group_id = table.Column<int>(type: "int4", nullable: false, comment: "ID группы"),
                    is_dismissed = table.Column<bool>(type: "bool", nullable: false, comment: "Статус отчисления")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_db_Students_student_id", x => x.student_id);
                    table.ForeignKey(
                        name: "fk_f_academ_group_id",
                        column: x => x.academ_group_id,
                        principalTable: "AcademGroups",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_db_Students_fk_f_academ_group_id",
                table: "db_Students",
                column: "academ_group_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "db_Students");

            migrationBuilder.DropTable(
                name: "AcademGroups");
        }
    }
}
