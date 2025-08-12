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


        public class StudentInfoClass

        {


            //Delegate
            public delegate string DelegateText(string txt);
            public delegate long DelegateNumber(long number);


            //Static variables
            public static string FirstName = "";
            public static string LastName = "";
            public static string MiddleName = "";
            public static string Address = "";
            public static string Program = "";
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;



            // Static return-type methods

            public static string GetFirstName(string firstName) => firstName;
            public static string GetLastName(string lastName) => lastName;
            public static string GetMiddleName(string middleName) => middleName;
            public static string GetAddress(string address) => address;
            public static string GetProgram(string program) => program;
            public static long GetAge(long age) => age;
            public static long GetContactNo(long contactNo) => contactNo;
            public static long GetStudentNo(long studentNo) => studentNo;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

            


            

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

        private void btn_Next_Click_1(object sender, EventArgs e)
        {

            StudentInfoClass.StudentNo = long.Parse(tBx_StudNum.Text);
            StudentInfoClass.Program = tBx_Program.Text;
            StudentInfoClass.LastName = tBx_LastName.Text;
            StudentInfoClass.FirstName = tBx_FirstName.Text;
            StudentInfoClass.MiddleName = tBx_MidName.Text;
            StudentInfoClass.Age = long.Parse(tBx_Age.Text);
            StudentInfoClass.ContactNo = long.Parse(tBx_ContactNum.Text);
            StudentInfoClass.Address = rTBx_Address.Text;

            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }
    }
}
