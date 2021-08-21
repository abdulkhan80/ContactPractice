using CTTestAbdulKhan.Business.Services.Interface;
using CTTestAbdulKhan.Model.ViewModel;
using CTTestAbdulKhan.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTTestAbdulKhan.Controllers
{
    public class ContactController : Controller
    {
        private IContactService _contact;

        public ContactController() { }

        public ContactController(IContactService contact)
        {
            this._contact = contact;
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            var GetContactList = _contact.GetAllContacts();

            return View(GetContactList);
        }

        public ActionResult FindContact(int Id)
        {
            var contacts = _contact.GetAllContacts();
            List<ContactDTO> results = contacts.Where(c => c.ConactID == Id).ToList();
            return View(results);
        }

    }
}