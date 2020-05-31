using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse2020.Samples.WinForm.Balls.Lab6Ex2
{

    public partial class MainForm : Form
    {
        Point location = new Point(50, 50);
        Point speed = new Point(10, 10);

        private void Go()
        {
            location = new Point(location.X + speed.X, location.Y + speed.Y);

            if (location.X + 30 > ClientRectangle.Width || location.X < 0)
                speed = new Point(-speed.X, speed.Y);
            if (location.Y + 20 > ClientRectangle.Height || location.Y < 0)
                speed = new Point(speed.X, -speed.Y);
        }

        private void Ball()
        {
            Graphics gr = Graphics.FromHwnd(this.Handle);

            gr.FillEllipse(Brushes.Red, location.X, location.Y, 20, 20);
            Go();
        }

        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            Ball();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }
    }
}
