using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LastName = textBox1.Text;
            string FirstName = textBox2.Text;
            string MiddleName = textBox3.Text;
            string DateOfBirth = comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text;
            string programs = comboBox4.Text;
            string gender;

            if (radioButton1.Checked == true)
            {
                Information(FirstName, MiddleName, LastName, "Male", DateOfBirth, programs);
            }
            else if (radioButton2.Checked == true)

            {
                Information(FirstName, MiddleName, LastName, "Female", DateOfBirth, programs);
            }
            else if (comboBox1.Text.Equals("-Day-"))
            {
                Information(FirstName, MiddleName, LastName, programs);
            }
            else if (false)
            {
                Information(FirstName, LastName, programs);
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {
                comboBox1.Items.Add(day.ToString());
            }

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August",
                                "September", "October", "November", "December" };
            foreach (string i in months)
            {
                comboBox2.Items.Add(i);
            }


            for (int year = 1900; year <= 2024; year++)
            {
                comboBox3.Items.Add(year.ToString());
            }

            string[] programs = { "Bachelor of Science in Computer Science", 
                "Bachelor of Science in Information Technology", 
                "Bachelor of Science in Information Systems", 
                "Bachelor of Science in Computer Engineering" };
            foreach (string i in programs)
            {
                comboBox4.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            pictureBox1.Image = Bitmap.FromFile(dialog.FileName);

        }
        private void Information(string FirstName, string MiddleName, string LastName, string gender, string programs, string DateOfBirth)
        {

            MessageBox.Show("Student name: " + FirstName + " " + MiddleName + " " + LastName + "\nGender: " + gender + "\nDate of birth: " + DateOfBirth + "\nPrograms: " + programs);

        }
        
        private void Information(string FirstName, string MiddleName, string LastName, string programs)
        {
            MessageBox.Show("Students name: " + FirstName + " " + MiddleName + " " + LastName + "\nProgram: " + programs);
        }

        private void Information(string FirstName,string LastName, string programs)
        {
            MessageBox.Show("Students name: " + FirstName + " " + LastName + "\nProgram: " + programs);
        }
       
    }

}
