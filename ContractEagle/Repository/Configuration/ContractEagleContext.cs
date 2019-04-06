using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository.Configuration
{
        public class ContractEagleContext : DbContext
        {
            public DbSet<Document> Document { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Exercicios\ContractEagle\ContractEagle\Repository\ContractEagle.mdf;Integrated Security=True");
            }
        }
    }