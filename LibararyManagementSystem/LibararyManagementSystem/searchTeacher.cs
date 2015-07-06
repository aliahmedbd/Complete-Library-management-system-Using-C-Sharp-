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
using LibraryManagementSystem.DataAccess;
namespace LibararyManagementSystem
{
    public partial class searchTeacher : Form
    {
        public searchTeacher()
        {
            InitializeComponent();
            searchDataGridView.Visible = false;
        }
        SearchBookCommand sd = new SearchBookCommand();
        string bookname;

        private void searchBookTextBox_TextChanged(object sender, EventArgs e)
        {
            bookname = searchBookTextBox.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBookTextBox.Text))
            {
                MessageBox.Show("Enter Book Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                searchDataGridView.Visible = true;
                searchDataGridView.DataSource = sd.GetBookName(bookname);
            }
        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            IssueForm ob = new IssueForm();
            ob.Show();
        }

        private void application_Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
