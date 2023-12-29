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


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite($"Data source={path}");    
            }

           

            public bool ObjectExists(string usernameToCheck)
            {
                return UporabnikDB.Any(u => u.Username == usernameToCheck);
            }

            public bool PasswordMatch(string password)
        {
            return UporabnikDB.Any(p => p.Geslo == password);
        }




    }
}

