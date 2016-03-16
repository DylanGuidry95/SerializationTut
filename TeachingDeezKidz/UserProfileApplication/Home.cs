using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using TeachingDeezKidz;

namespace UserProfileApplication
{
    public partial class Home : Form
    {
        ArrayList UserProfiles;
        public UserProfile currentUser;

        public Home()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            currentUser = SaveLoad<UserProfile>.DeserializeSingle(Users.SelectedText);
            DisplayInfo frm = new DisplayInfo();
            frm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SaveLoad<UserProfile>.LocateFiles();
            UserProfiles = new ArrayList();
            UserProfiles = UpdateUsers();
            UpdateUserSelection();
        }

        private void UpdateUserSelection()
        {
            Users.Items.Clear();
            foreach(UserProfile profile in UserProfiles)
            {
                Users.Items.Add(profile.Name);
            }
        }

        private ArrayList UpdateUsers()
        {
            ArrayList temp = new ArrayList();
            temp = SaveLoad<UserProfile>.DeserializeMult();
            return temp;
        }
    }
}
