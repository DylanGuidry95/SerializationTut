using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachingDeezKidz;

namespace UserProfileApplication
{
    public partial class Form1 : SaveLoad<UserProfile>
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Refrence to the current user we are displaying information for
        UserProfile currentUser;

        /// <summary>
        /// Called when when the create user button is clicked
        /// 
        /// We set the values of the currentUser equal to the data in the various
        /// Input fields in our form and them we pass this information into our
        /// serialize function we created and inherited from the SaveLoad class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            currentUser = new UserProfile(Name.Text, Race.SelectedItem.ToString(), Gender.SelectedItem.ToString(), (int)Age.Value); //Creates the user
            Serialize("UserInfo", currentUser); //Passes the currentUser's name as the name we want our file to be saved as and we pass the currentUser in so we can
                                                      //add all of its serilizable data to the file
        }

        /// <summary>
        /// Called everytime the form is loaded
        /// Sets all the fields equal to the data in the 
        /// file we are opening
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            currentUser = Deserialize("UserInfo"); //Sets the current user equal to the value we retrived from the file we opened and read
            Name.Text = currentUser.Name;
            Race.Text = currentUser.Race;
            Age.Value = currentUser.Age;
            Gender.Text = currentUser.Gender;
        }
    }
}
