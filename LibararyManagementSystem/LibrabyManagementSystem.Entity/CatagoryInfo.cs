using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrabyManagementSystem.Entity
{
    public class CatagoryInfo
    {
        private string name;
        public int Id { set; get; }
        public string CatagoryName 
        {
            set 
            {
                name = value;
            }
            get 
            {
                return name;
            }
        }
    }
}
