using AppMvcBasica.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppMvcBasica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> produtos { get; set; }
        public DbSet<Fornecedor> fornecedores { get; set; }
        public DbSet<Endereco> enderecos { get; set; }


    }
}