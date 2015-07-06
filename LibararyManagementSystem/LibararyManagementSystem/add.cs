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
using LibrabyManagementSystem.Framework;
using System.Data.SqlClient;
namespace LibararyManagementSystem
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }
        private string booktitle;
        BookStatus info = new BookStatus();
        BookStatus ob = new BookStatus();
        //CatagoryInfo catagory = new CatagoryInfo();
        AddCatagoryCommand cmd = new AddCatagoryCommand();
        AddBookCommand cm = new AddBookCommand();
        RemoveBookCommand sd = new RemoveBookCommand();
        List<CatagoryInfo> list = new List<CatagoryInfo>();
        int quantity, inventory, inventory1;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void booktitletxt_TextChanged(object sender, EventArgs e)
        {

            booktitle = booktitletxt.Text;
            ob = sd.GetBookName(booktitle);
            authorNameLabel.Text = ob.AuthorName;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                    
                        string name;
                        info.BookTitle = booktitletxt.Text;
                        name = info.BookTitle;
                        info.AuthorName = AuthorNameTxt.Text;
                        info.BookInventory = int.Parse(QuantityTxt.Text);
                        inventory = ob.BookInventory;
                        inventory1 = info.BookInventory;
                        quantity = inventory + inventory1;
                        if (authorNameLabel.Text == "")
                        {
                            cm.InsertBook(info);
                            MessageBox.Show("Book Added Successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            sd.RemoveBook1(name, quantity);
                            MessageBox.Show("Book Added Successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    
                
            }
            catch (FormatException) 
            {
                MessageBox.Show("Book Quantity Can Not Be Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fill_With_Data(object sender, EventArgs e)
        {
            

            list = cmd.GetCategoryName();
            CategorycomboBox.DataSource = list;
            CategorycomboBox.DisplayMember = "CatagoryName";
            CategorycomboBox.ValueMember = "Id";

        }

        private void search_and_insert(object sender, EventArgs e)
        {
            info.Catagory = CategorycomboBox.SelectedText.ToString();

        }

        private void CategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
