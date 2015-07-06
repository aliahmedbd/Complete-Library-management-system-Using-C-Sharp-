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
    public partial class returnBookForm : Form
    {
        public returnBookForm()
        {
            InitializeComponent();
        }
        string name;
        int id;
        int returnbook;
        ReturnBookCommand sd = new ReturnBookCommand();
        IssueCommand cmd = new IssueCommand();
        BookStatus ob = new BookStatus();
        BookIssueInfo ob1 = new BookIssueInfo();
        private void returnExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnBookText_TextChanged(object sender, EventArgs e)
        {
            name = returnBookText.Text;
            ob = sd.GetBookName(name);
            nameLabel.Text = ob.AuthorName;
            idLabel.Text = ob.Id.ToString();
            catagoryLabel.Text = ob.Catagory;
            returnbook = ob.BookInventory + 1;
            id = ob.Id;
            

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(returnBookText.Text))
            {
                MessageBox.Show("Please Enter Book Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                int issueid;
                ob1 = cmd.GetBookName(ob.Id);
                issueid = ob1.IssueId;
                if (ob.Id == ob1.Id)
                {
                    sd.ReturnBook1(name, returnbook);
                    sd.DeleteIssue(issueid);
                    MessageBox.Show("Book Returned Successfullly", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Book Does Not Issue", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void returnBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
