using System.Web.Mvc;
using ComicBookGallery.Data;

/*
 - Notes: Pattern = controller/action
 -        Controller = ComicBooks, Action = Detail
 -        Using URL Routing
 */
namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller //Controllers --Must be public for access
    {

        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {

            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        { //Action Method  --Must be public for access
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook(id.Value); //OR ((int)id)
                

            return View(comicBook);
        }
    }

}
