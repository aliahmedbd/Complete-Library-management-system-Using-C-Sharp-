using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrabyManagementSystem.Entity
{
   public class UserInfo
    {
       private int UserStatus;
       private string userName;
       private string userPassword;
       public int Id {set;get; }
       public int Status 
       {
           set
           {
               UserStatus = value;
           }
           get
           {
               return UserStatus;
           }
       }
       public string UserName 
       {
           set 
           {
               userName = value;
           }
           get 
           {
               return userName;
           }
       }
       public string UserPassword 
       {
           set
           {
               userPassword = value;
           }
           get 
           {
               return userPassword;
           }
       }
    }
   public class BookIssueDetails:UserInfo
   {
       private int bookIssueNumber;
       private string bookIssueId;
       public int BookIssueNumber 
       { 
           set
           {
               bookIssueNumber = value;
           }
           get 
           {
               return bookIssueNumber;
           } 
       }
       public string BookIssueId 
       { 
           set
           {
               bookIssueId = value;
           }
           get 
           {
               return bookIssueId;
           } 
       }
   }
}
