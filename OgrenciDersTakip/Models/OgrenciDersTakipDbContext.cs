using OgrenciDersTakip.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OgrenciDersTakip.Models
{
    public class OgrenciDersTakipDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Lesson> Lesson { get; set; }

        public OgrenciDersTakipDbContext() : base(@"Data Source=PCASK\MSSQLSERVER2016D;Initial Catalog=OgrenciDersTakip;Integrated Security=True")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OgrenciDersTakipDbContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}