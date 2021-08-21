using CTTestAbdulKhan.Business.Services.Interface;
using CTTestAbdulKhan.Data;
using CTTestAbdulKhan.Model.Model;
using CTTestAbdulKhan.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTestAbdulKhan.Business.Services
{
    public class ContactService : IContactService
    {

        public IList<ContactDTO> GetAllContacts()
        {
            //throw new NotImplementedException("I'm not yet implement test here first with red factor");

            var dtContext = new CTTestDBContext();
            var Results = from c in dtContext.Contact
                          select new ContactDTO
                          {
                              ConactID = c.ID,
                              PersonName = c.Name,
                              PersonAddress = c.Address,
                              PersonAddress2 = c.Address2,
                              PersonAddress3 = c.Address3,
                              PersonPostCode = c.postcode,
                              PersonCountry = c.country
                          };

            return Results.ToList();
        }


    }//end class..
}//end ns..
