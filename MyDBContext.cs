using Core_Project_R47.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Project_R47.Context
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> g)
            : base(g)
        {
        }
        public DbSet<dept2> dept2 { get; set; }
        public DbSet<items2> items2 { get; set; }
        public DbSet<Students> students { get; set; }
        public DbSet<StudentAddress> studentsaddress { get; set; }

    }
}
