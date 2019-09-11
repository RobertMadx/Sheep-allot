using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment1
{
    /// <summary>
    /// Class to handle all the moving and drawing of the sheep
    /// </summary>
    /// <remarks>The field and property to keep an image was removed to enhance performance as well as helps with animation
    /// This class consists of 7 fields, 7 properties and 7 methods.
    /// </remarks>
    public class MyClass
    {
        //Fields used in MyClass
        private int headxposition;  //x - position of head
        private int headyposition;  //y - position of head
        private int feetstate;      //feet state, int value that reduces or increase each tick, change image when 0
        
        private int width; //width of image, changes with y location
        private int height; //height of image, changes with y location
        private int typeid; //Sheep type id
        private int speed; //Feet change speed of sheep

        /// <summary>
        /// AnimalId property 
        /// </summary>
        /// <value>
        /// For holding sheep name.
        /// </value>
        public string AnimalId { get; set; }
        /// <summary>
        /// TypeName property 
        /// </summary>
        /// <value>
        /// For holding sheep type, in this case country.
        /// </value>
        public string TypeName { get; set; }
        /// <summary>
        /// Index property 
        /// </summary>
        /// <value>
        /// For holding an index in list, used with search and remove.
        /// </value>
        public int Index { get; set; }
        /// <summary>
        /// X step property 
        /// </summary>
        /// <value>
        /// Storing the X axle increase or decrease value
        /// </value>
        public int Xstep { get; set; }
        /// <summary>
        /// Y step property 
        /// </summary>
        /// <value>
        /// Storing the Y axle increase or decrease value
        /// </value>
        public int Ystep { get; set; }
        /// <summary>
        /// X position property 
        /// </summary>
        /// <value>
        /// Storing the current x-axle position
        /// </value>
        public int Xposition { get; set; }
        /// <summary>
        /// Y position property 
        /// </summary>
        /// <value>
        /// Storing the current y-axle position
        /// </value>
        public int Yposition { get; set; }

        //public Image AnimalPic { get; set; } Removed to increase performance.

        /// <summary>
        /// Constructor for the MyClass class
        /// </summary>
        /// <remarks>Receives sheep name as string, seed as integer which are used for type id and type name, 
        /// a point with x and y values for the spawn location and a picture box to calculate the allowed spawn area.
        /// As the picture box changes the spawn area will adjust accordingly. 
        /// Try is in run time if you like, the sheep will eventually bunch together if the form size is reduced.
        /// </remarks>
        public MyClass(string id, int seed, Point SpawnLocation, PictureBox GrassArea)
        {
            Random rnd = new Random();//used to get a random step value

            AnimalId = id;//set sheep name to id provided
            
            typeid = seed;//set type id as provided
            //Index only used when searched, see 'Filter.cs' - Search
            Index = 0; 

            //Get the TypeName matching the type id
            switch (typeid)
            {
                case 1:
                    TypeName = "New Zealand";
                    break;
                case 2:
                    TypeName = "Australia";
                    break;
                case 3:
                    TypeName = "China";
                    break;
                case 4:
                    TypeName = "Germany";
                    break;
                case 5:
                    TypeName = "Italy";
                    break;
                case 6:
                    TypeName = "India";
                    break;
                case 7:
                    TypeName = "Japan";
                    break;
                case 8:
                    TypeName = "South Africa";
                    break;
                case 9:
                    TypeName = "America";
                    break;
                default:
                    TypeName = "France";
                    break;
            }

            //Set width and height of image according to Y axle location
            width = 80 + (SpawnLocation.Y / 10);
            height = 80 + (SpawnLocation.Y / 10);

            //Check to see if spawn x location is not on edge, if so create image at offset location
            if (SpawnLocation.X <= width)
            {
                Xposition = SpawnLocation.X + 1; // +1 avoid creating sheep at x=0
            }
            else if (SpawnLocation.X >= (GrassArea.Width - width))
            {
                Xposition = GrassArea.Width - width;
            }
            else {
                Xposition = SpawnLocation.X - (width / 2);
            }

            //Check to see if spawn y location is not on edge, if so create image at offset location
            if (SpawnLocation.Y <= height)
            {
                Yposition = SpawnLocation.Y + 1;// +1 avoid creating sheep at y=0
            }
            else if (SpawnLocation.Y >= (GrassArea.Height - height))
            {
                Yposition = GrassArea.Height - height;
            }
            else
            {
                Yposition = SpawnLocation.Y - (height / 2);
            }

            //set head start position a middle
            headxposition = Xposition + 20;
            headyposition = Yposition + 20;

            //Set random step values, for speed
            Xstep = rnd.Next(1, 15);
            Ystep = rnd.Next(1, 10);

            //Feet changes depending on step values, the faster movement the faster the feet will change
            //feetstate = 11 - type id;
            speed = ((Xstep + Ystep)/2); //max-23 (23 / 2 = 11.5 or 12)
            feetstate = 13 - speed;//13 - max speed of 12 = 1, at fastest step feet will change every second tick

            // This will provide a random initial X direction, 50% change of either positive or negative movement
            if (rnd.Next(1, 3) == 1)
            {
                Xstep = -Xstep;
            }

            // This will provide a random initial Y direction, 50% change of either positive or negative movement
            if (rnd.Next(1, 3) == 1)
            {
                Ystep = -Ystep;
            }
        }
        
        /// <summary>
        /// This class method will draw the sheep image at location
        /// </summary>
        public void DrawPic(Graphics canvas,SheepImages sp, bool Selected)
        {
            //The order of the following is important as we are drawing layers of images   
            canvas.DrawImage(sp.Feet[GetFeetstate()], Xposition, Yposition, width , height ); //Draw feet
            canvas.DrawImage(sp.Body[typeid], Xposition, Yposition, width, height ); //Draw body
            if (Selected)
            {
                //Declare and initialise graphics to be used, only if selected
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Yellow);
                StringFormat drawFormat = new StringFormat();

                canvas.DrawImage(sp.Body[0], Xposition, Yposition, width, height); //Draw selected body over existing body
                canvas.DrawString(AnimalId, drawFont, drawBrush, Xposition, Yposition - 40, drawFormat);//Draw selected animal name
                canvas.DrawString(TypeName, drawFont, drawBrush, Xposition, Yposition - 20, drawFormat);//Draw selected animal type or country

            }
            
            canvas.DrawImage(sp.Head[1], headxposition, headyposition, (width- 40), (height-40));// Draw the head of sheep
            if (Selected)
            {
                canvas.DrawImage(sp.Head[0], headxposition, headyposition, (width - 40), (height - 40));//Draw selected head over existing head
            }
            
        }

        /// <summary>
        /// Class method to get and set the feet state of sheep
        /// </summary>
        /// <remarks>The state will change depending on int value that reduces or increase each tick, change image when 0</remarks>
        private int GetFeetstate() {
            int FeetId = 0;//by default the method will return 0
            if (feetstate > 0)
            {
                //reduce until 0
                feetstate--;
                if (feetstate == 0) feetstate = -13 + speed;
                //FeetID already set to 0, no change required
            }
            else if (feetstate < 0)
            {
                //increase until 0
                feetstate++;
                if (feetstate == 0) feetstate = 13 - speed;
                //Feet will draw as 1 but next run will change to 0
                FeetId = 1;
            }
            return FeetId;
        }

        /// <summary>
        /// Class method used to create string line for saving to a file
        /// </summary>
        public string ToStringSave()
        {
            return AnimalId + "," + typeid;
        }

        /// <summary>
        /// Class method to move object
        /// </summary>
        /// <remarks>
        /// Accepts parameters of picture box to calculate max draw area, detecting boundaries
        /// </remarks>
        public void Move(PictureBox GrassArea)
        {
            //Change Xstep when boundary is hit
            if ((Xposition + width >= GrassArea.Width - Xstep) || (Xposition + Xstep <= 0))
            {
                Xstep = -Xstep;
                if (Xposition + width >= GrassArea.Width - Xstep) {
                    if (Xstep > 0) Xstep = -Xstep;
                } else if (Xposition + Xstep <= 0) {
                    if (Xstep < 0) Xstep = -Xstep;
                }
            }
            Xposition = Xposition + Xstep;
            headxposition = headxposition + Xstep;

            //Change Y step when boundary is hit
            if ((Yposition + height >= GrassArea.Height - Ystep) || (Yposition + Ystep <= 0))
            {
                Ystep = -Ystep;
                if (Yposition + height >= GrassArea.Height - Ystep) {
                    if (Ystep > 0) Ystep = -Ystep;
                } else if (Yposition + Ystep <= 0) {
                    if (Ystep < 0) Ystep = -Ystep;
                }
            }
            Yposition = Yposition + Ystep;
            headyposition = headyposition + Ystep;

            //Reset the size of the image to accommodate Y location move
            //Y should not be 0 to avoid divide by 0, incorporated above
            width = 80 + (Yposition / 10);
            height = 80 + (Yposition / 10);

            //private method to move the head of the sheep
            MoveHead();
        }

        /// <summary>
        /// Private class method to move head of sheep
        /// </summary>
        private void MoveHead() {

            //Depending on current X step(left - or right +), the sheep head position x will change
            if (Xstep > 0)
            {
                //Increase if less than right boundary of body
                if (headxposition < (Xposition + (width * 0.3f)))
                {
                    headxposition = headxposition + 2;
                }
            }
            else
            {
                //Reduce if more than left boundary of body
                if (headxposition > Xposition)
                {
                    headxposition = headxposition - 2;
                }
            }

            //Depending on current Y step(up - or down +), the sheep head position y will change
            if (Ystep > 0)
            {
                //Increase if less than lower boundary of body
                if (headyposition < (Yposition + (height * 0.35f)))
                {
                    headyposition = headyposition + 2;
                }
            }
            else
            {
                //Reduce if more than upper boundary of body
                if (headyposition > Yposition)
                {
                    headyposition = headyposition - 2;
                }
            }
        }

        /// <summary>
        /// Class method overriding the ToString method
        /// </summary>
        /// <remarks>
        /// This will return the sheep name, TypeName, X step and Y step in a string format.
        /// </remarks>
        public override string ToString()
        {
            return AnimalId + " (" + TypeName + "). X Speed: " + Xstep.ToString() + ", Y Speed: " + Ystep.ToString();
        }
    }
}
