﻿using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext:DbContext
    {

        public NZWalksDbContext(DbContextOptions<NZWalksDbContext>options):base(options)
        {
       
        }
       
            
        public DbSet<Region>Regions { get; set; }   

        public DbSet<Walks> Walks { get; set; } 

        public DbSet<WalkDifficulty> WalksDifficulties { get; set; }

    }
    
    
}
