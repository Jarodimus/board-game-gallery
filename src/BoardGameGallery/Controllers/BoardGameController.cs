using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoardGameGallery.Controllers
{
    public class BoardGameController : Controller
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("/");
            }
            return Content("Hello form board games controller!");
        }
    }
}
