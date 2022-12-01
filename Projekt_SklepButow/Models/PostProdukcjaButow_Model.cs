namespace Projekt_SklepButow.Models
{
    public class PostProdukcjaButow_Model
    {
        //[HiddenInput]
        public int Id { get; set; } //





        //[Required(ErrorMessage = "Proszę podać nazwe Marki w punkcie 'Marka'.")]
        //[StringLength(50, ErrorMessage = "Zadługa nazwa Marki! W Marce może wmieścić się do 50 symbolów.")]
        public string Marka { get; set; }





        //[Required(ErrorMessage = "Proszę podać nazwe Modeli w punkcie 'Model'.")]
        //[StringLength(25, ErrorMessage = "Zadługa nazwa Madeli! W Modeli może wmieścić się do 25 symbolów.")]
        public string Model { get; set; }




        //[Required(ErrorMessage = "Wybierz rodzaj butów")]
        public Erodzaj Rodzaj { get; set; }




        //[Required(ErrorMessage = "Wybierz kolor butów")]
        public Ekolor Kolor { get; set; }



        //Rozmiar




        //[Range] - sprawdza wartość ceny 
        public int Cena { get; set; }

    }



    
    public enum Erodzaj
    {
        //[Display(Name = "Klasyczne")] Klasyczne,
        Klasyczne,


        //[Display(Name = "Triningowe")] Treningowe,
        Treningowe,

        //[Display(Name = "Zimowe")] Zimowe,
        Zimowe,

        //[Display(Name = "Klapki")] Klapki
        Klapki
    }

    


    public enum Ekolor
    {
        //[Display(Name = "Białe")] Białe,
        Białe,

        //[Display(Name = "Czarne")] Czarne,
        Czarne,

        //[Display(Name = "Szare")] Szare,
        Szare,

        //[Display(Name = "Czerwone")] Czerwone,
        Czerwone,

        //[Display(Name = "Niebieski")] Niebieski,
        Niebieski,

        //[Display(Name = "Żółty")] Żółty
        Żółty

    }
    




}
