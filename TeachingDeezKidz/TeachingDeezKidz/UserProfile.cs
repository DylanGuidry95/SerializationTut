using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingDeezKidz
{
    /// <summary>
    /// This is an example class for a simple User profile
    /// It contains some basic information we may want to know about 
    /// the user using our application
    /// 
    /// With the information we acquire from the user we will persist it 
    /// to a file.
    /////////////////////////////////////////////////////////////////////////////// 
    /// In this class we want all the information in the class to have the ability
    /// to be persisted to a file. We do this by adding the Serializable token above
    /// the class decleration.
    /// </summary>
    [Serializable()]
    public class UserProfile
    {
        private string m_Name; //Name of the player
        private string m_Race; //Race of the player
        private string m_Gender; //Gender of the player
        private int m_Age; //Age of the player

        public string Name { get { return m_Name; } } //Called from other classes and returns the value stored in m_Name
        public string Race { get { return m_Race; } } //Called from other classes and returns the value stored in m_Race 
        public string Gender { get { return m_Gender; } } //Called from other classes and returns the value stored in m_Gender
        public int Age { get { return m_Age; } } //Called from other classes and returns the value stored in m_Age

        /// <summary>
        /// Constructor used to create and instance of a player object
        /// Takes the values of the arguments and assign them to the appropriate
        /// variables in the class
        /// </summary>
        /// <param name="n"> Name of the player </param>
        /// <param name="r"> Race of the player </param>
        /// <param name="g"> Gender of the player </param>
        /// <param name="a"> Age of the player </param>
        public UserProfile(string n, string r, string g, int a)
        {
            m_Name = n;
            m_Race = r;
            m_Gender = g;
            m_Age = a;
        }

        /// <summary>
        /// Default constructor for the UserProfile class 
        /// </summary>
        public UserProfile()
        {
            m_Name = "Dylan";
            m_Race = "White";
            m_Gender = "Male";
            m_Age = 20;
        }
    }
}
