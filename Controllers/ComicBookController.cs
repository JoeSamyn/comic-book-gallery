using System;
using System.Web.Mvc;
using ComicBookGallery.Models;

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

            var comicBook = new ComicBook()
            {
                SeriesTitle = "\"The Amazing Spiderman\"",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan Slott", Role = "Script:"},
                    new Artist() {Name = "Humberto Ramos", Role = "Pencils:"},
                    new Artist() {Name = "Victor Olazaba", Role = "Inks:"},
                    new Artist() {Name = "Edgar Delgado", Role = "Colors:"},
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters:"},
                }
            };

            return View(comicBook);    
        }
    }
}
