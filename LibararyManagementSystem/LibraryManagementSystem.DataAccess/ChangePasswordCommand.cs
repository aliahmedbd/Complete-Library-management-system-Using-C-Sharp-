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
    public class ChangePasswordCommand
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
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return ob;
        }
        public UserInfo GetUserName(String name)
        {
            SqlDBdataAccess db = new SqlDBdataAccess();
            SqlCommand cmd = db.GetCommand("select * from Lib_Users where User_Name like '%" + name + "%'");
            UserInfo ob = GetData(cmd);
            return ob;
        }
        public bool ChangePassword(string name, string password)
        {
            SqlDBdataAccess da = new SqlDBdataAccess();
            SqlCommand cmd = da.GetCommand("update [dbo].[Lib_Users] set User_Password=@password where User_Name=@name");
            SqlParameter p = new SqlParameter("@password", SqlDbType.VarChar,50);
            p.Value = password; 
            SqlParameter p1 = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p1.Value = name; ;
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }

    }
}
