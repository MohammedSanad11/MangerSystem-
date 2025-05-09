using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace DomainLayer.Data
{
    public class MangementSystemDbContext : IdentityDbContext<AppUser>
    {
        public MangementSystemDbContext(DbContextOptions<MangementSystemDbContext> options) :base(options) {}
        protected override void OnModelCreating(ModelBuilder builder)
        { 
           base.OnModelCreating(builder);
        }

        public DbSet<Student> studentsModel { get; set; }    

        public DbSet<Department> DepartmentsModel { get; set; }

        public DbSet<Resules1> ResultsModelModel { get; set; }

        public DbSet<SubjectGpa> SubjectGpasModel { get; set; }
        

    }
}
