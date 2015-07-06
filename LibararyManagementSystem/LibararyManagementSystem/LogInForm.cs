using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrabyManagementSystem.Entity;
using LibrabyManagementSystem.Framework;
using LibraryManagementSystem.DataAccess;
namespace LibararyManagementSystem
{

    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        string username, password;
        LogInCommand sd = new LogInCommand();
        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            password = passwordTextbox.Text;
        }

        private void userTextbox_TextChanged(object sender, EventArgs e)
        {
            username = userTextbox.Text;
        }

        
        
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTextbox.Text) || string.IsNullOrEmpty(userTextbox.Text))
            {
                MessageBox.Show("Enter Username Or Password", "Invalid operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                UserInfo ob = new UserInfo();
                ob = sd.GetUserName(username);
                if (ob.UserName == username && ob.UserPassword == password && ob.Status == 1)
                {
                    Action frm = new Action();
                    frm.Show();
                    this.Hide();

                }
                else if (ob.UserName == username && ob.UserPassword == password && ob.Status == 2)
                {
                    searchTeacher frm1 = new searchTeacher();
                    frm1.Show();
                    this.Hide();
                }
                else if (ob.UserName == username && ob.UserPassword == password && ob.Status == 3)
                {
                    searchStudent frm2 = new searchStudent();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Name Or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
        

    }
}

