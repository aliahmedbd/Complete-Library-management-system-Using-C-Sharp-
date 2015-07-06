using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrabyManagementSystem.Entity
{
    public class BookInfo
    {
        private string bookTitle;
        private string authorName;
        public int Id { set; get; }
       // public int Quantity
      //  {
        public string BookTitle 
        {
            set 
            {
                bookTitle = value;
            }
            get 
            {
                return bookTitle;
            }
        }
        public string AuthorName 
        {
            set 
            {
                authorName = value;
            }
            get 
            {
                return authorName;
            }
        }

    }
    public class BookStatus : BookInfo 
    {
        private int bookInventory;
        public string Catagory { set; get; }
        public int BookInventory
        {
            set 
            {
                bookInventory = value;
            }
            get 
            {
                return bookInventory;
            }
        }
    }

}
