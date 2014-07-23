using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Orders
    {
        private System.Int32 orderid;
        public System.Int32 Orderid
        {
            get
            {
                return orderid;
            }
            set
            {
                orderid = value;
            }
        }
        private System.Int32 customerid;
        public System.Int32 Customerid
        {
            get
            {
                return customerid;
            }
            set
            {
                customerid = value;
            }
        }
        private System.Int32 ordernumber;
        public System.Int32 Ordernumber
        {
            get
            {
                return ordernumber;
            }
            set
            {
                ordernumber = value;
            }
        }
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
        private System.DateTime orderdate;
        public System.DateTime Orderdate
        {
            get
            {
                return orderdate;
            }
            set
            {
                orderdate = value;
            }
        }
        private System.DateTime shipdate;
        public System.DateTime Shipdate
        {
            get
            {
                return shipdate;
            }
            set
            {
                shipdate = value;
            }
        }
        private System.DateTime requireddate;
        public System.DateTime Requireddate
        {
            get
            {
                return requireddate;
            }
            set
            {
                requireddate = value;
            }
        }
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
        private System.String freight;
        public System.String Freight
        {
            get
            {
                return freight;
            }
            set
            {
                freight = value;
            }
        }
        private System.String salestax;
        public System.String Salestax
        {
            get
            {
                return salestax;
            }
            set
            {
                salestax = value;
            }
        }
        private System.DateTime timestamp;
        public System.DateTime Timestamp
        {
            get
            {
                return timestamp;
            }
            set
            {
                timestamp = value;
            }
        }
        private System.String transactstatus;
        public System.String Transactstatus
        {
            get
            {
                return transactstatus;
            }
            set
            {
                transactstatus = value;
            }
        }
        private System.String errloc;
        public System.String Errloc
        {
            get
            {
                return errloc;
            }
            set
            {
                errloc = value;
            }
        }
        private System.String errmsg;
        public System.String Errmsg
        {
            get
            {
                return errmsg;
            }
            set
            {
                errmsg = value;
            }
        }
        private System.String fulfilled;
        public System.String Fulfilled
        {
            get
            {
                return fulfilled;
            }
            set
            {
                fulfilled = value;
            }
        }
        private string deleted;
        public string Deleted
        {
            get
            {
                return deleted;
            }
            set
            {
                deleted = value;
            }
        }
        private string paid;
        public string Paid
        {
            get
            {
                return paid;
            }
            set
            {
                paid = value;
            }
        }
        private System.DateTime paymentdate;
        public System.DateTime Paymentdate
        {
            get
            {
                return paymentdate;
            }
            set
            {
                paymentdate = value;
            }
        }
    }
}
