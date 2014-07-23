using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
   public class Category
    {
        private System.Int32 categoryid;
        public System.Int32 Categoryid
        {
            get
            {
                return categoryid;
            }
            set
            {
                categoryid = value;
            }
        }
        private System.String categoryname;
        public System.String Categoryname
        {
            get
            {
                return categoryname;
            }
            set
            {
                categoryname = value;
            }
        }
        private System.String description;
        public System.String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        private System.String picture;
        public System.String Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
            }
        }
        private string active;
        public string Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }
    }
}
