using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Drawing;

namespace Assignment1_Test
{
    //Tests for testing method from the FileManager class
    [TestClass]
    public class FileManager_Test
    {
        [TestMethod]
        public void LoadMyClass_Test()
        {
            
            PictureBox p = new PictureBox();//Declare an initialise a picture box used with class constructor
            FileManager fm = new FileManager();//Declare an initialise a file manager object
            List<MyClass> SheepsToLoad = new List<MyClass>();//Declare an initialise a list of MyClass objects
            SheepsToLoad.AddRange(fm.LoadMyClass("sheeps.txt", p));//Load the initial file into list of objects

            //Verify if loaded sheep name matches the expected names, means the file load had to occur
            Assert.AreEqual(SheepsToLoad[0].AnimalId, "Pilot 1");
            Assert.AreEqual(SheepsToLoad[1].AnimalId, "Pilot 3");
            Assert.AreEqual(SheepsToLoad[2].AnimalId, "Pilot 5");

            SheepsToLoad.Clear();//Clear the list of sheep

            //Try to load from non existing file
            //try catch added as AddRange will give an error and stop the testing if null
            try
            {
                SheepsToLoad.AddRange(fm.LoadMyClass("nofile.txt", p));//This file does not exist
                Assert.AreEqual("Empty file","Something was read");//This will only run when .AddRange succeeded.
            }
            catch (Exception) {
                Assert.AreEqual("Empty file", "Empty file");//As we expect a error we can assert a true statement.
            }

            try
            {
                SheepsToLoad.AddRange(fm.LoadMyClass("sheeps_error1.txt", p));//This file contains a blank line, no comma
                Assert.AreEqual("Empty file", "Something was read");//This will only run when .AddRange succeeded.
            }
            catch (Exception)
            {
                Assert.AreEqual("Empty file", "Empty file");//As we expect a error we can assert a true statement.
            }
            try
            {
                SheepsToLoad.AddRange(fm.LoadMyClass("sheeps_error2.txt", p));//This file contains a line that is too long, extra comma
                Assert.AreEqual("Empty file", "Something was read");//This will only run when .AddRange succeeded.
            }
            catch (Exception)
            {
                Assert.AreEqual("Empty file", "Empty file");//As we expect a error we can assert a true statement.
            }
        }
        [TestMethod]
        public void SaveMyClass_Test()
        {

            PictureBox p = new PictureBox();//Declare an initialise a picture box used with class constructor
            FileManager fm = new FileManager();//Declare an initialise a file manager object
            List<MyClass> SheepsToLoad = new List<MyClass>();//Declare an initialise a list of MyClass objects

            //Create 3 custom items and add them to the object list
            SheepsToLoad.Add(new MyClass("Test 1", 1, new System.Drawing.Point(0, 0), p));//NZ
            SheepsToLoad.Add(new MyClass("Test 2", 1, new System.Drawing.Point(0, 0), p));//China
            SheepsToLoad.Add(new MyClass("Test 3", 1, new System.Drawing.Point(0, 0), p));//AUS

            //Save the list to file, Should return true if successful
            Assert.IsTrue(fm.SaveMyClass(SheepsToLoad));

            //Clears the list of objects
            SheepsToLoad.Clear();

            //Now we load from the same file to see if it saved correctly
            SheepsToLoad.AddRange(fm.LoadMyClass("NewData.txt", p));

            //The list of objects returned should match the previously created names
            Assert.AreEqual(SheepsToLoad[0].AnimalId, "Test 1");
            Assert.AreEqual(SheepsToLoad[1].AnimalId, "Test 2");
            Assert.AreEqual(SheepsToLoad[2].AnimalId, "Test 3");

        }
    }
}
