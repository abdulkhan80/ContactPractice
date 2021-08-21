using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CTTestAbdulKhan.Model.Model;

namespace CTTestAbdulKhan.Data
{
    public class ContactSeedInitializer : DropCreateDatabaseIfModelChanges<CTTestDBContext>
    {

        protected override void Seed(CTTestDBContext context)
        {
            var Contact = new List<Contact>
                {
                    new Contact { Name="Abdul Khan",Address="Address Ln1",Address2="Address Ln2" ,Address3="Address Ln3",postcode="SE1 2GG", country="UK"},
                    new Contact { Name="Abdul Khan 2",Address="Address Ln1",Address2="Address Ln2" ,Address3="Address Ln3",postcode="SE2 2GG", country="UK"},
                    new Contact { Name="Abdul Khan 3",Address="Address Ln1",Address2="Address Ln2" ,Address3="Address Ln3",postcode="SE3 2GG", country="UK"},
                    new Contact { Name="Abdul Khan 4",Address="Address Ln1",Address2="Address Ln2" ,Address3="Address Ln3",postcode="SE4 2GG", country="UK"},
                    new Contact { Name="Abdul Khan 5",Address="Address Ln1",Address2="Address Ln2" ,Address3="Address Ln3",postcode="SE5 2GG", country="UK"},


                };


            Contact.ForEach(s => context.Contact.Add(s));
            context.SaveChanges();

            var Note = new List<Note>
                {
                    new Note { Notes ="Test Note 1", ContactId=1 },
                    new Note { Notes ="Test Note 2", ContactId=1  },
                    new Note { Notes ="Test Note 3", ContactId=1  },
                    new Note { Notes ="Test Note 4", ContactId=2  },
                    new Note { Notes ="Test Note 5", ContactId=3  },
                };
            Note.ForEach(s => context.Note.Add(s));
            context.SaveChanges();


        }

    }//end class..
}//end ns...
