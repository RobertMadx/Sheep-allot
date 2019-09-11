/** <summary>
  * Name of application:    Assignment1
  * Author:                 Robert Madden
  * Student number:         1721631
  * Course:                 D201 - Advanced Programming (S1 2019)
  * Purpose of Assignment:  "The intention of the benchmark application is to test your programming skills.
  * Being able to develop the benchmark application over the course of a few days will indicate reasonable proficiency in introductory C#." as provided in assignment.
  * </summary>
  */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Assignment1
{
    /// <summary>
    /// Main class used for form gui.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Global declaration of variables used in the application.
        /// </summary>
        
        // For indicating when a Search was done because the indexes of the items in the main list box will not match the list of sheep.
        bool Searched = false;
        // A list of results when searched, this will help to accurately remove sheep after search was done
        List<MyClass> results = new List<MyClass>();
        // A list of sheep images. Head, body and feet. I use 2 heads, 11 bodies and 2 feet.
        // Doing this will help with memory usage because the image is not created with every sheep object.
        SheepImages sheepparts = new SheepImages();
        // This is the bitmap draw area being used for creating the animation. Having it globally declared rather than locally reduces memory usage significantly.
        // The image will be cleared rather than recreated. 
        Bitmap DrawArea;
        List<MyClass> Sheeps = new List<MyClass>();// Main list of sheep objects.
        Helper H = new Helper();//Helper class with helpful methods

        /// <summary>
        /// Constructor of the win form class which Initializes all components.
        /// </summary>
        /// <remarks>The DrawArea bitmap dimension is set in this method</remarks>
        public Form1()
        {
            InitializeComponent();
            //Setting the draw area size after form was initialised
            DrawArea = new Bitmap(pbxScreen.Size.Width, pbxScreen.Size.Height);
        }

        /// <summary>
        /// Main method for doing animation
        /// </summary>
        /// <remarks>Both the character movement and image drawing occur here</remarks>
        public void MoveAndShowAnimals()
        {
            //Detects if form was resized, if so, resets draw area
            //Not having this will increase memory usage significantly
            if (DrawArea.Size != pbxScreen.Size) {
                DrawArea = new Bitmap(pbxScreen.Size.Width, pbxScreen.Size.Height);
            }
            //Declare and initialise the graphic object to be used for drawing from draw area image.
            Graphics g = Graphics.FromImage(DrawArea);
            g.Clear(Color.Transparent);//Reset the image


            
            int si = -1;//Declare and initialise index count to be used.
            //Check to see if Search was done, if so, the indexes will differ from sheep list
            if (!Searched)
            {
                si = lbxMyObjects.SelectedIndex;//No search was done so index matches
            }
            else
            {
                //Search was done so index needs to come from result list
                if (lbxMyObjects.SelectedIndex > -1) si = results[lbxMyObjects.SelectedIndex].Index;
            }

            int i = 0, FoundAt = -1; //Declare and initialise counter and currently selected index
            foreach (MyClass sheep in Sheeps) //Loop through all sheep to move and draw
            {
                sheep.Move(pbxScreen);//Do animation, using method in sheep class
                if (i == si) //if item selected in list box, get index, skip draw.
                {
                    FoundAt = i;
                }
                else
                {
                    sheep.DrawPic(g, sheepparts, false); //Draw if not selected
                }
                i++;
            }
            //if item selected in list box, draw sheep with selected image.
            if (FoundAt > -1) Sheeps[FoundAt].DrawPic(g, sheepparts, true);

            //All drawing was done on draw area and can now we set to picture box.
            pbxScreen.Image = DrawArea;
            //Dispose of graphics object. 
            g.Dispose();
        }

        
        /// <summary>
        /// Timer method for doing animation every 0.1s.
        /// </summary>
        /// <remarks>This method also updates the status bar with progress</remarks>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Added stopwatch to do frames per second calculation
            Stopwatch timer = new Stopwatch();
            timer.Start();

            MoveAndShowAnimals();// Move and draw all sheep objects

            timer.Stop();

            //Update the status bar text
            toolStripStatusLabel1.Text = H.StatusLabel1(Sheeps.Count(), timer.ElapsedMilliseconds);
            toolStripStatusLabel2.Text = H.StatusLabel2(Sheeps, lbxMyObjects);
        }

        /// <summary>
        /// Click event handler for showing sheep objects in list box
        /// </summary>
        /// <remarks>Because I added the auto scroll method and update the list when changed, this method might become redundant</remarks>
        private void btnShowStatus_Click(object sender, EventArgs e)
        {
            //Reset if search was done and clears list box.
            Searched = false;
            results.Clear();
            lbxMyObjects.Items.Clear();
            //Loop through sheep list and add each to list box
            foreach (MyClass sheep in Sheeps)
            {
                lbxMyObjects.Items.Add(sheep.ToString());
            }
        }

        /// <summary>
        /// Click event handler for loading initial sheep data, from read only file.
        /// </summary>
        /// <remarks>I assumed any existing objects had to be removed before load.</remarks>
        private void LoadInitialData_Click(object sender, EventArgs e)
        {
            //Clear any existing objects, used existing click event method.
            btnClear_Click(sender, e);
            //Declare and initialise file manager object as well as a temporary sheep list.
            //Temp list is to check for duplicates
            FileManager fm = new FileManager();
            List<MyClass> SheepsToLoad = new List<MyClass>();
            //Load list from "sheeps.txt", if list is empty, exit method
            try
            {
                Sheeps.AddRange(fm.LoadMyClass("sheeps.txt", pbxScreen));
            }
            catch (Exception) {
                return;
            }

            //Loop through the temporary loaded list to see if the name might already exist
            foreach (MyClass sheep in Sheeps)
            {
                lbxMyObjects.Items.Add(sheep.ToString());
            }
            //Do auto scroll method on list box to show latest additions
            lbxMyObjects.AutoScrollListBox();
        }

        /// <summary>
        /// Click event handler for loading initial sheep data, from read only file.
        /// </summary>
        /// <remarks>I assumed any existing objects was not to be removed before loading.</remarks>
        private void btnLoadPreviousSaving_Click(object sender, EventArgs e)
        {
            //Declare and initialise file manager object as well as a temporary sheep list.
            //Temp list is to check for duplicates
            FileManager fm = new FileManager();
            List<MyClass> SheepsToLoad = new List<MyClass>();
            //Load list from the "NewData.txt" file

            //Load list from "NewData.txt", if list is empty, exit method
            try
            {
                SheepsToLoad.AddRange(fm.LoadMyClass("NewData.txt", pbxScreen));
            }
            catch (Exception)
            {
                return;
            }

            //Loop through the temporary loaded list to see if the name might already exist
            foreach (MyClass sheep in SheepsToLoad)
            {
                
                sheep.AnimalId = H.CheckForDuplicate(Sheeps, sheep.AnimalId);
                //Now that we know it's not a duplicate name, add to existing list
                Sheeps.Add(sheep);
                lbxMyObjects.Items.Add(sheep.ToString());
            }
            //Do auto scroll method on list box to show latest additions
            lbxMyObjects.AutoScrollListBox();
        }

        /// <summary>
        /// Click event handler for Searching sheep by type, in this case, country.
        /// </summary>
        private void btnSearchByType_Click(object sender, EventArgs e)
        {
            //Declare and initialise the search term
            string SearchTerm = tbxSearch.Text;
            //Check to see of something was entered, if not advise user
            if (SearchTerm == "") {
                MessageBox.Show("Please enter a sheep type to be searched.", "Empty search term");
                return;
            }
            //Check to see a comma was used in search term, we want to avoid any use of the comma
            if (SearchTerm.Contains(","))
            {
                MessageBox.Show("Please enter a sheep type to be searched, comma are not allowed in search term.", "Empty search term");
                return;
            }

            //Declare and initialise the filter object
            Filter filter = new Filter();
            //Clear the results list, in case previous searches was done and load results using search term
            results.Clear();
            results = filter.Search(Sheeps, SearchTerm);
            //Load the results to list box
            lbxMyObjects.Items.Clear();
            lbxMyObjects.Items.AddRange(results.ToArray());
            //Global variable helping us remember we have done a search and indexes won't match
            Searched = true;
        }

        /// <summary>
        /// Click event handler for saving current list of sheep.
        /// </summary>
        private void btnSaveCurrentList_Click(object sender, EventArgs e)
        {
            //Declare and initialise the file manager object. Then use method from the class to save it.
            FileManager fm = new FileManager();
            fm.SaveMyClass(Sheeps);
        }

        /// <summary>
        /// Click event handler for clearing both the sheep list and list box
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear both the Sheep list and list box and reset search
            Sheeps.Clear();
            lbxMyObjects.Items.Clear();
            Searched = false;
        }

        /// <summary>
        /// Click event handler for sorting the list of objects by type, ascending.
        /// </summary>
        private void btnSortZA_Click(object sender, EventArgs e)
        {

            //Declare and initialise the filter object
            Filter filter = new Filter();
            //Used method from class to sort list
            Sheeps = filter.SortZA(Sheeps);
            //Clear the list box
            lbxMyObjects.Items.Clear();
            //Reload all objects from sheep list using existing click event method
            btnShowStatus_Click(sender, e);

        }

        /// <summary>
        /// Click event handler for sorting the list of objects by type, descending.
        /// </summary>
        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            //Declare and initialise the filter object
            Filter filter = new Filter();
            //Used method from class to sort list
            Sheeps = filter.SortAZ(Sheeps);
            //Clear the list box
            lbxMyObjects.Items.Clear();
            //Reload all objects from sheep list using existing click event method
            btnShowStatus_Click(sender, e);
        }

        /// <summary>
        /// Click event handler for removing the selected object from list
        /// </summary>
        /// <remarks>If a search was done the indexes will differ so we had to avoid removing the wrong sheep</remarks>
        private void btnRemoveSelectedObj_Click(object sender, EventArgs e)
        {
            //If nothing was selected then advise user and exit method
            if (lbxMyObjects.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item from the list to removed.", "No index selected");
                return;
            }
            //If a search was not done, remove the selected index from list. Else remove the results index that matches the sheep from the list
            if (!Searched)
            {
                Sheeps.RemoveAt(lbxMyObjects.SelectedIndex);
                lbxMyObjects.Items.RemoveAt(lbxMyObjects.SelectedIndex);
            }
            else
            {
                Sheeps.RemoveAt(results[lbxMyObjects.SelectedIndex].Index);
                lbxMyObjects.Items.RemoveAt(lbxMyObjects.SelectedIndex);
            }

        }

        /// <summary>
        /// Click event handler for creating a new random sheep
        /// </summary>
        private void pbxScreen_MouseUp(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11); //Get a new random number (1 to 10)
            Point ClickLocation = new Point(e.X, e.Y); //Get click location, we can easily get a random location but it was more fun to create a sheep where clicked.

            //With a unique name, random type and at mouse click location, declare and initialise a sheep and add to list
            MyClass sheep1 = new MyClass(H.CheckForDuplicate(Sheeps,H.RandomName()), randomNumber, ClickLocation, pbxScreen);
            Sheeps.Add(sheep1);
            lbxMyObjects.Items.Add(sheep1.ToString());
            //Do auto scroll method on list box to show latest additions
            lbxMyObjects.AutoScrollListBox();
        }
    }
}
