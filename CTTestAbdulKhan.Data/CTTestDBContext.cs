using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CTTestAbdulKhan.Model.Model;

namespace CTTestAbdulKhan.Data
{
    public class CTTestDBContext : DbContext
    {
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Note> Note { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
