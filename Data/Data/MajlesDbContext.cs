using Majles.Data.DbEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majles.Data.Data
{
    public class MajlesDbContext : DbContext
    {
        public DbSet<AttendenceDbEntity> Attendances { get; set; }
        public DbSet<AuthorBookDbEntity> AuthorBooks { get; set; }
        public DbSet<AuthorDbEntity> Authors { get; set; }
        public DbSet<BookCategoryDbEntity> BookCategories { get; set; }
        public DbSet<BookDbEntity> Books { get; set; }
        public DbSet<BookMajlesDbEntity> BookMajles { get; set; }
        public DbSet<CategoryDbEntity> Categories { get; set; }
        public DbSet<LectureDbEntity> Lectures { get; set; }
        public DbSet<MajlesDbEntity> Majles { get; set; }
        public DbSet<MajlesStudentDbEntity> MajlesStudents { get; set; }
        public DbSet<MajlesVolunteerDbEntity> MajlesVolunteers { get; set; }
        public DbSet<MosqeDbEntity> Mosqes { get; set; }
        public DbSet<RegionDbEntity> Regions { get; set; }
        public DbSet<SheikhDbEntity> Sheikhs { get; set; }
        public DbSet<SheikhPhoneDbEntity> SheikhPhones { get; set; }
        public DbSet<StudentDbEntity> Students { get; set; }
        public DbSet<StudentPhoneDbEntity> StudentPhones { get; set; }
        public DbSet<VolunteerDbEntity> Volunteers { get; set; }
        public DbSet<VolunteerPhoneDbEntity> VolunteerPhones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BookCategoryDbEntity>().HasKey(x => new { x.BookId, x.CategoryId });
            modelBuilder.Entity<AttendenceDbEntity>().HasKey(x => new { x.LectureId, x.StudentId });
            modelBuilder.Entity<AuthorBookDbEntity>().HasKey(x => new { x.BookId, x.AuthorId});
            modelBuilder.Entity<BookMajlesDbEntity>().HasKey(x => new { x.BookId, x.MajlesId});
            modelBuilder.Entity<MajlesStudentDbEntity>().HasKey(x => new { x.StudentId, x.MajlesId});
            modelBuilder.Entity<MajlesVolunteerDbEntity>().HasKey(x => new { x.VolunteerId, x.MajlesId});
        }
    }
}
