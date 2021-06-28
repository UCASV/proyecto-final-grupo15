using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto_POO.MySqlContext
{
    public partial class ProyectoContext : DbContext
    {
        public ProyectoContext()
        {
        }

        public ProyectoContext(DbContextOptions<ProyectoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Appointmentxemployee> Appointmentxemployees { get; set; }
        public virtual DbSet<Booth> Booths { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Diseasexcitizen> Diseasexcitizens { get; set; }
        public virtual DbSet<Dose> Doses { get; set; }
        public virtual DbSet<Effectsxcitizen> Effectsxcitizens { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<ReservationPlatform> ReservationPlatforms { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<Statistic> Statistics { get; set; }
        public virtual DbSet<Statisticsxappointment> Statisticsxappointments { get; set; }
        public virtual DbSet<VaccinationPlace> VaccinationPlaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=Proyecto;Username=root;Password=admin123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.IdAppointment)
                    .HasName("PRIMARY");

                entity.ToTable("appointment");

                entity.HasIndex(e => e.IdCitizen, "id_citizen");

                entity.HasIndex(e => e.IdDose, "id_dose");

                entity.HasIndex(e => e.IdManager, "id_manager");

                entity.HasIndex(e => e.IdPlace, "id_place");

                entity.HasIndex(e => e.IdPlatform, "id_platform");

                entity.Property(e => e.IdAppointment).HasColumnName("id_appointment");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnType("date")
                    .HasColumnName("appointment_date");

                entity.Property(e => e.AppointmentHour).HasColumnName("appointment_hour");

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.Property(e => e.IdDose).HasColumnName("id_dose");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.IdPlace).HasColumnName("id_place");

                entity.Property(e => e.IdPlatform).HasColumnName("id_platform");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdCitizen)
                    .HasConstraintName("appointment_ibfk_5");

                entity.HasOne(d => d.IdDoseNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdDose)
                    .HasConstraintName("appointment_ibfk_1");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdManager)
                    .HasConstraintName("appointment_ibfk_3");

                entity.HasOne(d => d.IdPlaceNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdPlace)
                    .HasConstraintName("appointment_ibfk_4");

                entity.HasOne(d => d.IdPlatformNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdPlatform)
                    .HasConstraintName("appointment_ibfk_2");
            });

            modelBuilder.Entity<Appointmentxemployee>(entity =>
            {
                entity.HasKey(e => new { e.IdAppointment, e.IdEmployee })
                    .HasName("PRIMARY");

                entity.ToTable("appointmentxemployee");

                entity.HasIndex(e => e.IdEmployee, "id_employee");

                entity.Property(e => e.IdAppointment).HasColumnName("id_appointment");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.HasOne(d => d.IdAppointmentNavigation)
                    .WithMany(p => p.Appointmentxemployees)
                    .HasForeignKey(d => d.IdAppointment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appointmentxemployee_ibfk_1");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Appointmentxemployees)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appointmentxemployee_ibfk_2");
            });

            modelBuilder.Entity<Booth>(entity =>
            {
                entity.HasKey(e => e.IdBooth)
                    .HasName("PRIMARY");

                entity.ToTable("booth");

                entity.HasIndex(e => e.IdManager, "id_manager");

                entity.Property(e => e.IdBooth).HasColumnName("id_booth");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("email");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Booths)
                    .HasForeignKey(d => d.IdManager)
                    .HasConstraintName("booth_ibfk_1");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PRIMARY");

                entity.ToTable("citizen");

                entity.HasIndex(e => e.IdInstitution, "id_institution");

                entity.Property(e => e.Dui).HasColumnName("DUI");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("birthdate");

                entity.Property(e => e.CitizenName)
                    .HasMaxLength(50)
                    .HasColumnName("citizen_name");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.IdInstitution).HasColumnName("id_institution");

                entity.Property(e => e.IdentifierNumber).HasColumnName("identifier_number");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.HasOne(d => d.IdInstitutionNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdInstitution)
                    .HasConstraintName("citizen_ibfk_1");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.HasKey(e => e.IdDisease)
                    .HasName("PRIMARY");

                entity.ToTable("disease");

                entity.Property(e => e.IdDisease).HasColumnName("id_disease");

                entity.Property(e => e.ChronicDisease)
                    .HasMaxLength(70)
                    .HasColumnName("chronic_disease");
            });

            modelBuilder.Entity<Diseasexcitizen>(entity =>
            {
                entity.HasKey(e => new { e.IdDisease, e.IdCitizen })
                    .HasName("PRIMARY");

                entity.ToTable("diseasexcitizen");

                entity.HasIndex(e => e.IdCitizen, "id_citizen");

                entity.Property(e => e.IdDisease).HasColumnName("id_disease");

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Diseasexcitizens)
                    .HasForeignKey(d => d.IdCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("diseasexcitizen_ibfk_2");

                entity.HasOne(d => d.IdDiseaseNavigation)
                    .WithMany(p => p.Diseasexcitizens)
                    .HasForeignKey(d => d.IdDisease)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("diseasexcitizen_ibfk_1");
            });

            modelBuilder.Entity<Dose>(entity =>
            {
                entity.HasKey(e => e.IdDose)
                    .HasName("PRIMARY");

                entity.ToTable("dose");

                entity.Property(e => e.IdDose).HasColumnName("id_dose");

                entity.Property(e => e.Dose1)
                    .HasMaxLength(30)
                    .HasColumnName("dose");
            });

            modelBuilder.Entity<Effectsxcitizen>(entity =>
            {
                entity.HasKey(e => new { e.IdEffect, e.IdCitizen })
                    .HasName("PRIMARY");

                entity.ToTable("effectsxcitizen");

                entity.HasIndex(e => e.IdCitizen, "id_citizen");

                entity.Property(e => e.IdEffect).HasColumnName("id_effect");

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Effectsxcitizens)
                    .HasForeignKey(d => d.IdCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("effectsxcitizen_ibfk_2");

                entity.HasOne(d => d.IdEffectNavigation)
                    .WithMany(p => p.Effectsxcitizens)
                    .HasForeignKey(d => d.IdEffect)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("effectsxcitizen_ibfk_1");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PRIMARY");

                entity.ToTable("employee");

                entity.HasIndex(e => e.IdType, "id_type");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasColumnName("address");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(60)
                    .HasColumnName("employee_name");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.InstitutionalEmail)
                    .HasMaxLength(200)
                    .HasColumnName("institutional_email");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdType)
                    .HasConstraintName("employee_ibfk_1");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PRIMARY");

                entity.ToTable("employee_type");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.EmployeeType1)
                    .HasMaxLength(30)
                    .HasColumnName("employee_type");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.HasKey(e => e.IdInstitution)
                    .HasName("PRIMARY");

                entity.ToTable("institution");

                entity.Property(e => e.IdInstitution).HasColumnName("id_institution");

                entity.Property(e => e.InstitutionName)
                    .HasMaxLength(40)
                    .HasColumnName("institution_name");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.HasKey(e => e.IdManager)
                    .HasName("PRIMARY");

                entity.ToTable("manager");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.InstitutionalEmail)
                    .HasMaxLength(150)
                    .HasColumnName("institutional_email");

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(70)
                    .HasColumnName("manager_name");

                entity.Property(e => e.ManagerPassword)
                    .HasMaxLength(100)
                    .HasColumnName("manager_password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Record>(entity =>
            {
                entity.HasKey(e => e.IdRecord)
                    .HasName("PRIMARY");

                entity.ToTable("record");

                entity.HasIndex(e => e.IdBooth, "id_booth");

                entity.HasIndex(e => e.IdManager, "id_manager");

                entity.Property(e => e.IdRecord).HasColumnName("id_record");

                entity.Property(e => e.IdBooth).HasColumnName("id_booth");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.RecordDate)
                    .HasColumnType("date")
                    .HasColumnName("record_date");

                entity.Property(e => e.RecordHour).HasColumnName("record_hour");

                entity.HasOne(d => d.IdBoothNavigation)
                    .WithMany(p => p.Records)
                    .HasForeignKey(d => d.IdBooth)
                    .HasConstraintName("record_ibfk_2");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Records)
                    .HasForeignKey(d => d.IdManager)
                    .HasConstraintName("record_ibfk_1");
            });

            modelBuilder.Entity<ReservationPlatform>(entity =>
            {
                entity.HasKey(e => e.IdPlatform)
                    .HasName("PRIMARY");

                entity.ToTable("reservation_platform");

                entity.Property(e => e.IdPlatform).HasColumnName("id_platform");

                entity.Property(e => e.Platform)
                    .HasMaxLength(50)
                    .HasColumnName("platform");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.HasKey(e => e.IdEffect)
                    .HasName("PRIMARY");

                entity.ToTable("side_effects");

                entity.Property(e => e.IdEffect).HasColumnName("id_effect");

                entity.Property(e => e.SideEffect1)
                    .HasMaxLength(60)
                    .HasColumnName("side_effect");
            });

            modelBuilder.Entity<Statistic>(entity =>
            {
                entity.HasKey(e => e.IdStatistic)
                    .HasName("PRIMARY");

                entity.ToTable("statistics");

                entity.Property(e => e.IdStatistic).HasColumnName("id_statistic");

                entity.Property(e => e.IdCita).HasColumnName("id_cita");

                entity.Property(e => e.StatisticDate)
                    .HasColumnType("date")
                    .HasColumnName("statistic_date");

                entity.Property(e => e.StatisticHour).HasColumnName("statistic_hour");
            });

            modelBuilder.Entity<Statisticsxappointment>(entity =>
            {
                entity.HasKey(e => new { e.IdStatistics, e.IdAppointment })
                    .HasName("PRIMARY");

                entity.ToTable("statisticsxappointment");

                entity.HasIndex(e => e.IdAppointment, "id_appointment");

                entity.Property(e => e.IdStatistics).HasColumnName("id_statistics");

                entity.Property(e => e.IdAppointment).HasColumnName("id_appointment");

                entity.HasOne(d => d.IdAppointmentNavigation)
                    .WithMany(p => p.Statisticsxappointments)
                    .HasForeignKey(d => d.IdAppointment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("statisticsxappointment_ibfk_2");

                entity.HasOne(d => d.IdStatisticsNavigation)
                    .WithMany(p => p.Statisticsxappointments)
                    .HasForeignKey(d => d.IdStatistics)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("statisticsxappointment_ibfk_1");
            });

            modelBuilder.Entity<VaccinationPlace>(entity =>
            {
                entity.HasKey(e => e.IdPlace)
                    .HasName("PRIMARY");

                entity.ToTable("vaccination_place");

                entity.Property(e => e.IdPlace).HasColumnName("id_place");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(200)
                    .HasColumnName("place_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
