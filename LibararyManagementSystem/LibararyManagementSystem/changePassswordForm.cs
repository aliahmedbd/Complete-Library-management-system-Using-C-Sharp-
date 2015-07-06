using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrabyManagementSystem.Framework;
using LibraryManagementSystem.DataAccess;
using LibrabyManagementSystem.Entity;
namespace LibararyManagementSystem
{
    public partial class changePassswordForm : Form
    {
        public changePassswordForm()
        {
            InitializeComponent();
        }
        string username, oldpassword, newpassword, confirmpassword;
        ChangePasswordCommand sd = new ChangePasswordCommand();
        private void userNameText_TextChanged(object sender, EventArgs e)
        {
            username = userNameText.Text;
        }

        private void changePasswordtextbox_TextChanged(object sender, EventArgs e)
        {
            oldpassword = changePasswordtextbox.Text;
        }

        private void newPasswordtextbox_TextChanged(object sender, EventArgs e)
        {
            newpassword = newPasswordtextbox.Text;
        }

        private void confirmPasswordtextbox_TextChanged(object sender, EventArgs e)
        {
            confirmpassword = confirmPasswordtextbox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameText.Text) || string.IsNullOrEmpty(changePasswordtextbox.Text) || string.IsNullOrEmpty(confirmPasswordtextbox.Text) || string.IsNullOrEmpty(newPasswordtextbox.Text))
            {
                MessageBox.Show("Provide All The Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                UserInfo ob = new UserInfo();
                ob = sd.GetUserName(username);
                if (ob.UserName == username && ob.UserPassword == oldpassword && newpassword == newPasswordtextbox.Text && confirmpassword == confirmPasswordtextbox.Text)
                {
                    sd.ChangePassword(username, newpassword);
                    MessageBox.Show("Password Change Successfully");
                }
                else
                {
                    MessageBox.Show(" Username Or Password Does Not Match","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
