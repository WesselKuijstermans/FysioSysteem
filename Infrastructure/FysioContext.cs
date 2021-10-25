using System;
using System.Collections.Generic;
using DomainModel.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure {
    public class FysioContext : DbContext {
        public DbSet<PatientFileModel> PatientFiles { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<RemarkModel> Remarks { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<TherapistModel> Therapists { get; set; }
        public DbSet<TreatmentModel> Treatments { get; set; }


        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        public FysioContext(DbContextOptions<FysioContext> contextOptions) : base(contextOptions) {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PatientFileModel>().ToTable("Patient_Files");
            modelBuilder.Entity<PatientModel>().ToTable("Patients");
            modelBuilder.Entity<RemarkModel>().ToTable("Remarks");
            modelBuilder.Entity<StudentModel>().ToTable("Students");
            modelBuilder.Entity<TherapistModel>().ToTable("Therapists");
            modelBuilder.Entity<TreatmentModel>().ToTable("Treatments");
        }
    }
}