using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerlizationTutorialRedo
{
    using System.IO;

    public static class DataSerialization<T>
    {
        /// <summary>
        /// We invoke this function when have the data we want to serialize ready. The arguments we pass in to 
        /// the function call tell the application where to save the data which by default is the project 
        /// directory two files deep in a folder called SavedFiles and inside that folder we will find a file 
        /// with the name that mathces the data stored inside the string passed into the function call.
        /// Once that file has been found we then take the data passed into the fucntion and write it to said file
        /// </summary>
        /// <param name="fileName">Name of the file we are trying to save our data to</param>
        /// <param name="data">The data we are saving</param>
        public static void Serialize(string fileName, T data)
        {
            //Creates a new XMLSeualizer object with an argument of the type of the data passed in
            XmlSerializer serilaizer = new XmlSerializer(typeof(T));
            //Creates a new TextWritter object and assigns it a StreamWritter object that takes in an 
            //argument of the file path
            TextWriter writter = new StreamWriter(@"..\..\SavedFiles\" + fileName + ".xml");
            //Invoke the Serialze function from the XmlSerializer class and pass in the TextWritter object created
            //and the data we are trying to write to the file
            serilaizer.Serialize(writter, data);
            //Closes the file we where using to write our data
            writter.Close();
        }


        /// <summary>
        /// We invoke this function when we are trying load somedata back into our application that has all ready been saved.
        /// This function will break if you are trying to find a file that does not exist. We specify the file we are looking
        /// for by the data stored in the string passed into the function call.
        /// </summary>
        /// <param name="fileName">Name of the file we are trying to access to get our data</param>
        /// <returns></returns>
        public static T Deserialize(string fileName)
        {
            //Creates a new Generic object we will use to hold the data we are trying to return
            T data; 
            //Creates a new XmlSerializer objects with an argument of the type of the generic object we are trying to create
            XmlSerializer serilaizer = new XmlSerializer(typeof(T)); 
            //Creates a new TextReader object with a child object of the class with the argument of a string that is the file
            //directory of the file we are trying to get the data from
            TextReader reader = new StreamReader(@"..\..\SavedFiles\" + fileName + ".xml");
            //invokes the Deserialize function from the XmlSerializer class and casts the return as the generic type and
            //and passess in the TextReader object as an arguement into the funciton call
            data = (T)serilaizer.Deserialize(reader);
            //Closes the TextReader object file
            reader.Close();
            //Returns our generic object
            return data;
        }
    }
}
