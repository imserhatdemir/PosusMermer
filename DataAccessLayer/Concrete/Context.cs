using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<About> abouts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Plates> plates { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Blog> blogs { get; set; }
    }
}
