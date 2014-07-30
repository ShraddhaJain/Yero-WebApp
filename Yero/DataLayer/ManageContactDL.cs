﻿using System;
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
using MySql.Data.MySqlClient;

namespace Yero.DataLayer
{
    public class ManageContactDL
    {

        /// <summary>
        /// Initializes the <see cref="ManageContactDL"/> class.
        /// </summary>
        static ManageContactDL()
        {
           // DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
           
        }

        /// <summary>
        /// Gets all contacts.
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllContacts()
        {

            try
            {

                Audit.CustomLog("Start: ManageContactDL.aspx - GetAllContacts", null);
              

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();
            
                DbCommand dbCommand = db.GetStoredProcCommand("spGetAllContacts");

                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog("End: ManageContactDL.aspx - GetAllContacts", null);

                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactDL.aspx - GetAllContacts", null, false);
                throw;
            }
        }


        /// <summary>
        /// Creates the contact.
        /// </summary>
        /// <param name="objContact">The object contact.</param>
        /// <returns></returns>
        public bool CreateContact(BusinessObjects.Contact objContact)
        {

            try
            {
                Audit.CustomLog("Start: ManageContactDL.aspx - CreateContact", objContact);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

             
                DbCommand dbCommand = db.GetStoredProcCommand("spInsertContact");
                db.AddInParameter(dbCommand, "CONT_F_NAME", DbType.String, objContact.Cont_f_name);
                db.AddInParameter(dbCommand, "CONT_M_NAME", DbType.String, objContact.Cont_m_name);
                db.AddInParameter(dbCommand, "CONT_L_NAME", DbType.String, objContact.Cont_l_name);
                db.AddInParameter(dbCommand, "CONT_Email_ID", DbType.String, objContact.Cont_email_id);
                db.AddInParameter(dbCommand, "USER_NAME", DbType.String, objContact.UserName);
                db.AddInParameter(dbCommand, "PASSWORD", DbType.String, objContact.Password);
                db.AddInParameter(dbCommand, "SECURITY_QUE", DbType.String, objContact.SecurityQuestion);
                db.AddInParameter(dbCommand, "SECURITY_ANS", DbType.String, objContact.SecurityAnswer);
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
            
                Audit.CustomLog("End: ManageContactDL.aspx - CreateContact", objContact);
                return true;

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactDL.aspx - CreateContact", objContact, false);
                throw;
            }
         }

        /// <summary>
        /// Gets the contact details.
        /// </summary>
        /// <param name="ContactId">The contact identifier.</param>
        /// <returns></returns>
        public BusinessObjects.Contact GetContactDetails(int ContactId)
        {

            try
            {
                Audit.CustomLog("Start: ManageContactDL.aspx - GetContactDetails", ContactId);
               
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spGetContactDetails");
                db.AddInParameter(dbCommand, "ContactID", DbType.Int64, ContactId);

                DataSet ds = db.ExecuteDataSet(dbCommand);
                DataTable dt = ds.Tables[0];
                BusinessObjects.Contact objContact = new BusinessObjects.Contact();
                DataRow row = ds.Tables[0].Rows[0];
                objContact.Cont_id =Convert.ToInt16(row["CONT_ID"]);
                objContact.Cont_f_name = row["CONT_F_NAME"].ToString();
                objContact.Cont_m_name = row["CONT_M_NAME"].ToString();
                objContact.Cont_l_name = row["CONT_L_NAME"].ToString();
                objContact.Cont_email_id = row["CONT_Email_ID"].ToString();
                objContact.UserName = row["USER_NAME"].ToString();
                objContact.Password = row["PASSWORD"].ToString();
                objContact.SecurityQuestion = row["SECURITY_QUE"].ToString();
                objContact.SecurityAnswer = row["SECURITY_ANS"].ToString();
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

                Audit.CustomLog("End: ManageContactDL.aspx - GetContactDetails", ContactId);
                return objContact;
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactDL.aspx - GetContactDetails", ContactId, false);
                throw;
            }
        }

        /// <summary>
        /// Updates the contact.
        /// </summary>
        /// <param name="objContact">The object contact.</param>
        /// <returns></returns>
        public bool UpdateContact(BusinessObjects.Contact objContact)
        {
            try
            {
                Audit.CustomLog("Start: ManageContactDL.aspx - UpdateContact", objContact);

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
                db.AddInParameter(dbCommand, "USER_NAME", DbType.String, objContact.UserName);
                db.AddInParameter(dbCommand, "PASSWORD", DbType.String, objContact.Password);
                db.AddInParameter(dbCommand, "SECURITY_QUE", DbType.String, objContact.SecurityQuestion);
                db.AddInParameter(dbCommand, "SECURITY_ANS", DbType.String, objContact.SecurityAnswer);
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

                Audit.CustomLog("End: ManageContactDL.aspx - UpdateContact", objContact);
                return true;

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactDL.aspx - UpdateContact", objContact, false);
                throw;
            }
        }


        /// <summary>
        /// Deletes the contact.
        /// </summary>
        /// <param name="objContact">The object contact.</param>
        public void DeleteContact(BusinessObjects.Contact objContact)
        {
            try
            {
                Audit.CustomLog("Start: ManageContactDL.aspx - DeleteContact", objContact);
               
               DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("SPDeleteContact");
                db.AddInParameter(dbCommand, "CONTACTID", DbType.String, objContact.Cont_id);
                db.AddInParameter(dbCommand, "UPDATE_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog("End: ManageContactDL.aspx - DeleteContact", objContact);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactDL.aspx - DeleteContact", objContact, false);
                throw;
            }
        }
    }
}
