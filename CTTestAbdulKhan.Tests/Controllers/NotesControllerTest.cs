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


namespace CTTestAbdulKhan.Tests.Controllers
{
    [TestClass]
    public class NotesControllerTest
    {
        private int contactId = 1;

        [TestMethod]
        public void Test_NotePage()
        {
            //Arrange
            var note = new List<Note>();

            var repositry = new Mock<INoteService>();
            repositry.Setup(n => n.GetContactNotesById(It.IsAny<int>())).Returns(note);

            //Act
            NotesController controller = new NotesController(repositry.Object);
            ViewResult result = controller.Notes(contactId) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Test_GetAllContacts_List()
        {
            //Arrange
            var note = new List<Note>();
            note.Add(new Note());
            note.Add(new Note());
            note.Add(new Note());

            var repositry = new Mock<INoteService>();
            repositry.Setup(n => n.GetContactNotesById(It.IsAny<int>())).Returns(note);

            //Act
            NotesController controller = new NotesController(repositry.Object);
            ViewResult result = controller.Notes(contactId) as ViewResult;

            //Assert
            var model = result.ViewData.Model as IList<Note>;
            Assert.IsNotNull(result);
            Assert.AreEqual(3, model.Count);
        }


        [TestMethod]
        public void Test_NotesPage_index()
        {
            //Arrange
            NotesController controller = new NotesController();

            //Act
            ViewResult restult = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(restult);
        }

    }//end class..
}//end ns..
