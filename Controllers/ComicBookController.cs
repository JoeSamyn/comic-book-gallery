using System;
using System.Web.Mvc;
using ComicBookGallery.Data;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {

        // The return type is action result because RedirectResult and ContentResult
        // both have a base class of ActionResult.  This way we can return either. 
        // Because of this ActionResult is almost always used as return type. 

        private ComicBookRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();

        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);    
        }


        public ActionResult Index()
        {

            return View();
        }
    }
}
