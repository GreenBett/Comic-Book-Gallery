using ComicBookGallery.Models;
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

            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artists[]
                {
                    new Artists() { Name = "Dan Slott", Role = "Script"},
                    new Artists() { Name = "Humberto Ramos", Role = "Pencils"},
                    new Artists() { Name = "Victor Olazaba", Role = "Inks"},
                    new Artists() { Name = "Edgar Delgado", Role = "Colors"},
                    new Artists() { Name = "Chris Eliopoulos", Role = "Letters"}
                }

            };             

            return View(comicBook);
        }
    }

}
