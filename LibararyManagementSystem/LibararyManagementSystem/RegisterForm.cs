using LibrabyManagementSystem.Entity;
using LibraryManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibararyManagementSystem
{
    public partial class RegisterForm : Form
    {
        string username;
        UserInfo info = new UserInfo();
        RegisterCommand cm = new RegisterCommand();
        LogInCommand sd = new LogInCommand();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterConfirmPasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void R_Registerbutton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(RegisterConfirmPasswordTextbox.Text) || string.IsNullOrEmpty(RegisterUserNameTextbox.Text) || string.IsNullOrEmpty(RegisterPasswordTextbox.Text) )||( !student_Radio.Checked && !teacherRadio.Checked && !AdminRadio.Checked)) 
            {
                MessageBox.Show("Please Provide All The Information For Registration","Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
            info = sd.GetUserName(username);
            //int student,teacher,admin=0;
            if (info.UserName == username)
            {
                MessageBox.Show("UserName Already Exists");

            }
            else
            {
                info.UserName = RegisterUserNameTextbox.Text;
                string password, confirmpassword;
                password = RegisterPasswordTextbox.Text;
                confirmpassword = RegisterConfirmPasswordTextbox.Text;
                if (password == confirmpassword)
                {

                    if (AdminRadio.Checked)
                    {
                        int admin;
                        admin = 1;
                        info.Status = admin;
                    }
                    else
                    {
                        if (teacherRadio.Checked)
                        {
                            int teacher;
                            teacher = 2;
                            info.Status = teacher;
                        }
                        else
                        {
                            if (student_Radio.Checked)
                            {
                                int student;
                                student = 3;
                                info.Status = student;
                            }
                            else
                            {
                                MessageBox.Show("set user status...");
                            }
                        }
                    }
                    info.UserPassword = RegisterPasswordTextbox.Text;
                    cm.Insert(info);
                    MessageBox.Show("Registration Complete", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    textLabel.Text = "Password Does Not Match";
                }
            }
            }
            

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterUserNameTextbox_TextChanged(object sender, EventArgs e)
        {
            username = RegisterUserNameTextbox.Text;
        }

        private void student_Radio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void teacherRadio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void AdminRadio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void R_Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
