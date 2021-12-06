using Prova2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prova2.Context
{
    public class EFContext : DbContext
    {
            public EFContext() : base("Prova")
            {
                Database.SetInitializer<EFContext>
                    (new DropCreateDatabaseIfModelChanges<EFContext>());
            }

            public DbSet<Fornecedor> Fornecedores { get; set; }

            public DbSet<Produto> Produtos { get; set; }
        
    }
}