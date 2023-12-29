﻿using ClassDiagramCODScout;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RGIS_WebApp
{
    public class Database : DbContext
    {
        
            string path = @"C:\Users\MATEJ\source\repos\RGIS_WebApp\RGIS_WebApp\Database";
            public Database() { }
            public DbSet<Uporabnik> UporabnikDB { get; set; }
            public DbSet<Stats> PremiumUporabnikDB { get; set; }
            public DbSet<Moderator> ModeratorDB { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite($"Data source={path}");
            }

           
            



        
    }
}

