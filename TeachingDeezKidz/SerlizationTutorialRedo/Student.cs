using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerlizationTutorialRedo
{
    public class Student
    {
        private string mName; //Name of the Student

        private int mAge; //Age of the Student
         
        private string mID; //Students unique ID

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Student()
        {
            
        }

        /// <summary>
        /// Constructor that assigns data to our class properties
        /// </summary>
        /// <param name="name">Student Name</param>
        /// <param name="age">Student Age</param>
        /// <param name="id">Student ID</param>
        public Student(string name, int age, string id)
        {
            this.mName = name; //Assigns mName the value of name
            this.mAge = age; //Assigns mAge the value of age
            this.mID = id; //Assigns mID the value of id
        }

        /// <summary>
        /// Gets and Sets the value of mName
        /// </summary>
        public string NAME
        {
            get { return this.mName; }
            set { this.mName = value; }
        }

        /// <summary>
        /// Gets and Sets the value of mAge
        /// </summary>
        public int AGE
        {
            get { return this.mAge; }
            set { this.mAge = value; }
        }

        /// <summary>
        /// Gets and Sets the value of mID
        /// </summary>
        public string ID
        {
            get { return this.mID; }
            set { this.mID = value; }
        }
    }
}
