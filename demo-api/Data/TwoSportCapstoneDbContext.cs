using demo_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.api.Data
{
    public class TwoSportCapstoneDbContext : DbContext
    {

        public TwoSportCapstoneDbContext() { }

        public TwoSportCapstoneDbContext(DbContextOptions<TwoSportCapstoneDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Brand> Brands { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(GetConnectionStrings());
        //    }
        //}

        //private string GetConnectionStrings()
        //{
        //    IConfiguration config = new ConfigurationBuilder()
        //     .SetBasePath(Directory.GetCurrentDirectory())
        //    .AddJsonFile("appsettings.json", true, true)
        //    .Build();
        //    var strConn = config["ConnectionStrings:DefaultConnection"];

        //    return strConn;
        //}
    }
}
