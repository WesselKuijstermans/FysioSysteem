using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class DomainUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Files_Therapists_intakeDoneByEmail",
                table: "Patient_Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Files_Therapists_intakeSupervisedByEmail",
                table: "Patient_Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Patient_Files_PatientFileid",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "remarks",
                table: "Patient_Files");

            migrationBuilder.DropColumn(
                name: "treatments",
                table: "Patient_Files");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Therapists",
                newName: "Availability");

            migrationBuilder.RenameColumn(
                name: "PatientFileid",
                table: "Patients",
                newName: "PatientFileId");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Patients",
                newName: "Picture");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Patients",
                newName: "Gender");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_PatientFileid",
                table: "Patients",
                newName: "IX_Patients_PatientFileId");

            migrationBuilder.RenameColumn(
                name: "treatmentPlan",
                table: "Patient_Files",
                newName: "TreatmentPlan");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Patient_Files",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isStudent",
                table: "Patient_Files",
                newName: "IsStudent");

            migrationBuilder.RenameColumn(
                name: "intakeSupervisedByEmail",
                table: "Patient_Files",
                newName: "IntakeSupervisedByEmail");

            migrationBuilder.RenameColumn(
                name: "intakeDoneByEmail",
                table: "Patient_Files",
                newName: "IntakeDoneByEmail");

            migrationBuilder.RenameColumn(
                name: "illnessDescription",
                table: "Patient_Files",
                newName: "IllnessDescription");

            migrationBuilder.RenameColumn(
                name: "diagnoseCodeAndDescription",
                table: "Patient_Files",
                newName: "DiagnoseCodeAndDescription");

            migrationBuilder.RenameColumn(
                name: "dateOfSignUp",
                table: "Patient_Files",
                newName: "DateOfSignUp");

            migrationBuilder.RenameColumn(
                name: "dateOfDismissal",
                table: "Patient_Files",
                newName: "DateOfDismissal");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Patient_Files",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Patient_Files",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Files_intakeSupervisedByEmail",
                table: "Patient_Files",
                newName: "IX_Patient_Files_IntakeSupervisedByEmail");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Files_intakeDoneByEmail",
                table: "Patient_Files",
                newName: "IX_Patient_Files_IntakeDoneByEmail");

            migrationBuilder.AddColumn<int>(
                name: "BIGNumber",
                table: "Therapists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Therapists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Remarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TherapistEmail = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VisibleToPatient = table.Column<bool>(type: "bit", nullable: false),
                    PatientFileModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remarks_Patient_Files_PatientFileModelId",
                        column: x => x.PatientFileModelId,
                        principalTable: "Patient_Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remarks_Therapists_TherapistEmail",
                        column: x => x.TherapistEmail,
                        principalTable: "Therapists",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Email);
                    table.ForeignKey(
                        name: "FK_Students_Persons_Email",
                        column: x => x.Email,
                        principalTable: "Persons",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarkId = table.Column<int>(type: "int", nullable: true),
                    TreatmentByEmail = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TreatmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientFileModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatments_Patient_Files_PatientFileModelId",
                        column: x => x.PatientFileModelId,
                        principalTable: "Patient_Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_Remarks_RemarkId",
                        column: x => x.RemarkId,
                        principalTable: "Remarks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_Therapists_TreatmentByEmail",
                        column: x => x.TreatmentByEmail,
                        principalTable: "Therapists",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_PatientFileModelId",
                table: "Remarks",
                column: "PatientFileModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_TherapistEmail",
                table: "Remarks",
                column: "TherapistEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_PatientFileModelId",
                table: "Treatments",
                column: "PatientFileModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_RemarkId",
                table: "Treatments",
                column: "RemarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_TreatmentByEmail",
                table: "Treatments",
                column: "TreatmentByEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Files_Therapists_IntakeDoneByEmail",
                table: "Patient_Files",
                column: "IntakeDoneByEmail",
                principalTable: "Therapists",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Files_Therapists_IntakeSupervisedByEmail",
                table: "Patient_Files",
                column: "IntakeSupervisedByEmail",
                principalTable: "Therapists",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Patient_Files_PatientFileId",
                table: "Patients",
                column: "PatientFileId",
                principalTable: "Patient_Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Persons_Email",
                table: "Patients",
                column: "Email",
                principalTable: "Persons",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Therapists_Persons_Email",
                table: "Therapists",
                column: "Email",
                principalTable: "Persons",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Files_Therapists_IntakeDoneByEmail",
                table: "Patient_Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Files_Therapists_IntakeSupervisedByEmail",
                table: "Patient_Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Patient_Files_PatientFileId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Persons_Email",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Therapists_Persons_Email",
                table: "Therapists");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Remarks");

            migrationBuilder.DropColumn(
                name: "BIGNumber",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Therapists");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Availability",
                table: "Therapists",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "PatientFileId",
                table: "Patients",
                newName: "PatientFileid");

            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Patients",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Patients",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_PatientFileId",
                table: "Patients",
                newName: "IX_Patients_PatientFileid");

            migrationBuilder.RenameColumn(
                name: "TreatmentPlan",
                table: "Patient_Files",
                newName: "treatmentPlan");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Patient_Files",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsStudent",
                table: "Patient_Files",
                newName: "isStudent");

            migrationBuilder.RenameColumn(
                name: "IntakeSupervisedByEmail",
                table: "Patient_Files",
                newName: "intakeSupervisedByEmail");

            migrationBuilder.RenameColumn(
                name: "IntakeDoneByEmail",
                table: "Patient_Files",
                newName: "intakeDoneByEmail");

            migrationBuilder.RenameColumn(
                name: "IllnessDescription",
                table: "Patient_Files",
                newName: "illnessDescription");

            migrationBuilder.RenameColumn(
                name: "DiagnoseCodeAndDescription",
                table: "Patient_Files",
                newName: "diagnoseCodeAndDescription");

            migrationBuilder.RenameColumn(
                name: "DateOfSignUp",
                table: "Patient_Files",
                newName: "dateOfSignUp");

            migrationBuilder.RenameColumn(
                name: "DateOfDismissal",
                table: "Patient_Files",
                newName: "dateOfDismissal");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Patient_Files",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patient_Files",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Files_IntakeSupervisedByEmail",
                table: "Patient_Files",
                newName: "IX_Patient_Files_intakeSupervisedByEmail");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_Files_IntakeDoneByEmail",
                table: "Patient_Files",
                newName: "IX_Patient_Files_intakeDoneByEmail");

            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "Therapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Therapists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "remarks",
                table: "Patient_Files",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "treatments",
                table: "Patient_Files",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Files_Therapists_intakeDoneByEmail",
                table: "Patient_Files",
                column: "intakeDoneByEmail",
                principalTable: "Therapists",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Files_Therapists_intakeSupervisedByEmail",
                table: "Patient_Files",
                column: "intakeSupervisedByEmail",
                principalTable: "Therapists",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Patient_Files_PatientFileid",
                table: "Patients",
                column: "PatientFileid",
                principalTable: "Patient_Files",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
