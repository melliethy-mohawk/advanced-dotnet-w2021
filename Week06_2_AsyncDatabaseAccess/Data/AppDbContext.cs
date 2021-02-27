﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Week06_2_AsyncDatabaseAccess.Models;

namespace Week06_2_AsyncDatabaseAccess.Data
{
    /// <summary>
    /// Represents the database context for the application.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    class AppDbContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=PersonDb;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(connectionString);
        }



        /// <summary>
        /// Gets or sets the persons.
        /// </summary>
        /// <remarks>You will need one DbSet for each model that you want to be ported to the database as a table</remarks>
        public DbSet<Person> Persons { get; set; }

    }
}