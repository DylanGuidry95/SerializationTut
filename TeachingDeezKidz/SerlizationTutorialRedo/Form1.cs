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

        private void SaveData_Click(object sender, EventArgs e)
        {
            Student curStudent = new Student(this.StudentName.Text, (int)this.StudentAge.Value, this.StudentID.Text);
            DataSerlization<Student>.Serialize("Student", curStudent);
        }

        private void LoadLast_Click(object sender, EventArgs e)
        {
            Student lastStudnet;
            lastStudnet = DataSerlization<Student>.DeSeralize("Student");
            this.StudentName.Text = lastStudnet.Name;
            this.StudentAge.Value = lastStudnet.Age;
            this.StudentID.Text = lastStudnet.ID.ToString();
        }
    }
}
