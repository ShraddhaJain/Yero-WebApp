using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    class Phone
    {
        private System.Int32 phone_id;
        public System.Int32 Phone_id
        {
            get
            {
                return phone_id;
            }
            set
            {
                phone_id = value;
            }
        }
        private System.String phone_country;
        public System.String Phone_country
        {
            get
            {
                return phone_country;
            }
            set
            {
                phone_country = value;
            }
        }
        private System.String phone_area;
        public System.String Phone_area
        {
            get
            {
                return phone_area;
            }
            set
            {
                phone_area = value;
            }
        }
        private System.String phone_number;
        public System.String Phone_number
        {
            get
            {
                return phone_number;
            }
            set
            {
                phone_number = value;
            }
        }
        private System.String phone_type;
        public System.String Phone_type
        {
            get
            {
                return phone_type;
            }
            set
            {
                phone_type = value;
            }
        }
        private System.Int32 cont_id;
        public System.Int32 Cont_id
        {
            get
            {
                return cont_id;
            }
            set
            {
                cont_id = value;
            }
        }
    }
}
