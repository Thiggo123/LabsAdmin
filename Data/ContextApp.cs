using Labs.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace Labs.Data
{
    public class ContextApp : DbContext
    {

        public ContextApp()

            : base("mssqllocaldb")
        {

        }
        public virtual DbSet<Computers> Computers  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));



            modelBuilder.Properties().Where(p => p.Name == "Id").Configure(p => p.IsKey());

        }



    }
}
