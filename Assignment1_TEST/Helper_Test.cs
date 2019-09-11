using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Assignment1_Test
{
    [TestClass]
    public class Helper_Test
    {
        
        //public string CheckForDuplicate(List<MyClass> Sheeps, string NewName)
        //public string StatusLabel1(int count, long milliseconds)
        [TestMethod]
        public void CheckForDuplicate_Test()
        {
            
            PictureBox p = new PictureBox();//Declare an initialise a picture box used with class constructor
            List<MyClass> testlist = new List<MyClass>();//Declare an initialise a list of MyClass objects
            Helper H = new Helper();//Declare an initialise a Helper object

            //Run Helper method and verify result
            Assert.AreEqual("Test 1",H.CheckForDuplicate(testlist, "Test 1"));

            //Add item to the object list
            testlist.Add(new MyClass("Test 1", 1, new System.Drawing.Point(0, 0), p));//NZ

            //Run Helper method and verify result
            Assert.AreEqual("Test 1_1", H.CheckForDuplicate(testlist, "Test 1"));
        }

        [TestMethod]
        public void StatusLabel1_Test()
        {
            Helper H = new Helper();//Declare an initialise a Helper object

            //Run Helper method and verify result
            Assert.AreEqual("Number of Sheep / Objects: 5 FPS: 100", H.StatusLabel1(5, 10));
            Assert.AreEqual("Number of Sheep / Objects: 15 FPS: 1000", H.StatusLabel1(15, 0));
            Assert.AreEqual("Number of Sheep / Objects: 50 FPS: 1", H.StatusLabel1(50, 1000));

        }

        [TestMethod]
        public void StatusLabel2_Test()
        {
            ListBox testlbx = new ListBox();//Declare an initialise a list box for testing on
            PictureBox p = new PictureBox();//Declare an initialise a picture box used with MyClass constructor
            List<MyClass> testlist = new List<MyClass>();//Declare an initialise a list of MyClass objects
            Helper H = new Helper();//Declare an initialise a Helper object

            //Run Helper method and verify result
            Assert.AreEqual("No Current Sheep...", H.StatusLabel2(testlist, testlbx));

            //Create a custom item and add them to the object list
            testlist.Add(new MyClass("Test 1", 1, new System.Drawing.Point(0, 0), p));//NZ
            //Add item to the list box
            testlbx.Items.Add(testlist[0].ToString());
            //Change selected index of list box
            testlbx.SelectedIndex = 0;

            //Run Helper method and verify result
            Assert.AreEqual("Selected Sheep: " + testlist[0].ToString(), H.StatusLabel2(testlist, testlbx));
        }
        
        [TestMethod]
        public void RandomName_Test()
        {
            Helper H = new Helper();//Declare an initialise a Helper object
            string test = "";//Declare an initialise a Blank string
            test = H.RandomName(); //Use class method to generate a name

            //Verify if string is not blank anymore
            Assert.AreNotEqual(test.Length, 0);

        }
    }
}
