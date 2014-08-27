using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yero.BusinessObjects
{

	public class orders
	{
	 	private System.Int32 order_id;
	 	public System.Int32 Order_id
	 	{
			get
			{
				return order_id;
			}
			set
			{
				order_id = value;
			}
	 	}
	 	private System.Int32 customer_id;
	 	public System.Int32 Customer_id
	 	{
			get
			{
				return customer_id;
			}
			set
			{
				customer_id = value;
			}
	 	}
	 	private System.Int32 payment_id;
	 	public System.Int32 Payment_id
	 	{
			get
			{
				return payment_id;
			}
			set
			{
				payment_id = value;
			}
	 	}
	 	private System.Int32 order_number;
	 	public System.Int32 Order_number
	 	{
			get
			{
				return order_number;
			}
			set
			{
				order_number = value;
			}
	 	}
	 	private System.Int32 payment_type;
	 	public System.Int32 Payment_type
	 	{
			get
			{
				return payment_type;
			}
			set
			{
				payment_type = value;
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
	 	private System.DateTime order_date;
	 	public System.DateTime Order_date
	 	{
			get
			{
				return order_date;
			}
			set
			{
				order_date = value;
			}
	 	}
	 	private System.DateTime order_scheduled_date;
	 	public System.DateTime Order_scheduled_date
	 	{
			get
			{
				return order_scheduled_date;
			}
			set
			{
				order_scheduled_date = value;
			}
	 	}
	 	private System.DateTime order_modified_date;
	 	public System.DateTime Order_modified_date
	 	{
			get
			{
				return order_modified_date;
			}
			set
			{
				order_modified_date = value;
			}
	 	}
	 	private System.DateTime order_ship_date;
	 	public System.DateTime Order_ship_date
	 	{
			get
			{
				return order_ship_date;
			}
			set
			{
				order_ship_date = value;
			}
	 	}
        private System.String order_status;
        public System.String ORDER_Status
	 	{
			get
			{
				return order_status;
			}
			set
			{
				order_status = value;
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
	 	private System.String active;
	 	public System.String Active
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
	 	private System.String added_by;
	 	public System.String Added_by
	 	{
			get
			{
				return added_by;
			}
			set
			{
				added_by = value;
			}
	 	}
	 	private System.DateTime added_date;
	 	public System.DateTime Added_date
	 	{
			get
			{
				return added_date;
			}
			set
			{
				added_date = value;
			}
	 	}
	 	private System.String update_by;
	 	public System.String Update_by
	 	{
			get
			{
				return update_by;
			}
			set
			{
				update_by = value;
			}
	 	}
	 	private System.DateTime update_date;
	 	public System.DateTime Update_date
	 	{
			get
			{
				return update_date;
			}
			set
			{
				update_date = value;
			}
	 	}
	}
}

 

