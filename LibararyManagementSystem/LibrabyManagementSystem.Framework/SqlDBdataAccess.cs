using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrabyManagementSystem.Framework
{
    public class SqlDBdataAccess
    {
        const string ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\robot\Desktop\LibararyManagementSystem\LibararyManagementSystem\LIbrary.mdf;Integrated Security=True";
        public SqlCommand GetCommand(string queary) 
        {
            var connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(queary);
            cmd.Connection = connection;
            return cmd;
        }
    }
}
