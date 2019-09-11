using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment1
{
    /// <summary>
    /// File manager class to read and write to a file.
    /// This class only uses two methods, LoadMyClass and SaveMyClass and no constructors, fields or properties
    /// </summary>
    public class FileManager
    {
        /// <summary>
        /// Public class to load items into a list from a file. Receives a filename as string and a picture box to determine the spawn area limits.
        /// If successful it returns a list of sheep objects, null if not.
        /// </summary>
        /// <remarks>Gives and error if the file does not exists or if the data is incorrect</remarks>
        public List<MyClass> LoadMyClass(string filename, PictureBox GrassArea)
        {
            //Declare and initialise a random int generator.
            Random rnd = new Random();

            //try and catch for file read error
            try
            {
                //Declare and initialise a temporary list of objects for loading into from file
                List<MyClass> SheepListReturn = new List<MyClass>();
                //Declare and initialise the stream reader to read from file
                StreamReader sr = new StreamReader(filename);
                //Count for showing any load errors in message box
                int i = 1;
                
                while (!sr.EndOfStream)//Loop while not EOF
                {
                    //Read the text line
                    string temp = sr.ReadLine();
                    //Split it into and array by comma
                    string[] values = temp.Split(',');
                    //if the array do not have 2 items in, the data must be corrupt. Advise user accordingly.
                    if (values.Count() != 2) {
                        if (values.Count() > 2)
                        {
                            MessageBox.Show($"ReadLine from file too long in filename '{filename}' at line {i}.\nReadLine = '{temp}'", "File read error");
                        } else
                        {
                            MessageBox.Show($"ReadLine from file too short in filename '{filename}' at line {i}.\nReadLine = '{temp}'", "File read error");
                        }
                        sr.Close();
                        return null;
                    }
                    //Generate a random spawn location using picture box dimensions
                    Point SpawnLocation = new Point(rnd.Next(1, GrassArea.Width), rnd.Next(1, GrassArea.Height));
                    //Declare and initialise object for sheep
                    MyClass s = new MyClass(values[0], int.Parse(values[1]), SpawnLocation, GrassArea);
                    //Add it to the list of sheep
                    SheepListReturn.Add(s);
                    //Increment the count, used to display error
                    i++;
                }
                //Close the file after reading is.
                sr.Close();
                
                return SheepListReturn; //Return the result list
            }
            catch (Exception) //Error handling if file does not exist
            {
                MessageBox.Show($"Unable to read file '{filename}'", "File read error");
                return null;
            }

        }

        /// <summary>
        /// Public class to load items into a list from a file. 
        /// Receives a list of sheep objects and return true when file was saved successfully, false if not
        /// </summary>
        public bool SaveMyClass(List<MyClass> Sheeps)
        {
            //try and catch in the event of an file write error.
            try
            {
                //Create a file manager object to file "NewData.txt"
                StreamWriter sw = new StreamWriter("NewData.txt",false);
                //Loop through list of sheep and writes to the file.
                foreach (MyClass sheep in Sheeps)
                {
                    sw.WriteLine(sheep.ToStringSave());
                }
                //closes the file when completed
                sw.Close();
                //Advise user that the file was saved successfully and return true.
                MessageBox.Show("All data have been saved.", "Save successful");
                return true;
            }
            catch (Exception)
            {
                //Advise user that the file was not saved successfully and return false.
                MessageBox.Show("File save error", "Save unsuccessful");
                return false;
            }
        }
    }
}
