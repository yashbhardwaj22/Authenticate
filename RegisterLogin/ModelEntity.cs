﻿using Microsoft.EntityFrameworkCore;
using Authenticate.DAL;

namespace Authenticate
{
    public class ModelEntity:DbContext
    {       
        public DbSet<Login> LoginTable { get; set; }
        
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BUVPTNA\;Initial Catalog=registration;Integrated Security=True;");
            
        }

    }
}
