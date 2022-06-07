using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ConsoleApp6.Models
{
    public partial class SampleDb1Context : DbContext
    {
        public SampleDb1Context()
        {
        }

        public SampleDb1Context(DbContextOptions<SampleDb1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Sample> Samples { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student1> Students1 { get; set; }
        public virtual DbSet<Studentclass> Studentclasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-K03RJGO\\SQLEXPRESS;Initial Catalog=SampleDb1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("department");

                entity.Property(e => e.Department1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.Property(e => e.Departmentid).HasColumnName("departmentid");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sample");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rollno).HasColumnName("rollno");
            });

            modelBuilder.Entity<Student1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("students");

                entity.Property(e => e.Classid).HasColumnName("classid");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.Rollno).HasColumnName("rollno");
            });

            modelBuilder.Entity<Studentclass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("studentclass");

                entity.Property(e => e.Classname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("classname");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
