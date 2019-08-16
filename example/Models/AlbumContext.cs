using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;

namespace example.Models
{
    public class AlbumContext : DbContext
    {
        public AlbumContext() : base("AlbumData")
        {

        }
        public DbSet<Album> albums { get; set; }
        public DbSet<reviews> reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}