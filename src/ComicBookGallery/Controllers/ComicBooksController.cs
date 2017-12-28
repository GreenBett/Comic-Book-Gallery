using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*
 - Notes: Pattern = controller/action
 -        Controller = ComicBooks, Action = Detail
 -        Using URL Routing
 */
namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller //Controllers --Must be public for access
    {

        public ActionResult Detail()
        { //Action Method  --Must be public for access


            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {

                return Redirect("/");
            }
            return Content("Hello from the comic books controller!");

         
        // Content = "Hello from the comic books controller!"  //Action Result Types
    }

}
}