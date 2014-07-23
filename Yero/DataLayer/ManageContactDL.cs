using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.ComponentModel;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
//using Microsoft.Practices.Unity;
using MySql.Data.MySqlClient;

namespace Yero.DataLayer
{
    public class ManageContactDL
    {
        
        static ManageContactDL()
        {
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
           
        }

        public DataTable GetAllContacts()
        {

            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

            
                DbCommand dbCommand = db.GetStoredProcCommand("spGetAllContacts");

                DataSet ds = db.ExecuteDataSet(dbCommand);

                return ds.Tables[0];

            }
            catch (Exception)
            {
                
                throw;
            }
        }


        public bool CreateContact(BusinessObjects.Contact objContact)
        {

            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

             
                DbCommand dbCommand = db.GetStoredProcCommand("spInsertContact");
                db.AddInParameter(dbCommand, "CONT_F_NAME", DbType.String, objContact.Cont_f_name);
                db.AddInParameter(dbCommand, "CONT_M_NAME", DbType.String, objContact.Cont_m_name);
                db.AddInParameter(dbCommand, "CONT_L_NAME", DbType.String, objContact.Cont_l_name);
                db.AddInParameter(dbCommand, "CONT_Email_ID", DbType.String, objContact.Cont_email_id);
                db.AddInParameter(dbCommand, "CONT_ORDER_NO", DbType.Int16, objContact.Cont_order_no);
                db.AddInParameter(dbCommand, "SKYPE_ID", DbType.String, objContact.Skype_id);
                db.AddInParameter(dbCommand, "FACEBOOK_ID", DbType.String, objContact.Facebook_id);
                db.AddInParameter(dbCommand, "LINKEDIN_ID", DbType.String, objContact.Linkedin_id);
                db.AddInParameter(dbCommand, "TWITTER_ID", DbType.String, objContact.Twitter_id);
                db.AddInParameter(dbCommand, "GOOGLEPLUS_ID", DbType.String, objContact.Googleplus_id);
                db.AddInParameter(dbCommand, "LINK1_ID", DbType.String, objContact.Link1_id);
                db.AddInParameter(dbCommand, "LINK2_ID", DbType.String, objContact.Link2_id);
                db.AddInParameter(dbCommand, "LINK3_ID", DbType.String, objContact.Link3_id);
                db.AddInParameter(dbCommand, "BLOG_ID", DbType.String, objContact.Blog_id);
                db.AddInParameter(dbCommand, "WEBSITE_URL", DbType.String, objContact.Website_url);
                db.AddInParameter(dbCommand, "ADDED_BY", DbType.String,BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand); 
            
                return true;

            }
            catch (Exception)
            {
                
                throw;
            }
         }
      
        public BusinessObjects.Contact GetContactDetails(int ContactId)
        {

            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

            
                DbCommand dbCommand = db.GetStoredProcCommand("spGetContactDetails");
                db.AddInParameter(dbCommand, "ContactID", DbType.Int64, ContactId);

                DataSet ds = db.ExecuteDataSet(dbCommand);

                BusinessObjects.Contact objContact = new BusinessObjects.Contact();
                DataRow row = ds.Tables[0].Rows[0];
                objContact.Cont_id =Convert.ToInt16(row["CONT_ID"]);
                objContact.Cont_f_name = row["CONT_F_NAME"].ToString();
                objContact.Cont_m_name = row["CONT_M_NAME"].ToString();
                objContact.Cont_l_name = row["CONT_L_NAME"].ToString();
                objContact.Cont_email_id = row["CONT_Email_ID"].ToString();
                objContact.Cont_order_no = Convert.ToInt16(row["CONT_ORDER_NO"]);
                objContact.Skype_id = row["SKYPE_ID"].ToString();
                objContact.Facebook_id = row["FACEBOOK_ID"].ToString();
                objContact.Linkedin_id = row["LINKEDIN_ID"].ToString();
                objContact.Twitter_id = row["TWITTER_ID"].ToString();
                objContact.Googleplus_id = row["GOOGLEPLUS_ID"].ToString();
                objContact.Link1_id = row["LINK1_ID"].ToString();
                objContact.Link2_id = row["LINK2_ID"].ToString();
                objContact.Link3_id = row["LINK3_ID"].ToString();
                objContact.Blog_id = row["BLOG_ID"].ToString();
                objContact.Website_url = row["WEBSITE_URL"].ToString();

                return objContact;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool UpdateContact(BusinessObjects.Contact objContact)
        {

            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

            
                DbCommand dbCommand = db.GetStoredProcCommand("spUpdateContact");
                db.AddInParameter(dbCommand, "CONTACTID", DbType.Int64, objContact.Cont_id);
                db.AddInParameter(dbCommand, "CONT_F_NAME", DbType.String, objContact.Cont_f_name);
                db.AddInParameter(dbCommand, "CONT_M_NAME", DbType.String, objContact.Cont_m_name);
                db.AddInParameter(dbCommand, "CONT_L_NAME", DbType.String, objContact.Cont_l_name);
                db.AddInParameter(dbCommand, "CONT_Email_ID", DbType.String, objContact.Cont_email_id);
                db.AddInParameter(dbCommand, "CONT_ORDER_NO", DbType.Int16, objContact.Cont_order_no);
                db.AddInParameter(dbCommand, "SKYPE_ID", DbType.String, objContact.Skype_id);
                db.AddInParameter(dbCommand, "FACEBOOK_ID", DbType.String, objContact.Facebook_id);
                db.AddInParameter(dbCommand, "LINKEDIN_ID", DbType.String, objContact.Linkedin_id);
                db.AddInParameter(dbCommand, "TWITTER_ID", DbType.String, objContact.Twitter_id);
                db.AddInParameter(dbCommand, "GOOGLEPLUS_ID", DbType.String, objContact.Googleplus_id);
                db.AddInParameter(dbCommand, "LINK1_ID", DbType.String, objContact.Link1_id);
                db.AddInParameter(dbCommand, "LINK2_ID", DbType.String, objContact.Link2_id);
                db.AddInParameter(dbCommand, "LINK3_ID", DbType.String, objContact.Link3_id);
                db.AddInParameter(dbCommand, "BLOG_ID", DbType.String, objContact.Blog_id);
                db.AddInParameter(dbCommand, "WEBSITE_URL", DbType.String, objContact.Website_url);
                db.AddInParameter(dbCommand, "UPDATE_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);

                return true;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void DeleteContact(BusinessObjects.Contact objContact)
        {
            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("SPDeleteContact");
                db.AddInParameter(dbCommand, "CONTACTID", DbType.String, objContact.Cont_id);
                db.AddInParameter(dbCommand, "UPDATE_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
