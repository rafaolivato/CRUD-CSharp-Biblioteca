using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Biblioteca.Models
{
    public class BibliotecaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=Biblioteca;Uid=root;");
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        /*public List<Usuario> Listar()
        {

            using (BibliotecaContext bc = new BibliotecaContext())
            {

                bc.Usuarios;

            }
        }*/
    }
}