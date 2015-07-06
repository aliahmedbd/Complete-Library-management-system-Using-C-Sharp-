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
    public class DeleteBookCommand
    {
        public bool DeleteDetails(int id)
        {
            SqlDBdataAccess da = new SqlDBdataAccess();
            SqlCommand cmd = da.GetCommand("delete  from [dbo].[Lib_Book_Details] where Lib_Book_Id=@id ");
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
