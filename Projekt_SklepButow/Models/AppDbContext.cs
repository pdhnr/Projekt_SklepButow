using Microsoft.EntityFrameworkCore;

namespace Projekt_SklepButow.Models
{
    public class AppDbContext : DbContext
    {
        //Encja - Tabela w BD.
        public DbSet<PostProdukcjaButow_Model> PostProdukcjaButow_Models { get; set; }

        public string DbPath { get; set; }
        public AppDbContext() //tutaj kawawek kodu nam robi w tem konstruktorze(AppDbContext()). Zapisuje nam automatycznie plik: C/(name_urzytkownik)/lokal.
                              //plik bedzie zapisany w iminu ("books.db"). i tam biedzie przechowywać naszą Baze danych(BD)
                              //zaby zapisać w ten plik w BD.
                              //Musimy: Narzędzia / Menadrzer NuGet / Konsole... / konsole ...  ,Musimy wpisać komende (update-database) 
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Buty.db");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder
        options)
        => options.UseSqlite($"Data Source={DbPath}");



        ///////////////////////////////////////////////////////////

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<PostProdukcjaButow_Model>().HasData(
           new PostProdukcjaButow_Model() { Id = 1, Marka = "Adidas", Model = "Gazeli", Rodzaj = Erodzaj.Klasyczne , Kolor = Ekolor.Białe, Cena = 345 },
           new PostProdukcjaButow_Model() { Id = 2, Marka = "New Balance", Model = "574", Rodzaj = Erodzaj.Klasyczne, Kolor = Ekolor.Czarne, Cena = 597 }
            );
        }



    }
}
