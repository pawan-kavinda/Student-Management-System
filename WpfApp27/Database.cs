using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp27.Model;

namespace WpfApp27
{
    public class Database : DbContext
    {
        public readonly string path = @"D:\WpfApp27\WpfApp27\Database\StudentManagement.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={path}");
        }

        public DbSet<StudentLoginDetails> studetails { get; set; }
        public DbSet<AdminLoginDetails> admintails { get; set; }
        public DbSet<StudentforumModel> stdforum { get; set; }


        public DbSet<AdminforumModel> admforum { get; set; }
       

        public DbSet<Admindetailslogin> loginadmin { get; set; }
    }
}
