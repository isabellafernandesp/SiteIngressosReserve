using Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DataBase.db
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=IngressosDB")
        {
            Database.SetInitializer<DatabaseContext>(new CreateDatabaseIfNotExists<DatabaseContext>());
        }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Usuario>()
            .Property(p => p.Sexo)
            .HasColumnType("char");
        }
        private void FixEfProviderServicesProblem()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public System.Data.Entity.DbSet<Models.Model.Evento> Eventos { get; set; }

        public System.Data.Entity.DbSet<Models.Model.CartaoUsuario> CartoesUsuarios { get; set; }

        public System.Data.Entity.DbSet<Models.Model.CompraIngressos> ComprasIngressos { get; set; }
    }
}