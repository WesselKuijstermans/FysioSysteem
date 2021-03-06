// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(FysioContext))]
    [Migration("20211005141315_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainModel.Models.Patient", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientFileid")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.HasIndex("PatientFileid");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DomainModel.Models.PatientFile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MainTherapistEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateOfDismissal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateOfSignUp")
                        .HasColumnType("datetime2");

                    b.Property<string>("diagnoseCodeAndDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("illnessDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("intakeDoneByEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("intakeSupervisedByEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("isStudent")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("treatmentPlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("treatments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("MainTherapistEmail");

                    b.HasIndex("intakeDoneByEmail");

                    b.HasIndex("intakeSupervisedByEmail");

                    b.ToTable("Patient_Files");
                });

            modelBuilder.Entity("DomainModel.Models.Therapist", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("Therapists");
                });

            modelBuilder.Entity("DomainModel.Models.Patient", b =>
                {
                    b.HasOne("DomainModel.Models.PatientFile", "PatientFile")
                        .WithMany()
                        .HasForeignKey("PatientFileid");

                    b.Navigation("PatientFile");
                });

            modelBuilder.Entity("DomainModel.Models.PatientFile", b =>
                {
                    b.HasOne("DomainModel.Models.Therapist", "MainTherapist")
                        .WithMany()
                        .HasForeignKey("MainTherapistEmail");

                    b.HasOne("DomainModel.Models.Therapist", "intakeDoneBy")
                        .WithMany()
                        .HasForeignKey("intakeDoneByEmail");

                    b.HasOne("DomainModel.Models.Therapist", "intakeSupervisedBy")
                        .WithMany()
                        .HasForeignKey("intakeSupervisedByEmail");

                    b.Navigation("intakeDoneBy");

                    b.Navigation("intakeSupervisedBy");

                    b.Navigation("MainTherapist");
                });
#pragma warning restore 612, 618
        }
    }
}
