using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller //Controllers --Must be public for access
    {

        public string Detail()
        { //Action Method  --Must be public for access

            return "Hello from the comic books controller!";
        }

    }
}