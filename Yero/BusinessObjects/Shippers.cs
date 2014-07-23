using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Shippers
    {
        private System.Int32 shipperid;
        public System.Int32 Shipperid
        {
            get
            {
                return shipperid;
            }
            set
            {
                shipperid = value;
            }
        }
        private System.String companyname;
        public System.String Companyname
        {
            get
            {
                return companyname;
            }
            set
            {
                companyname = value;
            }
        }
        private System.String phone;
        public System.String Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
    }
}
