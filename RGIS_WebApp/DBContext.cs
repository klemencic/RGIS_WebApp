using ClassDiagramCODScout;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RGIS_WebApp
{
    public class Database : DbContext
    {
        
            string path = "Database.db";
            public Database() { }
            public DbSet<Uporabnik> UporabnikDB { get; set; }
            public DbSet<Stats> StatsDB { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite($"Data source={path}");
            }

           
            



        
    }
}

