using System;
using System.Web.Mvc;
namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {

        // The return type is action result because RedirectResult and ContentResult
        // both have a base class of ActionResult.  This way we can return either. 
        // Because of this ActionResult is almost always used as return type. 
        public ActionResult Detail()
        {
            /*
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                // Can user Redirect insted of new RedirectResult()
                return Redirect("/");
            }

            // Can user Content insted of new ContentResult()
            // Checking version control
            return Content("Here is a gallery about comic books!");
            */

            ViewBag.SeriesTitle = "The Amazing Spiderman";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {

                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();    
        }
    }
}
