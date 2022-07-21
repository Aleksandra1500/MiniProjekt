using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt.DAL
{
    public class DbAdresses : DbContext
    {
        public DbAdresses() { }
        public DbSet<Adress> Adresy { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("C:\\Users\\Alex_\\OneDrive\\Dokumenty\\Staż\\MiniProjekt\\MiniProjekt\\cnstring.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("cnE"));
                //optionsBuilder.UseSqlServer(@"Data Source=.\enova;Initial Catalog=Firma_demo;Integrated Security=True");
            }
        }
    }
}