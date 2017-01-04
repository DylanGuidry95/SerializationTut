using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerlizationTutorialRedo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function that is invoked when the SaveData button is click by the user.
        /// This function will create a new student with the information provided by the user from the various
        /// fields on the winform.
        /// Once we have the student created we will invoke the Serialize function from the DataSerialization class.
        /// </summary>
        /// <param name="sender">Object that invoked this method</param>
        /// <param name="e">Arguments passed through by the object</param>
        private void SaveData_Click(object sender, EventArgs e)
        {
            //Creates a student and invokes the constructor with the arguments being the data from the various fields
            //in the winform
            Student curStudent = new Student(this.StudentName.Text, (int)this.StudentAge.Value, this.StudentID.Text);
            //Invokes the Serialize funciton from the DataSerialization class and gives it the arguements of the string
            //"Student" and the newly created student
            DataSerialization<Student>.Serialize("Student", curStudent);
        }

        /// <summary>
        /// Function that is invoked when he LoadLast button is clicked by the user.
        /// This function will invoke the Deserialize function to create a new student and take that data and assign
        /// the data from that student to the various fields.
        /// </summary>
        /// <param name="sender">Object that invoked this method</param>
        /// <param name="e">Arguments passed through by the object</param>
        private void LoadLast_Click(object sender, EventArgs e)
        {
            //Creates a new student with the information returned from the Deserialize function
            Student lastStudnet = DataSerialization<Student>.Deserialize("Student"); 
            this.StudentName.Text = lastStudnet.NAME;
            this.StudentAge.Value = lastStudnet.AGE;
            this.StudentID.Text = lastStudnet.ID.ToString();
        }
    }
}
