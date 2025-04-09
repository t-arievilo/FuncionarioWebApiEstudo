using FuncionarioWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FuncionarioWebApi.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
