﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NexCrypto.Models;

namespace NexCrypto.Data
{
    public class NexCryptoContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-SK1M2S4\\MSSQLSERVER01;Initial Catalog=BikeShopTestz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
