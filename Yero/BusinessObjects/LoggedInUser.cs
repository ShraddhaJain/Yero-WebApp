using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yero.BusinessObjects
{
    public static class LoggedInUser
    {
        public static System.String User_ID 
        {
            set { User_ID = value; }
            get { return "shr"; } 
        }
        public static System.String User_Role 
        {
            set { User_Role = value; }
            get { return "admin"; } 
        }
    }
}
