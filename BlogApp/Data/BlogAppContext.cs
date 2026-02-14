using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogApp.Models;

namespace BlogApp.Data
{
    public class BlogAppContext : DbContext
    {
        public BlogAppContext (DbContextOptions<BlogAppContext> options)
            : base(options)
        {
        }

        public DbSet<BlogApp.Models.Post> Post { get; set; } = default!;
    }
}
