using Microsoft.EntityFrameworkCore;
using Tickett.Models;
using Microsoft.Extensions.Configuration;

namespace Tickett.Data
{
    public class ObraContext : DbContext
    {

        public ObraContext(DbContextOptions<ObraContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObraReparto>()
                .HasKey(o => new { o.ObraId, o.RepartoId });

            modelBuilder.Entity<ObraReparto>()
                .HasOne(o => o.Obra)
                .WithMany(p => p.ListaObraReparto)
                .HasForeignKey(pi => pi.ObraId);

            modelBuilder.Entity<ObraReparto>()
                .HasOne(r => r.Reparto)
                .WithMany(i => i.ListaObraReparto)
                .HasForeignKey(pi => pi.RepartoId);

            modelBuilder.Entity<Obra>()
            .HasMany(o => o.ListaButacas)
            .WithOne(b => b.Obra)
            .HasForeignKey(b => b.ObraId);

            modelBuilder.Entity<Obra>().HasData(
                new Obra { ObraId = 1, Titulo = "Don Juan", Descripcion = "false", DiaObra = new DateTime(2024, 01, 13), HoraObra = new TimeSpan(17, 0, 0), Imagen = "../IMAGENES/donjuan.jpg", Genero = "Drama", Duracion = 105, Precio = 25, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 2, Titulo = "Celestina", Descripcion = "false", DiaObra = new DateTime(2024, 01, 25), HoraObra = new TimeSpan(18, 30, 0), Imagen = "../IMAGENES/celestina.jpg", Genero = "Drama", Duracion = 120, Precio = 15, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 3, Titulo = "Doble o nada", Descripcion = "false", DiaObra = new DateTime(2024, 02, 7), HoraObra = new TimeSpan(16, 0, 0), Imagen = "../IMAGENES/doble-o-nada.jpg", Genero = "Drama", Duracion = 115, Precio = 20, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 4, Titulo = "Campeones", Descripcion = "false", DiaObra = new DateTime(2024, 02, 15), HoraObra = new TimeSpan(19, 15, 0), Imagen = "../IMAGENES/campeones.jpg", Genero = "Drama", Duracion = 140, Precio = 35, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 5, Titulo = "El mago Pop", Descripcion = "false", DiaObra = new DateTime(2024, 02, 29), HoraObra = new TimeSpan(18, 0, 0), Imagen = "../IMAGENES/el-mago-pop.jpg", Genero = "Drama", Duracion = 135, Precio = 30, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 6, Titulo = "El Rey Leon", Descripcion = "false", DiaObra = new DateTime(2024, 03, 03), HoraObra = new TimeSpan(12, 0, 0), Imagen = "../IMAGENES/ElReyLeon3Aniv.jpg", Genero = "Drama", Duracion = 100, Precio = 10, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 7, Titulo = "Fango", Descripcion = "false", DiaObra = new DateTime(2024, 03, 16), HoraObra = new TimeSpan(20, 0, 0), Imagen = "../IMAGENES/fango.jpg", Genero = "Drama", Duracion = 90, Precio = 40, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 8, Titulo = "La Funcion que Sale Mal", Descripcion = "false", DiaObra = new DateTime(2024, 03, 21), HoraObra = new TimeSpan(20, 30, 0), Imagen = "../IMAGENES/funcion-sale-mal.jpg", Genero = "Drama", Duracion = 110, Precio = 30, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 9, Titulo = "Ilusionate", Descripcion = "false", DiaObra = new DateTime(2024, 04, 04), HoraObra = new TimeSpan(15, 15, 0), Imagen = "../IMAGENES/ilusionate.jpg", Genero = "Drama", Duracion = 120, Precio = 15, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 10, Titulo = "Jose el sonñador", Descripcion = "false", DiaObra = new DateTime(2024, 04, 10), HoraObra = new TimeSpan(22, 15, 0), Imagen = "../IMAGENES/jose-el-sonador.jpg", Genero = "Drama", Duracion = 105, Precio = 25, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 11, Titulo = "Laponia", Descripcion = "false", DiaObra = new DateTime(2024, 04, 23), HoraObra = new TimeSpan(21, 30, 0), Imagen = "../IMAGENES/laponia.jpg", Genero = "Drama", Duracion = 125, Precio = 20, ListaButacas = GenerarButacas() },
                new Obra { ObraId = 12, Titulo = "Las mil y una noches", Descripcion = "false", DiaObra = new DateTime(2024, 05, 01), HoraObra = new TimeSpan(19, 15, 0), Imagen = "../IMAGENES/las-mil-y-una-noches.jpg", Genero = "Drama", Duracion = 30, Precio = 25, ListaButacas = GenerarButacas() }


            );
            // modelBuilder.Entity<Reparto>().HasData(
            //     new Reparto { PizzaId = 1, IngredienteId = 1 },
            //     new Reparto { PizzaId = 1, IngredienteId = 2 },
            //     new Reparto { PizzaId = 2, IngredienteId = 3 },
            //     new Reparto { PizzaId = 2, IngredienteId = 1 },
            //     new Reparto { PizzaId = 1, IngredienteId = 4 }
            // );
            // modelBuilder.Entity<ObraReparto>().HasData(
            //     new ObraReparto { PizzaId = 1, IngredienteId = 1 },
            //     new ObraReparto { PizzaId = 1, IngredienteId = 2 },
            //     new ObraReparto { PizzaId = 2, IngredienteId = 3 },
            //     new ObraReparto { PizzaId = 2, IngredienteId = 1 },
            //     new ObraReparto { PizzaId = 1, IngredienteId = 4 }
            // );
        }

        private List<Butaca> GenerarButacas()
        {
            var butacas = new List<Butaca>();
            for (int i = 1; i <= 100; i++)
            {
                butacas.Add(new Butaca(true)); // Suponiendo que inicialmente todas las butacas están libres
            }
            return butacas;
        }

        public DbSet<Obra> Obras { get; set; }
        public DbSet<Butaca> Butacas { get; set; }
        public DbSet<Reparto> Repartos { get; set; }
        public DbSet<ObraReparto> ObraRepartos { get; set; }

    }
}
