using CTTestAbdulKhan.Model.Model;
using CTTestAbdulKhan.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CTTestAbdulKhan.Business.Services.Interface
{
    public interface IContactService
    {
        IList<ContactDTO> GetAllContacts();
    }
}
