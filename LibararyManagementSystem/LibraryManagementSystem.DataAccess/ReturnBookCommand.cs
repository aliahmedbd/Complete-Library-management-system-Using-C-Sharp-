using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrabyManagementSystem.Entity;
using LibrabyManagementSystem.Framework;
using System.Data.SqlClient;
using System.Data;
namespace LibraryManagementSystem.DataAccess
{
   public  class ReturnBookCommand
    {
       BookStatus GetData(SqlCommand cmd)
       {
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();
           BookStatus ob = new BookStatus();
           using (reader)
           {
               while (reader.Read())
               {
                   ob.Id = reader.GetInt32(0);
                   ob.BookTitle = reader.GetString(1);
                   ob.AuthorName = reader.GetString(2);
                   ob.BookInventory = reader.GetInt32(3);
                   ob.Catagory = reader.GetString(4);
               }
               reader.Close();
           }
           cmd.Connection.Close();
           return ob;
       }
       public BookStatus GetBookName(string name)
       {
           SqlDBdataAccess da = new SqlDBdataAccess();
           SqlCommand cmd = da.GetCommand("select * from Lib_Book_Details where  Book_title like '%" + name + "%'");
           BookStatus ob = GetData(cmd);
           return ob;
       }
       public BookStatus GetBookName(int id)
       {
           SqlDBdataAccess da = new SqlDBdataAccess();
           SqlCommand cmd = da.GetCommand("select * from Lib_Book_Details where  Lib_Book_Id = '" + id+ "'");
           BookStatus ob = GetData(cmd);
           return ob;
       }
       public bool ReturnBook1(string name, int quantity)
       {
           SqlDBdataAccess da = new SqlDBdataAccess();
           SqlCommand cmd = da.GetCommand("update [dbo].[Lib_Book_Details] set Lib_Book_In_Inventory=@quantity where Book_Title=@name");
           SqlParameter p = new SqlParameter("@quantity", SqlDbType.Int);
           p.Value = quantity; ;
           SqlParameter p1 = new SqlParameter("@name", SqlDbType.VarChar, 50);
           p1.Value = name; ;
           cmd.Parameters.Add(p);
           cmd.Parameters.Add(p1);
           cmd.Connection.Open();
           int val = cmd.ExecuteNonQuery();
           cmd.Connection.Close();
           return val > 0;
       }
       public bool ReturnBook(int id, int quantity)
       {
           SqlDBdataAccess da = new SqlDBdataAccess();
           SqlCommand cmd = da.GetCommand("update [dbo].[Lib_Book_Details] set Lib_Book_In_Inventory=@quantity where Lib_Book_Id=@id");
           SqlParameter p = new SqlParameter("@quantity", SqlDbType.Int);
           p.Value = quantity; ;
           SqlParameter p1 = new SqlParameter("@id", SqlDbType.Int);
           p1.Value = id ;
           cmd.Parameters.Add(p);
           cmd.Parameters.Add(p1);
           cmd.Connection.Open();
           int val = cmd.ExecuteNonQuery();
           cmd.Connection.Close();
           return val > 0;
       }
       public bool DeleteIssue(int id) 
       {
           SqlDBdataAccess da = new SqlDBdataAccess();
           SqlCommand cmd = da.GetCommand("delete  from [dbo].[Lib_Book_Issued_Details] where Lib_Book_Issued_Id=@id ");
           SqlParameter p = new SqlParameter("@id", SqlDbType.Int);
           p.Value = id;
           cmd.Parameters.Add(p);
           cmd.Connection.Open();
           int val = cmd.ExecuteNonQuery();
           cmd.Connection.Close();
           return val > 0;
       }
    }
}
