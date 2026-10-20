using HealthCareManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCareManagementSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;DataBase=HealthCareManagmentSystemBD;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasKey(a => new
            {
                a.PatientId,
                a.DoctorId,
                a.AppointmentDate
            });
            modelBuilder.Entity<Appointment>().HasOne(p => p.Patient)
                                              .WithMany(a => a.Appointments)
                                              .HasForeignKey(p => p.PatientId);
            modelBuilder.Entity<Appointment>().HasOne(d => d.Doctor)
                                              .WithMany(a => a.Appointments)
                                              .HasForeignKey(d => d.DoctorId);
                                          
                                              
                                              
            base.OnModelCreating(modelBuilder);
        }
    }
}
