using System;
using Microsoft.EntityFrameworkCore;

namespace MediaMvc.Models 
{
    public class MediaContext : DbContext
    {
        public MediaContext(DbContextOptions<MediaContext> options) : base(options)
        {
        }

        public DbSet<Image> Images { get; set; }

        public DbSet<Video> Videos { get; set; }

    }
}
