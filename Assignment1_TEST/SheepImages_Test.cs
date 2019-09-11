using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System.Linq;

namespace Assignment1_Test
{
    //Tests for testing method from the SheepImages class
    [TestClass]
    public class SheepImages_Test
    {
        [TestMethod]
        public void SheepImagesConstructor_Test()
        {
            //Declare and initialise a SheepImage object
            SheepImages testsheep = new SheepImages();

            //Verify that if constructed the correct quantity of images
            Assert.AreEqual(testsheep.Head.Count(), 2,"Too many head images loaded");
            Assert.AreEqual(testsheep.Body.Count(), 11, "Too many body images loaded");
            Assert.AreEqual(testsheep.Feet.Count(), 2, "Too many feet images loaded");
        }
    }
}
