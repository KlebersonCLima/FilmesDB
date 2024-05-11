using FilmesDB.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FilmesDB.Infra.Contexto
{
    public class DbContexto: DbContext
    {
        public DbContexto()
        {
        }

        public DbContexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Ator> Atores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("Server=localhost; Database=filmedb; Uid=root; Pwd=; persistsecurityinfo=True;",
                ServerVersion.AutoDetect("Server=localhost; Database=filmedb; Uid=root; Pwd=; persistsecurityinfo=True;"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Filme>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Sinopse);
                entity.Property(e => e.Genero);
                entity.Property(e => e.Lancamento);
                entity.Property(e => e.Nome);
            }
            );

            modelBuilder.Entity<Serie>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Sinopse);
                entity.Property(e => e.Genero);
                entity.Property(e => e.Lancamento);
                entity.Property(e => e.Nome);
                entity.Property(e => e.Temporadas);
                entity.Property(e => e.Finalizada);
            }
            );

            modelBuilder.Entity<Ator>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nacionalidade);
                entity.Property(e => e.Sexo);
                entity.Property(e => e.Aniversario);
                entity.Property(e => e.Nome);
            }
            );
        }
    }
}
