using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Test
{
    //Tests for testing method from the MyClass class
    //Only 5 methods are public, 2 were privately declared and cannot be reached through unit test (head and feet)
    [TestClass]
    public class MyClass_Test
    {
        [TestMethod]
        public void MyClassConstructor_Test()
        {
            PictureBox p = new PictureBox();//Declare an initialise a picture box used with class constructor
            //Create a MyClass object with type = 1 = "New Zealand" and name = "Test", X and Y position should default to 1
            MyClass testitem1 = new MyClass("Test", 1, new System.Drawing.Point(0, 0), p); //NZ

            //Verify if object information is correct which means object was constructed correctly
            Assert.AreEqual(testitem1.TypeName, "New Zealand");
            Assert.AreEqual(testitem1.AnimalId, "Test");
            Assert.AreEqual(testitem1.Index, 0);
            Assert.AreEqual(testitem1.Xposition, 1);
            Assert.AreEqual(testitem1.Yposition, 1);
        }
        [TestMethod]
        public void DrawPic_Test()
        {
            //Visual Test because we are drawing images
        }
        [TestMethod]
        public void ToStringSave_Test()
        {
            PictureBox p = new PictureBox();//Declare and initialise a picture box used with class constructor
            //Create a MyClass object with type = 1 = "New Zealand" and name = "Test", X and Y position should default to 1
            MyClass testitem = new MyClass("Test", 1, new System.Drawing.Point(0, 0), p); //NZ

            //Verify if string returned matches
            Assert.AreEqual(testitem.ToStringSave(), "Test,1"); // MyClass Generates random sheep name

        }
        [TestMethod]
        public void Move_Test()
        {
            PictureBox p = new PictureBox();//Declare and initialise a picture box used with class constructor
            //Create a MyClass object with type = 1 = "New Zealand" and name = "Test", X and Y position should default to 1
            MyClass testitem = new MyClass("Test", 1, new System.Drawing.Point(0, 0), p); //NZ

            //Run the Move method
            testitem.Move(p);

            //Verify if the move added X and Y step correctly
            Assert.AreEqual(testitem.Xposition, 1 + testitem.Xstep);
            Assert.AreEqual(testitem.Yposition, 1 + testitem.Ystep);
        }
        [TestMethod]
        public void ToString_Test()
        {
            PictureBox p = new PictureBox();//Declare and initialise a picture box used with class constructor
            //Create a MyClass object with type = 1 = "New Zealand" and name = "Test", X and Y position should default to 1
            MyClass testitem = new MyClass("Test", 1, new System.Drawing.Point(0, 0), p); //NZ

            //Verify if string returned is correct
            Assert.AreEqual(testitem.ToString(), ("Test (New Zealand). X Speed: " + testitem.Xstep.ToString() + ", Y Speed: " + testitem.Ystep.ToString()));
            
        }
    }
}
