using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrabyManagementSystem.Entity
{
   public class BookIssueInfo
    {
        private string issueTo;
       
        public int Id { set; get; }
        public int IssueId { set; get; }
        public string Name { set; get; }
        public string Date { set; get; }
       public string BookIssueTo
        {
            set 
            {
                issueTo = value;
            }
            get 
            {
                return issueTo;
            }
        }
    }
}
