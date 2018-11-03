using BoardGameGallery.Models;
using System.Web.Mvc;

namespace BoardGameGallery.Controllers
{
    public class BoardGameController : Controller
    {
        public ActionResult Detail()
        {
            Manufacturer ffg = new Manufacturer()
            {
                Name = "Fantasy Flight Games",
                Abbrev = "ffg"
            };
            var boardGame = new BoardGame()
            {
                Id = 1,
                Title = "Arkham Horror 3rd Edition",
                ProductNumber = "#FFGAHB01",
                DescriptionHtml = "<p>Massachusetts. 1926. Too long has the city of Arkham lived on its placid island of ignorance in the midst of the black seas of infinity. Only a small handful of unlucky investigators dare plunge into that abyss to struggle against the ancient evils that threaten reality from every corner of this New England town.</p><p>Arkham Horror is a cooperative game of mystery and terror for up to six players.Inspired by the writings of H.P.Lovecraft, each unique scenario puts you in the shoes of one of Arkham's investigators as they explore the streets of the city and work together to save humanity from unknowable horrors.</p>",
                Contents = new string[]{
                "5 Map Tiles",
                "7 Streets",
                "12 Investigators",
                "4 Scenarios",
                "469 Cards",
                "1 Deck Holder",
                "6 Dice",
                "265 Tokens" },
                NewArrival = true,
                Manufacturer = ffg
            };
            return View(boardGame);
        }
    }
}

//public int Id { get; set; }
//public string Title { get; set; }
//public int ProductNumber { get; set; }
//public double RegPrice { get; set; }
//public double SpecialPrice { get; set; }
//public string Manufacturer { get; set; }
//public string DescriptionHtml { get; set; }
//public string[] Contents { get; set; }
//public Mechanic[] Mechanics { get; set; }
//public Category[] Categories { get; set; }
//public Category[] SubCategories { get; set; }
//public bool Wishlisted { get; set; }
//public bool NewArrival { get; set; }
