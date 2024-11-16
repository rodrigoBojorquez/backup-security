﻿
using ApplicationCore.Interfaces;
using Domain.Entities;
using Finbuckle.MultiTenant;
using Infraestructure.Services;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext(ITenantInfo currentTenant, DbContextOptions options, ICurrentUserService currentUser)
            : base(currentTenant, options, currentUser)
        {

        }

        public DbSet<persona> persona {  get; set; }
        public DbSet<logs> logs { get; set; }
        public DbSet<jugador> jugador { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Administrative> Administratives { get; set; }
        public DbSet<Colaborator> Colaborators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }      
    }
}
