using LibrabyManagementSystem.Framework;
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
    public partial class addCatagoryForm : Form
    {
        public addCatagoryForm()
        {
            InitializeComponent();
        }
        CatagoryInfo info = new CatagoryInfo();
        CatagoryInfo info1 = new CatagoryInfo();
        AddCatagoryCommand cm = new AddCatagoryCommand();
        SelectCategoryCommand cmd = new SelectCategoryCommand();
        string compare;
        string catagory;
        private void addCatagoryTextbox_TextChanged(object sender, EventArgs e)
        {
            catagory= addCatagoryTextbox.Text;
        }

        private void catagoryAddbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addCatagoryTextbox.Text))
            {
                MessageBox.Show("Enter Catagory Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                info1 = cmd.GetCategoryName(catagory);
                compare = info1.CatagoryName;
                if (compare == catagory)
                {
                    MessageBox.Show("Catagory Already Exists", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    info.CatagoryName = catagory;
                    cm.InsertCategory(info);
                    MessageBox.Show("Catagory Added Successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void addCatagoryForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
