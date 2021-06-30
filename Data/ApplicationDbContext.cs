﻿using Microsoft.EntityFrameworkCore;
using RVLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RVLife.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }

    }
}
