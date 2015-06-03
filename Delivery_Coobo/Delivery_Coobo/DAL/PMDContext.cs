using Delivery_Coobo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Delivery_Coobo.DAL
{
    public class PMDContext : DbContext
    {
        public PMDContext()
            : base("PMDContext")
        {
        }
        /// <summary>
        /// Cria propriedade DbSet para cada entity set
        /// </summary>
        public DbSet<Projetos> Projeto { get; set; }
        public DbSet<Empresas> Empresa { get; set; }
        public DbSet<Cotacoes> Cotacao { get; set; }
        public DbSet<Categorias> Categoria  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Impede que nomes de tabela sejam pluralizados
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}