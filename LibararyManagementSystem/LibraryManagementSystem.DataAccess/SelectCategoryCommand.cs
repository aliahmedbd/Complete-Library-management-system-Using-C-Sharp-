﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrabyManagementSystem.Entity;
using LibrabyManagementSystem.Framework;
using System.Data.SqlClient;
namespace LibraryManagementSystem.DataAccess
{
    public class SelectCategoryCommand
    {
        CatagoryInfo GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            CatagoryInfo ob = new CatagoryInfo();
            using (reader)
            {
                while (reader.Read())
                {
                    ob.Id = reader.GetInt32(0);
                    ob.CatagoryName= reader.GetString(1);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return ob;
        }
        public CatagoryInfo GetCategoryName(String name)
        {
            SqlDBdataAccess db = new SqlDBdataAccess();
            SqlCommand cmd = db.GetCommand("select * from Lib_Book_Category where Category_Name like '%" + name + "%'");
            CatagoryInfo ob = GetData(cmd);
            return ob;
        }
    }
}
