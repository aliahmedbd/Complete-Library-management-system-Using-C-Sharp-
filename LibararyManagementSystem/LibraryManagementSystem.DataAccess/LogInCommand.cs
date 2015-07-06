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
   public  class LogInCommand
    {

       UserInfo GetData(SqlCommand cmd) 
       {
           cmd.Connection.Open();
           SqlDataReader reader = cmd.ExecuteReader();
           UserInfo ob = new UserInfo();
           using (reader) 
           {
               while (reader.Read()) 
               {
                   ob.Id = reader.GetInt32(0);
                   ob.UserName = reader.GetString(1);
                   ob.UserPassword = reader.GetString(2);
                   ob.Status = reader.GetInt32(3);
               }
               reader.Close();
           }
           cmd.Connection.Close();
           return ob;
       }
       public UserInfo GetUserName(String name) 
       {
           SqlDBdataAccess db= new SqlDBdataAccess();
           SqlCommand cmd = db.GetCommand("select * from Lib_Users where User_Name like '%" + name + "%'");
           UserInfo ob = GetData(cmd);
           return ob;
       }
    }
}
