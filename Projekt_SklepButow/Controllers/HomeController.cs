using Microsoft.AspNetCore.Mvc;
using Projekt_SklepButow.Models;
using System.Diagnostics;

namespace Projekt_SklepButow.Controllers
{
    public class HomeController : Controller
    {



        private static AppDbContext context = new AppDbContext();  // ala nasza Baza danych (BD).

        public static List<PostProdukcjaButow_Model> lista = context.PostProdukcjaButow_Models.ToList();//Zaminiamy z BD w Liste.



        //Add//

        [HttpGet]
        public IActionResult Add() { return View(); }
        [HttpPost]
        public IActionResult Add(PostProdukcjaButow_Model postProdukcjaButow_Model)
        {
            postProdukcjaButow_Model.Marka = "New Balance";
            postProdukcjaButow_Model.Model = "CT302";
            postProdukcjaButow_Model.Rodzaj = Erodzaj.Klasyczne;
            postProdukcjaButow_Model.Kolor = Ekolor.Szare;
            postProdukcjaButow_Model.Cena = 345;

            context.PostProdukcjaButow_Models.Add(postProdukcjaButow_Model);
            context.SaveChanges();

            lista = context.PostProdukcjaButow_Models.ToList();

            return View("Index", lista);
        }
        //////////////////////////////////////////////////////////////////////////////////

        //Delet//

        [HttpGet]
        public IActionResult Delet (int id)
        {

            context.PostProdukcjaButow_Models.Remove(context.PostProdukcjaButow_Models.Find(id));
            context.SaveChanges();

            lista = context.PostProdukcjaButow_Models.ToList();

            return View("Index", lista);
        }


        //////////////////////////////////////////////////////////////////////////////////

        //Strona Glowna.
        public IActionResult Index()
        {
            return View(lista);
        }


        ////////////////////////////////////////////////////////////////////////////////

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public IActionResult O_nas()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}