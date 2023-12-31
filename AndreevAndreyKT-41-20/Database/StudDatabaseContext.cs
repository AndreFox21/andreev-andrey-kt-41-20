﻿using AndreevAndreyKT_41_20.Database.Configurations;
using AndreevAndreyKT_41_20.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AndreevAndreyKT_41_20.Database
{
    public class StudDatabaseContext : DbContext
    {
        //таблицы
        DbSet<Student> Students { get; set; }
        DbSet<AcademGroup> AcademGroups { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //конфигурации таблиц
            modelBuilder.ApplyConfiguration(new DbConf_Student());
            modelBuilder.ApplyConfiguration(new DbConf_AcademGroup());
        }

        public StudDatabaseContext(DbContextOptions<StudDatabaseContext> options) : base(options)
        {

        }
    }
}
