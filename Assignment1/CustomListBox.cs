using System;
using System.Windows.Forms;

namespace Assignment1
{
    /// <summary>
    /// This class is a for adding a method to the existing list box control. 
    /// </summary>
    /// <remarks> The method was from https://stackoverflow.com/questions/8796747/how-to-scroll-to-bottom-of-listbox. 
    /// It seemed like a good addition to any list box control</remarks>
    public partial class CustomListBox : ListBox
    {
        /// <summary>
        /// This is an auto scroll method used to auto scroll a list box when new items are added.
        /// </summary>
        public void AutoScrollListBox()
        {
            //Found the code snippet below on-line to auto scroll lbxMyObjects list box
            //Reference: https://stackoverflow.com/questions/8796747/how-to-scroll-to-bottom-of-listbox
            //It is calculating witch item in list to have as the top index
            int visibleItems = ClientSize.Height / ItemHeight;
            TopIndex = Math.Max(Items.Count - visibleItems + 1, 0);
        }
    }
}
