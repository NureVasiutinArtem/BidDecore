﻿using BidDecore.Models;
using Microsoft.EntityFrameworkCore;

namespace BidDecore.Database
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
