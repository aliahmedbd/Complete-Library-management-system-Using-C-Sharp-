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
   public class AddCatagoryCommand
    {
        public bool InsertCategory(CatagoryInfo obj)
        {
            SqlDBdataAccess da = new SqlDBdataAccess();
            SqlCommand cmd = da.GetCommand("insert into [dbo].[Lib_Book_Category] ([Category_Name])" + "values(@CategoryName)");
            SqlParameter p = new SqlParameter("@CategoryName", SqlDbType.VarChar, 50);
            p.Value = obj.CatagoryName; 
            cmd.Parameters.Add(p);
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }

        List<CatagoryInfo> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            List<CatagoryInfo> list = new List<CatagoryInfo>();
            using (reader)
            {
                while (reader.Read())
                {
                    CatagoryInfo ob = new CatagoryInfo();
                    ob.Id = reader.GetInt32(0);
                    ob.CatagoryName = reader.GetString(1);
                    list.Add(ob);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }
        public List<CatagoryInfo> GetCategoryName()
        {
            SqlDBdataAccess da = new SqlDBdataAccess();
            SqlCommand cmd = da.GetCommand("select * from Lib_Book_Category");
            List<CatagoryInfo> ob = GetData(cmd);
            return ob;
        }
    }
}
