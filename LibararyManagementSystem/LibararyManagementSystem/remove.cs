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
    public partial class remove : Form
    {
        public remove()
        {
            InitializeComponent();
        }
        string name;
        int quantity, remove1, inventory;
        RemoveBookCommand sd = new RemoveBookCommand();
        IssueCommand cmd = new IssueCommand();
        DeleteBookCommand cmd1 = new DeleteBookCommand();
        BookIssueInfo ob1 = new BookIssueInfo();
        BookStatus ob = new BookStatus();

        private void bookTextBox_TextChanged(object sender, EventArgs e)
        {

            name = bookTextBox.Text;
            ob = sd.GetBookName(name);
            authorNameLabel.Text = ob.AuthorName;
            quantityLabel.Text = ob.BookInventory.ToString();
            catagoryLabel.Text = ob.Catagory;
        }

        private void QuantityRemovedTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(bookTextBox.Text) || string.IsNullOrEmpty(QuantityRemovedTxt.Text))
                {
                    MessageBox.Show("Enter Book Name And Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    quantity = int.Parse(QuantityRemovedTxt.Text);
                    inventory = ob.BookInventory;
                    remove1 = inventory - quantity;
                    if (remove1 >= 0)
                    {
                        sd.RemoveBook1(name, remove1);
                        MessageBox.Show("Book Quantity Removed Successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Book is not available.");
                    }
                }
            }
            catch (FormatException) 
            {
                MessageBox.Show("Book Quantity Can Not Be Name", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bookTextBox.Text)) 
            {
                MessageBox.Show("Enter Book Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!string.IsNullOrEmpty(QuantityRemovedTxt.Text))
            {
                MessageBox.Show("You Can Not Delete The Quantity You Can Delete The Book Details When Book Inventory Is zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ob1 = cmd.GetBookName(ob.Id);
                if (ob1.Id == ob.Id)
                {
                    MessageBox.Show("Book is in issue....", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ob.BookInventory == 0)
                {
                    cmd1.DeleteDetails(ob.Id);
                    MessageBox.Show("Book Information Deleted Successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (ob.BookInventory > 0)
                {


                    MessageBox.Show("There are book In your library you can not delete the information", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void remove_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
