using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NexCrypto.Models;

namespace NexCrypto.Data
{
    public class NexCryptoContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-SK1M2S4\\MSSQLSERVER01;Initial Catalog=NexCrypto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.UseSqlServer("Data Source=69.10.49.185,1433;Network Library=DBMSSOCN;Initial Catalog=Nex;User ID=yadz;Password=yadz;");
        }
    }
}
