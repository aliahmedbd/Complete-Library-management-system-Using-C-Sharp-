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
    public class RegisterCommand
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
        public bool Insert(UserInfo obj)
        {
            SqlDBdataAccess da = new SqlDBdataAccess();
            SqlCommand cmd = da.GetCommand("insert into [dbo].[Lib_Users] ([User_Name],[User_Password],[Lib_Book_Issued_Id])" + "values(@Name,@Password,@Status)");
            SqlParameter p = new SqlParameter("@Name", SqlDbType.VarChar,50);
            p.Value = obj.UserName;
            SqlParameter p1 = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            p1.Value = obj.UserPassword;
            SqlParameter p2 = new SqlParameter("@Status", SqlDbType.Int);
            p2.Value = obj.Status;
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;

        }
    }
}
