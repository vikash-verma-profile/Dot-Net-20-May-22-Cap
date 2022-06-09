using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication2.Models
{
    public partial class SampleDBContext : DbContext
    {
        public SampleDBContext()
        {
        }

        public SampleDBContext(DbContextOptions<SampleDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCourse> TblCourses { get; set; }
        public virtual DbSet<TblStudent> TblStudents { get; set; }
        public virtual DbSet<Tblsample> Tblsamples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-K03RJGO\\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblCourse>(entity =>
            {
                entity.ToTable("tblCourse");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblStudent>(entity =>
            {
                entity.ToTable("tblStudent");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblsample>(entity =>
            {
                entity.ToTable("tblsample");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
