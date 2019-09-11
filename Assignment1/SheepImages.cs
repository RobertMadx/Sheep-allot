using System.Collections.Generic;
using System.Drawing;

namespace Assignment1
{
    /// <summary>
    /// This class is for keeping things less cluttered on the main form page. 
    /// It keeps all the images for the animations and only one instance is created when program is running.
    /// Only one constructor and three properties are used, no other fields or methods required.
    /// </summary>
    /// <remarks>Multiple images could be used to simulated to create an animated effect.
    /// Currently only 2 heads, 11 bodies and 2 feet are used</remarks>
    public class SheepImages
    {
        /// <value>
        /// List of images for the head of the sheep
        /// </value>
        public List<Image> Head { get;}
        /// <value>
        /// List of images for the body of the sheep
        /// </value>
        public List<Image> Body { get;}
        /// <value>
        /// List of images for the feet of the sheep
        /// </value>
        public List<Image> Feet { get;}

        /// <summary>
        /// The main constructor for the class, images are stored in resources of projects
        /// </summary>
        public SheepImages()
        {
            Head = new List<Image>();
            Body = new List<Image>();
            Feet = new List<Image>();

            Head.Add(Properties.Resources.head_selected);   // 0
            Head.Add(Properties.Resources.head_small1);     // 1

            Body.Add(Properties.Resources.selected);        // 0
            Body.Add(Properties.Resources.NZ);              // 1
            Body.Add(Properties.Resources.Australia);       // 2
            Body.Add(Properties.Resources.China);           // 3
            Body.Add(Properties.Resources.Germany);         // 4
            Body.Add(Properties.Resources.Italy);           // 5
            Body.Add(Properties.Resources.India);           // 6
            Body.Add(Properties.Resources.Japan);           // 7
            Body.Add(Properties.Resources.SA);              // 8
            Body.Add(Properties.Resources.USA);             // 9
            Body.Add(Properties.Resources.France);          // 10

            Feet.Add(Properties.Resources.legs_small1);     //0
            Feet.Add(Properties.Resources.legs_small2);     //1
        }

    }
}
