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
 public   class IssueInfoCommand
    {
        List<BookIssueInfo> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<BookIssueInfo> list = new List<BookIssueInfo>();
            using (reader)
            {
                while (reader.Read())
                {
                    BookIssueInfo ob = new BookIssueInfo();

                    ob.IssueId = reader.GetInt32(0);
                    ob.Id = reader.GetInt32(1);
                    ob.Date = Convert.ToString(reader.GetDateTime(2));
                    ob.Name = reader.GetString(3);
                    list.Add(ob);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }
        public List<BookIssueInfo> GetIssueInfo(int id)
        {
            SqlDBdataAccess da = new SqlDBdataAccess();
            SqlCommand cmd = da.GetCommand("select * from Lib_Book_Issued_Details where  Lib_Book_Id = '" + id + "'");
            List<BookIssueInfo> ob = GetData(cmd);
            return ob;
        }
    }
}
