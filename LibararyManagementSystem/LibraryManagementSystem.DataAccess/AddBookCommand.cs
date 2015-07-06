using LibrabyManagementSystem.Entity;
using LibrabyManagementSystem.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess
{
   public  class AddBookCommand
    {

        public bool InsertBook(BookStatus obj)
        {
            SqlDBdataAccess da = new SqlDBdataAccess();
            SqlCommand cmd = da.GetCommand("insert into [dbo].[Lib_Book_Details] ([Book_Title],[Lib_Book_Author_Name],[Lib_Book_In_Inventory],[Category_Name])" + "values(@Title,@Author,@Quantity,@Category)");
            SqlParameter p = new SqlParameter("@Title", SqlDbType.VarChar, 50);
            p.Value = obj.BookTitle;
            SqlParameter p1 = new SqlParameter("@Author", SqlDbType.VarChar, 50);
            p1.Value = obj.AuthorName;
            SqlParameter p2 = new SqlParameter("@Quantity", SqlDbType.Int);
            p2.Value = obj.BookInventory;
            SqlParameter p3 = new SqlParameter("@Category", SqlDbType.VarChar, 50);
            p3.Value = obj.Catagory;
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;

        }
    }
}
