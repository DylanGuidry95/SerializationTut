namespace UserProfileApplication
{
    partial class Home
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
            this.NewUser = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewUser
            // 
            this.NewUser.Location = new System.Drawing.Point(12, 99);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(75, 23);
            this.NewUser.TabIndex = 0;
            this.NewUser.Text = "New User";
            this.NewUser.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.Location = new System.Drawing.Point(12, 28);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(121, 21);
            this.Users.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Existing User";
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(12, 71);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 22);
            this.LogIn.TabIndex = 3;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 133);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.NewUser);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.ComboBox Users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogIn;
    }
}