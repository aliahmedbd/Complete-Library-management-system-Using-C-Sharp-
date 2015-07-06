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
   public class IssueCommand
    {
       public bool InsertIssue(BookIssueInfo obj) 
       {
           SqlDBdataAccess da = new SqlDBdataAccess();
           SqlCommand cmd = da.GetCommand("insert into [dbo].[Lib_Book_Issued_Details] ([Lib_Book_Id],[Lib_Book_Issued_To],[Lib-Book_Issued_On])" + "values(@id,@IssueDate,@Name)");
           SqlParameter p = new SqlParameter("@id", SqlDbType.Int);
           p.Value = obj.Id;
           SqlParameter p1 = new SqlParameter("@IssueDate", SqlDbType.DateTime);
           p1.Value = DateTime.Now;
           SqlParameter p2 = new SqlParameter("@Name", SqlDbType.VarChar,50);
           p2.Value = obj.Name;
           cmd.Parameters.Add(p);
           cmd.Parameters.Add(p1);
           cmd.Parameters.Add(p2);
           cmd.Connection.Open();
           int val = cmd.ExecuteNonQuery();
           cmd.Connection.Close();
           return val > 0;    
       }
       BookIssueInfo GetData(SqlCommand cmd)
       {
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();
           BookIssueInfo ob = new BookIssueInfo();
           using (reader)
           {    
               while (reader.Read())
               {
                   ob.IssueId = reader.GetInt32(0);
                   ob.Id = reader.GetInt32(1);
                     
               }
               reader.Close();
           }
           cmd.Connection.Close();
           return ob;
       }
       public BookIssueInfo GetBookName(int id)
       {
           SqlDBdataAccess da = new SqlDBdataAccess();
           SqlCommand cmd = da.GetCommand("select * from Lib_Book_Issued_Details where  Lib_Book_Id = '" + id + "'");
           BookIssueInfo ob = GetData(cmd);
           return ob;
       }
    }
}
