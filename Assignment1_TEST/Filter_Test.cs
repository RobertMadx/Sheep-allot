using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Assignment1_Test
{
    //Tests for testing method from the Filter class
    [TestClass]
    public class Filter_Test
    {
        //In this case it was best to have 1 test as we are creating a list of objects that can be used to test each method of the class
        [TestMethod]
        public void Sort_AZ_ZA_Search_Test()
        {

            PictureBox p = new PictureBox();//Declare an initialise a picture box used with class constructor
            FileManager fm = new FileManager();//Declare an initialise a file manager object
            List<MyClass> testlist = new List<MyClass>();//Declare an initialise a list of MyClass objects

            //Create 3 custom items and add them to the object list
            testlist.Add(new MyClass("Test 1", 1, new System.Drawing.Point(0, 0), p));//NZ
            testlist.Add(new MyClass("Test 2", 3, new System.Drawing.Point(0, 0), p));//China
            testlist.Add(new MyClass("Test 3", 2, new System.Drawing.Point(0, 0), p));//AUS


            Filter filter = new Filter();//Declare an initialise a filter object to be used

            //Test AZ
            testlist = filter.SortAZ(testlist);

            //With filter applied, verify results
            Assert.AreEqual(testlist[0].TypeName, "Australia");
            Assert.AreEqual(testlist[1].TypeName, "China");
            Assert.AreEqual(testlist[2].TypeName, "New Zealand");

            //Test ZA
            testlist = filter.SortZA(testlist);

            //With filter applied, verify results
            Assert.AreEqual(testlist[0].TypeName, "New Zealand");
            Assert.AreEqual(testlist[1].TypeName, "China");
            Assert.AreEqual(testlist[2].TypeName, "Australia");

            //Test Search, lower case
            testlist = filter.Search(testlist, "a");

            //Verify results
            Assert.AreEqual(testlist[0].TypeName, "New Zealand");
            Assert.AreEqual(testlist[1].TypeName, "China");
            Assert.AreEqual(testlist[2].TypeName, "Australia");

            //Test Search, upper case
            testlist = filter.Search(testlist, "A");

            //Verify results
            Assert.AreEqual(testlist[0].TypeName, "New Zealand");
            Assert.AreEqual(testlist[1].TypeName, "China");
            Assert.AreEqual(testlist[2].TypeName, "Australia");

            //Test Search, phrase
            testlist = filter.Search(testlist, "NEW");

            //Verify results
            Assert.AreEqual(testlist[0].TypeName, "New Zealand");
            Assert.AreEqual(testlist.Count(), 1);
        }
    }
}
