using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Therapists",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapists", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Files",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    illnessDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diagnoseCodeAndDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isStudent = table.Column<bool>(type: "bit", nullable: false),
                    intakeDoneByEmail = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    intakeSupervisedByEmail = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MainTherapistEmail = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    dateOfSignUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateOfDismissal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    treatmentPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    treatments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Files", x => x.id);
                    table.ForeignKey(
                        name: "FK_Patient_Files_Therapists_intakeDoneByEmail",
                        column: x => x.intakeDoneByEmail,
                        principalTable: "Therapists",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_Files_Therapists_intakeSupervisedByEmail",
                        column: x => x.intakeSupervisedByEmail,
                        principalTable: "Therapists",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_Files_Therapists_MainTherapistEmail",
                        column: x => x.MainTherapistEmail,
                        principalTable: "Therapists",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientFileid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Email);
                    table.ForeignKey(
                        name: "FK_Patients_Patient_Files_PatientFileid",
                        column: x => x.PatientFileid,
                        principalTable: "Patient_Files",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Files_intakeDoneByEmail",
                table: "Patient_Files",
                column: "intakeDoneByEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Files_intakeSupervisedByEmail",
                table: "Patient_Files",
                column: "intakeSupervisedByEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Files_MainTherapistEmail",
                table: "Patient_Files",
                column: "MainTherapistEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientFileid",
                table: "Patients",
                column: "PatientFileid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Patient_Files");

            migrationBuilder.DropTable(
                name: "Therapists");
        }
    }
}
