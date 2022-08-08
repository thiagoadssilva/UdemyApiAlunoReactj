using AlunosAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlunosAPI.Context
{   
    // Classe responsável por fazer a ligação entre as classes e o banco de dados
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; } // Aqui estamos fazendo o mapeamento da classe aluno que vai virar uma tabela no banco de dados

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Thiago jose da silva",
                    Email = "thiago.ads.silva@gmail.com",
                    Idade = 37
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Bento jose da silva",
                    Email = "bentoSilva@gmail.com",
                    Idade = 4
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
