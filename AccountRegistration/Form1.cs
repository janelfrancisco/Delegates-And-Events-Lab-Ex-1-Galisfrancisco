using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect,        // x-coordinate of upper-left corner
    int nTopRect,         // y-coordinate of upper-left corner
    int nRightRect,       // x-coordinate of lower-right corner
    int nBottomRect,      // y-coordinate of lower-right corner
    int nWidthEllipse,    // height of ellipse
    int nHeightEllipse   // width of ellipse
);

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;   // Remove the border
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, this.Height, 20, 20));  // Set rounded corners
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
