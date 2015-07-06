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
    public delegate void closeform();
    public partial class Action : Form
    {
        public Action()
        {
            InitializeComponent();
        }

        

        

        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchBookForm ob = new searchBookForm();
            ob.Show();
        }

        

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            searchBookForm ob = new searchBookForm();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //changePassswordForm ob = new changePassswordForm();
            //ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add ob = new add();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            remove ob = new remove();
            ob.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegisterForm ob = new RegisterForm();
            ob.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Action_Load(object sender, EventArgs e)
        {

        }

        private void Application_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            addCatagoryForm ob = new addCatagoryForm();
            ob.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add ob = new add();
            ob.Show();
        }

        private void removeBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            remove ob = new remove();
            ob.Show();
        }

        private void returnBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            returnBookForm ob = new returnBookForm();
            ob.Show();
        }

        private void openToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            changePassswordForm ob = new changePassswordForm();
            ob.Show();
        }

        private void openToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            RegisterForm ob = new RegisterForm();
            ob.Show();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueInfoForm ob = new issueInfoForm();
            ob.Show();
        }

        private void ActionMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            changePassswordForm ob = new changePassswordForm();
            ob.Show();
        }

        

        

        

        

       


        
    }
}
