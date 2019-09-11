using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    /// <summary>
    /// The Filter class is used to sort a list of objects and to search for items in a list of objects.
    /// This class only uses 3 methods and no constructors, fields or properties
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// The SortAZ class method receives a list of objects, sorts it ascending by type name, then returns a sorted list when completed.
        /// </summary>
        public List<MyClass> SortAZ(List<MyClass> cList)
        {
            //Using LINQ to sort list of objects ascending
            cList = (from x in cList
                     orderby x.TypeName ascending
                     select x).ToList();

            return cList;
        }

        /// <summary>
        /// The SortZA class method receives a list of objects, sorts it descending by type name, then returns a sorted list when completed.
        /// </summary>
        public List<MyClass> SortZA(List<MyClass> cList)
        {
            //Using LINQ to sort list of objects descending
            cList = (from x in cList
                     orderby x.TypeName descending
                     select x).ToList();

            return cList;
        }

        /// <summary>
        /// The Search class method receives a list of objects and a search term, look through the list of objects and returns a list of objects where the type contains the search term.
        /// </summary>
        /// <remarks>A Lambda query was used for the search but because we need to keep track of the indexes, there is a presence of a for each loop</remarks>
        public List<MyClass> Search(List<MyClass> cList, string term)
        {
            //First we need to get and set current indexes before search occurs
            int i = 0;
            foreach (MyClass c in cList)
            {
                if (c.TypeName.ToLower().Contains(term.ToLower()))
                {
                    c.Index = i;//The will keep the original index with the object, for if and when you want to delete it.
                }
                i++;
            }
            //Now we can create a results list for search to be done
            List<MyClass> results = new List<MyClass>();

            //LINQ expression to query and search for term
            results = (from x in cList
                       where x.TypeName.ToLower().Contains(term.ToLower())
                     select x).ToList();
            //return results as a list
            return results;
        }
    }
}
