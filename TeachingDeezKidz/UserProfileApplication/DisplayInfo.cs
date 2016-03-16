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
    public partial class DisplayInfo : Form
    {
        public DisplayInfo()
        {
            InitializeComponent();
        }

        private void DisplayInfo_Load(object sender, EventArgs e)
        {
            Home frm = new Home();
            Information.Text = frm.currentUser.Name + "\n" + frm.currentUser.Age + frm.currentUser.Gender + "\n" + frm.currentUser.Race;
        }
    }
}
