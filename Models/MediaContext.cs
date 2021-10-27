using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MediaAPI.Models
{
    public class MediaContext : DbContext
    {
        public MediaContext(DbContextOptions<MediaContext> opt) : base(opt) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
