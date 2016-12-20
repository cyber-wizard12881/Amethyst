//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Web.Http;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Amethyst;
//using Amethyst.Controllers;

//namespace Amethyst.Tests.Controllers
//{
//    [TestClass]
//    public class BirthdaysControllerTest
//    {
//        [TestMethod]
//        public void Get()
//        {
//            // Arrange
//            BirthdaysController controller = new BirthdaysController();

//            // Act
//            IEnumerable<string> result = controller.Get();

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.AreEqual(2, result.Count());
//            Assert.AreEqual("value1", result.ElementAt(0));
//            Assert.AreEqual("value2", result.ElementAt(1));
//        }

//        [TestMethod]
//        public void GetById()
//        {
//            // Arrange
//            BirthdaysController controller = new BirthdaysController();

//            // Act
//            string result = controller.Get(5);

//            // Assert
//            Assert.AreEqual("value", result);
//        }

//        [TestMethod]
//        public void Post()
//        {
//            // Arrange
//            BirthdaysController controller = new BirthdaysController();

//            // Act
//            controller.Post("value");

//            // Assert
//        }

//        [TestMethod]
//        public void Put()
//        {
//            // Arrange
//            BirthdaysController controller = new BirthdaysController();

//            // Act
//            controller.Put(5, "value");

//            // Assert
//        }

//        [TestMethod]
//        public void Delete()
//        {
//            // Arrange
//            BirthdaysController controller = new BirthdaysController();

//            // Act
//            controller.Delete(5);

//            // Assert
//        }
//    }
//}
