using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ymagi.Models;
using Ymagi.Models.ViewModels;

namespace Ymagi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Osc> Osc { get; set; }
        public DbSet<Membro> Membro { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Entrega> Entrega { get; set; }
        public DbSet<Recebimento> Recebimento { get; set; }
        public DbSet<ProjectRole> ProjectRole { get; set; }

    }
}
