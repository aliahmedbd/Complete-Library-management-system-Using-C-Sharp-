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
    public partial class IssueForm : Form
    {
        public IssueForm()
        {
            InitializeComponent();
        }
        BookIssueInfo info = new BookIssueInfo();
        IssueCommand cm = new IssueCommand();
        BookStatus ob = new BookStatus();
        ReturnBookCommand sd = new ReturnBookCommand();
        int quantity;
        private void isssueButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(bookIdTexBox.Text) || string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Enter Book Id Or Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    info.Id = int.Parse(bookIdTexBox.Text);
                    info.Name = nameTextBox.Text;
                    // info.BookIssueTo = issueDateTextBox.Text;
                    cm.InsertIssue(info);
                    ob = sd.GetBookName(info.Id);
                    quantity = ob.BookInventory - 1;
                    if (quantity > 0)
                    {
                        sd.ReturnBook(info.Id, quantity);
                        MessageBox.Show("Issued Successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Book Is not Available.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (FormatException) 
            {
                MessageBox.Show("Book Id Can Not Be Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void IssueForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
