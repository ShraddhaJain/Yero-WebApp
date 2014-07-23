using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Payment
    {
        private System.Int32 paymentid;
        public System.Int32 Paymentid
        {
            get
            {
                return paymentid;
            }
            set
            {
                paymentid = value;
            }
        }
        private System.String paymenttype;
        public System.String Paymenttype
        {
            get
            {
                return paymenttype;
            }
            set
            {
                paymenttype = value;
            }
        }
        private System.String allowed;
        public System.String Allowed
        {
            get
            {
                return allowed;
            }
            set
            {
                allowed = value;
            }
        }
    }
}
