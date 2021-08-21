using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTTestAbdulKhan;
using CTTestAbdulKhan.Controllers;
using CTTestAbdulKhan.Business.Services.Interface;
using CTTestAbdulKhan.Model.Model;
using Moq;
using CTTestAbdulKhan.Model.ViewModel;

namespace CTTestAbdulKhan.Tests.Controllers
{
    [TestClass]
    public class ContactControllerTest
    {
        [TestMethod]
        public void FindByIdReturnContactDetails()
        {
            //Arrange
            var repositry = new Mock<IContactService>();
            repositry.Setup(c => c.GetAllContacts()).Returns(
                new List<ContactDTO>()
                {
                    new ContactDTO { ConactID=1, PersonName = "Abdul Khan 1", PersonAddress = "Address Ln1", PersonAddress2 = "Address Ln2", PersonAddress3 = "Address Ln3", PersonPostCode = "SE1 2GG", PersonCountry = "UK" },
                    new ContactDTO { ConactID=2, PersonName =" Abdul Khan 2",PersonAddress="Address Ln1",PersonAddress2="Address Ln2" ,PersonAddress3="Address Ln3",PersonPostCode="SE2 2GG", PersonCountry="UK"},
                    new ContactDTO { ConactID=3, PersonName =" Abdul Khan 3",PersonAddress="Address Ln1",PersonAddress2="Address Ln2" ,PersonAddress3="Address Ln3",PersonPostCode="SE3 2GG", PersonCountry="UK"},
                });

            //Act
            ContactController controller = new ContactController(repositry.Object);
            ViewResult result = controller.FindContact(1) as ViewResult;
            var model = result.ViewData.Model as IList<ContactDTO>;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, model.ToList()[0].ConactID);
        }

        [TestMethod]
        public void Index_Return_All_Contacts_In_DB()
        {
            //Arrange
            var repositry = new Mock<IContactService>();
            repositry.Setup(c => c.GetAllContacts()).Returns(
                new List<ContactDTO>()
                {
                    new ContactDTO { PersonName = "Abdul Khan 1", PersonAddress = "Address Ln1", PersonAddress2 = "Address Ln2", PersonAddress3 = "Address Ln3", PersonPostCode = "SE1 2GG", PersonCountry = "UK" },
                    new ContactDTO { PersonName =" Abdul Khan 2",PersonAddress="Address Ln1",PersonAddress2="Address Ln2" ,PersonAddress3="Address Ln3",PersonPostCode="SE2 2GG", PersonCountry="UK"},
                    new ContactDTO { PersonName =" Abdul Khan 3",PersonAddress="Address Ln1",PersonAddress2="Address Ln2" ,PersonAddress3="Address Ln3",PersonPostCode="SE3 2GG", PersonCountry="UK"},
                });

            //Act
            ContactController controller = new ContactController(repositry.Object);
            ViewResult result = controller.Contact() as ViewResult;
            var model = result.ViewData.Model as IList<ContactDTO>;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, model.Count);
        }

        [TestMethod]
        public void Test_ContactPage_List()
        {
            //Arrange
            var contact = new List<ContactDTO>();
             
            var repositry = new Mock<IContactService>();
            repositry.Setup(c => c.GetAllContacts()).Returns(contact);

            //Act
            ContactController controller = new ContactController(repositry.Object);
            ViewResult result = controller.Contact() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Test_GetAllContacts_List()
        {
            //Arrange
            var contact = new List<ContactDTO>();
            contact.Add(new ContactDTO());
            contact.Add(new ContactDTO());


            var repositry = new Mock<IContactService>();
            repositry.Setup(c => c.GetAllContacts()).Returns(contact);

            //Act
            ContactController controller = new ContactController(repositry.Object);
            ViewResult result = controller.Contact() as ViewResult;

            //Assert
            var model = result.ViewData.Model as IList<ContactDTO>;
            Assert.IsNotNull(result);
            Assert.AreEqual(2, model.Count);
        }


        [TestMethod]
        public void Test_ContactPage_index()
        {
            //Arrange
            ContactController controller = new ContactController();

            //Act
            ViewResult restult = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(restult);
        }

    }//end class..
}//end ns..
