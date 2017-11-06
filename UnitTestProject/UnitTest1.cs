using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        #region Student Tests

        [TestMethod]
        public void Postive_Student_CreateEmpty()
        {
            Student myStu = StudentFactory.Create();
            Assert.IsNotNull(myStu);

            PrivateObject myObject = new PrivateObject(myStu);
            Assert.IsTrue(myObject.GetField("_firstName") == null);
            Assert.IsTrue(myObject.GetField("_lastName") == null);
        }

        [TestMethod]
        public void Postive_Student_CreateFilledById()
        {
            Student myStu = StudentFactory.Create(20171006);
            Assert.IsNotNull(myStu);

            Assert.IsTrue(myStu.firstName == "Khris");
            Assert.IsTrue(myStu.lastName == "Wilson");
        }

        [TestMethod]
        public void Postive_Student_CreateFilledByName()
        {
            Student myStu = StudentFactory.Create("Khris");
            Assert.IsNotNull(myStu);

            Assert.IsTrue(myStu.firstName == "Khris");
            Assert.IsTrue(myStu.lastName == "Wilson");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Student_Create()
        {
            Student myStu = StudentFactory.Create(1233123414);
        }

        #endregion

        #region Resource Tests

        [TestMethod]
        public void Postive_Resource_CreateEmpty()
        {
            Resource myRes = ResourceFactory.Create();
            Assert.IsNotNull(myRes);

            PrivateObject myObject = new PrivateObject(myRes);
            Assert.IsTrue(myObject.GetField("_description") == null);
            Assert.IsTrue(myObject.GetField("_title") == null);
        }

        [TestMethod]
        public void Postive_Resource_CreateFilledByName()
        {
            Resource myRes = ResourceFactory.Create(10000000);
            Assert.IsNotNull(myRes);

            Assert.IsTrue(myRes.title == "Brake Repair 101");
            Assert.IsTrue(myRes.description == "Auto Repair DVD");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Resource_Create()
        {
            Resource myRes = ResourceFactory.Create(100000000);
        }

        #endregion

        #region Lists Tests

        [TestMethod]
        public void Positive_Publisher_List()
        {
            List<StudentLookup> StudentList = StudentsLookupFactory.Create("J");

            Assert.IsTrue(StudentList[0].FirstName.ToString() == "Josh");
            Assert.IsTrue(StudentList[0].LastName.ToString() == "Sal");
            Assert.IsTrue(StudentList[1].FirstName.ToString() == "Jo");
            Assert.IsTrue(StudentList[1].LastName.ToString() == "Long");
        }

        [TestMethod]
        public void Positive_Resoure_List()
        {
            List<ResourceLookup> ResourceList = ResourceLookupFactory.Create(10000000);

            Assert.IsTrue(ResourceList[0].title.ToString() == "Brake Repair 101");
            Assert.IsTrue(ResourceList[0].resourceType == ResourceType.DVD);

        }


        #endregion

    }
}
