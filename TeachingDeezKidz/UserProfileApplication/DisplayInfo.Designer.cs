namespace UserProfileApplication
{
    partial class DisplayInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.RichTextBox();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Back";
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(13, 40);
            this.Information.Name = "Information";
            this.Information.ReadOnly = true;
            this.Information.Size = new System.Drawing.Size(152, 96);
            this.Information.TabIndex = 1;
            this.Information.Text = "";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(16, 156);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 2;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // DisplayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 193);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.label1);
            this.Name = "DisplayInfo";
            this.Text = "DisplayInfo";
            this.Load += new System.EventHandler(this.DisplayInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Information;
        private System.Windows.Forms.Button Return;
    }
}