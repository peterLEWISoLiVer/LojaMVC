using Microsoft.EntityFrameworkCore;
using LojaMVC.Models;
namespace LojaMVC.Data
{

    public class LojaContextMVC : DbContext
    {
        public LojaContextMVC(DbContextOptions<LojaContextMVC> options) : base(options)
        {

        }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }

}