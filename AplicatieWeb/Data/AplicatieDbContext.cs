using System;
using Microsoft.EntityFrameworkCore;
using AplicatieWeb.Models;

namespace AplicatieWeb.Data
{
    public class AplicatieDbContext : DbContext
    {
        public AplicatieDbContext(DbContextOptions<AplicatieDbContext> options)
            : base(options)
        {
        }

        public DbSet<Rezultat> Rezultate { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rezultat>().HasData(
                new Rezultat { Id = 1, NumeSportiv = "Popescu Ion", Proba = "Alergare 100 m", Loc = 1, Punctaj = 95.50m, DataConcursului = new DateTime(2026, 8, 10), Calificat = true },
                new Rezultat { Id = 2, NumeSportiv = "Ionescu Maria", Proba = "Săritură în lungime", Loc = 2, Punctaj = 88.00m, DataConcursului = new DateTime(2026, 8, 12), Calificat = true },
                new Rezultat { Id = 3, NumeSportiv = "Rusu Andrei", Proba = "Aruncarea greutății", Loc = 5, Punctaj = 70.20m, DataConcursului = new DateTime(2026, 8, 15), Calificat = false },
                new Rezultat { Id = 4, NumeSportiv = "Ciobanu Elena", Proba = "Cros", Loc = 1, Punctaj = 99.00m, DataConcursului = new DateTime(2026, 9, 01), Calificat = true },
                new Rezultat { Id = 5, NumeSportiv = "Munteanu Radu", Proba = "Alergare 100 m", Loc = 3, Punctaj = 82.10m, DataConcursului = new DateTime(2026, 9, 05), Calificat = true },
                new Rezultat { Id = 6, NumeSportiv = "Sirbu Ana", Proba = "Săritură în lungime", Loc = 4, Punctaj = 75.00m, DataConcursului = new DateTime(2026, 9, 10), Calificat = false },
                new Rezultat { Id = 7, NumeSportiv = "Lupu Mihai", Proba = "Aruncarea greutății", Loc = 2, Punctaj = 89.30m, DataConcursului = new DateTime(2026, 10, 02), Calificat = true },
                new Rezultat { Id = 8, NumeSportiv = "Ursu Diana", Proba = "Cros", Loc = 6, Punctaj = 65.40m, DataConcursului = new DateTime(2026, 10, 08), Calificat = false },
                new Rezultat { Id = 9, NumeSportiv = "Rotaru Vlad", Proba = "Alergare 100 m", Loc = 2, Punctaj = 91.00m, DataConcursului = new DateTime(2026, 10, 15), Calificat = true },
                new Rezultat { Id = 10, NumeSportiv = "Balhar Victoria", Proba = "Săritură în lungime", Loc = 1, Punctaj = 96.80m, DataConcursului = new DateTime(2026, 10, 20), Calificat = true },
                new Rezultat { Id = 11, NumeSportiv = "Moraru Gabriel", Proba = "Aruncarea greutății", Loc = 3, Punctaj = 81.50m, DataConcursului = new DateTime(2026, 10, 22), Calificat = true },
                new Rezultat { Id = 12, NumeSportiv = "Ceban Cristina", Proba = "Cros", Loc = 4, Punctaj = 72.00m, DataConcursului = new DateTime(2026, 10, 28), Calificat = false }
            );
        }
    }
}