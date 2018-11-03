using BoardGameGallery.Data;
using System.Web.Mvc;

namespace BoardGameGallery.Controllers
{
    public class BoardGameController : Controller
    {
        private BoardGameRepository _boardGameRepository = null;

        public BoardGameController()
        {
            _boardGameRepository = new BoardGameRepository();
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var boardGame = _boardGameRepository.GetBoardGame((int)id);
            if(boardGame == null)
            {
                return HttpNotFound();
            }
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
