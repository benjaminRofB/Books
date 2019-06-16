using System;
using System.Data.Entity;

namespace Books
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnection")
        {
        }

        public DbSet<Name> Names { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
