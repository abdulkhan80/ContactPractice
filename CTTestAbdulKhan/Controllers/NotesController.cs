using CTTestAbdulKhan.Business.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CTTestAbdulKhan.Controllers
{
    public class NotesController : Controller
    {
        // GET: Notes
        private INoteService _note;

        public NotesController() { }

        public NotesController(INoteService note)
        {
            this._note = note;
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Notes(int ContactId)
        {
            var GetNotes = _note.GetContactNotesById(ContactId);

            return View(GetNotes);
        }
    }
}