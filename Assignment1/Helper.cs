using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment1
{
    /// <summary>
    /// This class contains methods used by the main form, this should reduce clutter on main form.
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// Class method to check for duplicate sheep names
        /// </summary>
        /// <remarks>
        /// Receives a list of sheep objects and a proposed string new name and returns a unique new name
        /// </remarks>
        public string CheckForDuplicate(List<MyClass> Sheeps, string NewName) {
            string TryNew = NewName;
            int i = 0;
            //Source: https://stackoverflow.com/questions/16242885/c-sharp-search-query-with-linq
            //If the name already exists then add a _# to it, will increment until unique
            while (Sheeps.Where(q => (q.AnimalId).ToLower().Contains(TryNew.ToLower())).Count() > 0)
            {
                i++;
                TryNew = NewName + "_" + i;
            };
            return TryNew;
        }


        /// <summary>
        /// Class method to receive count and time to return a string for Status label strip 1
        /// </summary>
        public string StatusLabel1(int count, long milliseconds) {
            //'Shorthand if' was added to avoid a divide by 0.
            //With no objects to display the MoveAndShowAnimals might take less than 1 millisecond, rounded will be zero.
            return "Number of Sheep / Objects: " + count + " FPS: " + (1000 / ((milliseconds > 0) ? milliseconds : 1));
        }
        /// <summary>
        /// Class method that receives the list of Sheep and the list box object, return string to be displayed on Status label strip 2
        /// </summary>
        public string StatusLabel2(List<MyClass> Sheeps,ListBox lbxMyObjects)
        {
            //if item selected in list box, show information on status bar
            if (lbxMyObjects.SelectedIndex > -1)
            {
                return "Selected Sheep: " + Sheeps[lbxMyObjects.SelectedIndex].ToString();
            }
            else
            {
                return "No Current Sheep...";
            }
        }

        /// <summary>
        /// Simple method to return a random name
        /// </summary>
        public string RandomName()
        {
            //Get random number (0-30), then get a name matched with number, 0 = default = "Jinx"
            Random rnd = new Random();
            int i = rnd.Next(0, 31);

            switch (i)
            {
                case 1: return "Renee";
                case 2: return "Rochel";
                case 3: return "Louisa";
                case 4: return "Johnsie";
                case 5: return "Kasha";
                case 6: return "Lina";
                case 7: return "Hermina";
                case 8: return "Enedina";
                case 9: return "Marcell";
                case 10: return "Reggie";
                case 11: return "Yuk";
                case 12: return "Lanelle";
                case 13: return "Sherman";
                case 14: return "Wava";
                case 15: return "Bridgett";
                case 16: return "Sherwood";
                case 17: return "Shonda";
                case 18: return "Katherin";
                case 19: return "Faustina";
                case 20: return "Colene";
                case 21: return "Louanne";
                case 22: return "Izola";
                case 23: return "Georgina";
                case 24: return "Leanne";
                case 25: return "Bobbie";
                case 26: return "Francine";
                case 27: return "Gladys";
                case 28: return "Terri";
                case 29: return "Silvana";
                case 30: return "Tyree";
                default: return "Jinx";
            }
        }
    }
}
