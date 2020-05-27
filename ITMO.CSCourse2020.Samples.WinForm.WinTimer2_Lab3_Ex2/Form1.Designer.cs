namespace ITMO.CSCourse2020.Samples.WinForm.WinTimer2
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
            this.userControl11 = new ITMO.CSCourse2020.Samples.WinForm.ControlLibraryTimer.UserControl1();
            this.userControl12 = new ITMO.CSCourse2020.Samples.WinForm.ControlLibraryTimer.UserControl1();
            this.userControlTimer21 = new ITMO.CSCourse2020.Samples.WinForm.WinTimer2.UserControlTimer2();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(366, 57);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(800, 450);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(456, 153);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(800, 450);
            this.userControl12.TabIndex = 1;
            // 
            // userControlTimer21
            // 
            this.userControlTimer21.Location = new System.Drawing.Point(266, 90);
            this.userControlTimer21.Name = "userControlTimer21";
            this.userControlTimer21.Size = new System.Drawing.Size(75, 23);
            this.userControlTimer21.TabIndex = 2;
            this.userControlTimer21.Text = "userControlTimer21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlTimer21);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibraryTimer.UserControl1 userControl11;
        private ControlLibraryTimer.UserControl1 userControl12;
        private UserControlTimer2 userControlTimer21;
    }
}

