using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_SapirTeper_OfirEinhoren.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace FinalProject_SapirTeper_OfirEinhoren.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
