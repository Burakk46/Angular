using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("name=baglanti") { }
        public DbSet<Student> Students { get; set; }
    }
}