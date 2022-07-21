using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt.DAL
{
    class DbAdresses : DbContext
    {
        public DbSet<Adress> Adresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //IConfiguration configuration = new ConfigurationBuilder()
                //    .SetBasePath(Directory.GetCurrentDirectory())
                //    .AddJsonFile("cnstring.json")
                //    .Build();

                //optionsBuilder.UseSqlServer(configuration.GetConnectionString("cnE"));
            }
        }

        //public static List<Adress> GetAllAdresses()
        //{
        //    var db = new DbAdresses();
        //    var adresses = db.Adresses.ToList();
        //    return adresses;
        //}
    }
}