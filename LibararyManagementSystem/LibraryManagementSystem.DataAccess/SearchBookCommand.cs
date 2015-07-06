using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrabyManagementSystem.Entity;
using LibrabyManagementSystem.Framework;
using System.Data.SqlClient;
namespace LibraryManagementSystem.DataAccess
{
    public class SearchBookCommand
    {
        List <BookStatus> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader=cmd.ExecuteReader();
            
            List<BookStatus> list = new List<BookStatus>();
            using (reader)
            {
                while(reader.Read())
                {
                    BookStatus ob = new BookStatus();
                    ob.Id=reader.GetInt32(0);
                    ob.BookTitle=reader.GetString(1);
                    ob.AuthorName=reader.GetString(2);
                    ob.BookInventory=reader.GetInt32(3);
                    ob.Catagory = reader.GetString(4);
                    list.Add(ob);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }
        public List<BookStatus> GetBookName(string name) 
        {
            SqlDBdataAccess da = new SqlDBdataAccess();
            SqlCommand cmd = da.GetCommand("select * from Lib_Book_Details where  Book_title like '%" + name + "%'");
            List<BookStatus> ob = GetData(cmd);
            return ob;
        }
    }
}
