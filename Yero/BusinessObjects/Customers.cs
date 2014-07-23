using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Customers
    {
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
	 	private System.String firstname;
	 	public System.String Firstname
	 	{
			get
			{
				return firstname;
			}
			set
			{
				firstname = value;
			}
	 	}
	 	private System.String lastname;
	 	public System.String Lastname
	 	{
			get
			{
				return lastname;
			}
			set
			{
				lastname = value;
			}
	 	}
	 	private System.String customerclass;
	 	public System.String CustomerClass
	 	{
			get
			{
				return customerclass;
			}
			set
			{
                customerclass = value;
			}
	 	}
	 	private System.String room;
	 	public System.String Room
	 	{
			get
			{
				return room;
			}
			set
			{
				room = value;
			}
	 	}
	 	private System.String building;
	 	public System.String Building
	 	{
			get
			{
				return building;
			}
			set
			{
				building = value;
			}
	 	}
	 	private System.String address1;
	 	public System.String Address1
	 	{
			get
			{
				return address1;
			}
			set
			{
				address1 = value;
			}
	 	}
	 	private System.String address2;
	 	public System.String Address2
	 	{
			get
			{
				return address2;
			}
			set
			{
				address2 = value;
			}
	 	}
	 	private System.String city;
	 	public System.String City
	 	{
			get
			{
				return city;
			}
			set
			{
				city = value;
			}
	 	}
	 	private System.String state;
	 	public System.String State
	 	{
			get
			{
				return state;
			}
			set
			{
				state = value;
			}
	 	}
	 	private System.String postalcode;
	 	public System.String Postalcode
	 	{
			get
			{
				return postalcode;
			}
			set
			{
				postalcode = value;
			}
	 	}
	 	private System.String country;
	 	public System.String Country
	 	{
			get
			{
				return country;
			}
			set
			{
				country = value;
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
	 	private System.String email;
	 	public System.String Email
	 	{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
	 	}
	 	private System.String voicemail;
	 	public System.String Voicemail
	 	{
			get
			{
				return voicemail;
			}
			set
			{
				voicemail = value;
			}
	 	}
	 	private System.String password;
	 	public System.String Password
	 	{
			get
			{
				return password;
			}
			set
			{
				password = value;
			}
	 	}
	 	private System.String creditcard;
	 	public System.String Creditcard
	 	{
			get
			{
				return creditcard;
			}
			set
			{
				creditcard = value;
			}
	 	}
	 	private System.Int32 creditcardtypeid;
	 	public System.Int32 Creditcardtypeid
	 	{
			get
			{
				return creditcardtypeid;
			}
			set
			{
				creditcardtypeid = value;
			}
	 	}
	 	private System.Int32 cardexpmo;
	 	public System.Int32 Cardexpmo
	 	{
			get
			{
				return cardexpmo;
			}
			set
			{
				cardexpmo = value;
			}
	 	}
	 	private System.Int32 cardexpyr;
	 	public System.Int32 Cardexpyr
	 	{
			get
			{
				return cardexpyr;
			}
			set
			{
				cardexpyr = value;
			}
	 	}
	 	private System.String billingaddress;
	 	public System.String Billingaddress
	 	{
			get
			{
				return billingaddress;
			}
			set
			{
				billingaddress = value;
			}
	 	}
	 	private System.String billingcity;
	 	public System.String Billingcity
	 	{
			get
			{
				return billingcity;
			}
			set
			{
				billingcity = value;
			}
	 	}
	 	private System.String billingregion;
	 	public System.String Billingregion
	 	{
			get
			{
				return billingregion;
			}
			set
			{
				billingregion = value;
			}
	 	}
	 	private System.String billingpostalcode;
	 	public System.String Billingpostalcode
	 	{
			get
			{
				return billingpostalcode;
			}
			set
			{
				billingpostalcode = value;
			}
	 	}
	 	private System.String billingcountry;
	 	public System.String Billingcountry
	 	{
			get
			{
				return billingcountry;
			}
			set
			{
				billingcountry = value;
			}
	 	}
	 	private System.String shipaddress;
	 	public System.String Shipaddress
	 	{
			get
			{
				return shipaddress;
			}
			set
			{
				shipaddress = value;
			}
	 	}
	 	private System.String shipcity;
	 	public System.String Shipcity
	 	{
			get
			{
				return shipcity;
			}
			set
			{
				shipcity = value;
			}
	 	}
	 	private System.String shipregion;
	 	public System.String Shipregion
	 	{
			get
			{
				return shipregion;
			}
			set
			{
				shipregion = value;
			}
	 	}
	 	private System.String shippostalcode;
	 	public System.String Shippostalcode
	 	{
			get
			{
				return shippostalcode;
			}
			set
			{
				shippostalcode = value;
			}
	 	}
	 	private System.String shipcountry;
	 	public System.String Shipcountry
	 	{
			get
			{
				return shipcountry;
			}
			set
			{
				shipcountry = value;
			}
	 	}
	 	private System.DateTime dateentered;
	 	public System.DateTime Dateentered
	 	{
			get
			{
				return dateentered;
			}
			set
			{
				dateentered = value;
			}
	 	}
    }
}
