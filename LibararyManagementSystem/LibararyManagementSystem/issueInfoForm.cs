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
    public partial class issueInfoForm : Form
    {
        public issueInfoForm()
        {
            InitializeComponent();
            searchDataGridView.Visible = false;
        }
        int id;
        IssueInfoCommand cmd = new IssueInfoCommand();
        private void searchBookTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(searchBookTextBox.Text))
                {
                    MessageBox.Show("Enter Book Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    id = int.Parse(searchBookTextBox.Text);
                    searchDataGridView.Visible = true;
                    searchDataGridView.DataSource = cmd.GetIssueInfo(id);
                }
            }
            catch (FormatException) 
            {
                MessageBox.Show("Book Id Can Not Be Name", "Invalid Operation", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
        }
    }
}
