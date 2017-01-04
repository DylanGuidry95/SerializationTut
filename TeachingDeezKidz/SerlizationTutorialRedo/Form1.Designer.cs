namespace SerlizationTutorialRedo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentName = new System.Windows.Forms.TextBox();
            this.StudentAge = new System.Windows.Forms.NumericUpDown();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.SaveData = new System.Windows.Forms.Button();
            this.LoadLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentAge)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(12, 25);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(100, 20);
            this.StudentName.TabIndex = 0;
            // 
            // StudentAge
            // 
            this.StudentAge.Location = new System.Drawing.Point(15, 64);
            this.StudentAge.Name = "StudentAge";
            this.StudentAge.Size = new System.Drawing.Size(55, 20);
            this.StudentAge.TabIndex = 1;
            // 
            // StudentID
            // 
            this.StudentID.Location = new System.Drawing.Point(12, 106);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(100, 20);
            this.StudentID.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 9);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(12, 48);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(26, 13);
            this.Student.TabIndex = 4;
            this.Student.Text = "Age";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 87);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(58, 13);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID Number";
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(12, 133);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(75, 23);
            this.SaveData.TabIndex = 6;
            this.SaveData.Text = "Save";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // LoadLast
            // 
            this.LoadLast.Location = new System.Drawing.Point(94, 132);
            this.LoadLast.Name = "LoadLast";
            this.LoadLast.Size = new System.Drawing.Size(75, 23);
            this.LoadLast.TabIndex = 7;
            this.LoadLast.Text = "Load";
            this.LoadLast.UseVisualStyleBackColor = true;
            this.LoadLast.Click += new System.EventHandler(this.LoadLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 169);
            this.Controls.Add(this.LoadLast);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.StudentAge);
            this.Controls.Add(this.StudentName);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudentAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.NumericUpDown StudentAge;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button LoadLast;
    }
}

