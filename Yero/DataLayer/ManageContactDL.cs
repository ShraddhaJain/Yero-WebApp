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

                Audit.CustomLog(" Start: ManageContactDL.aspx - GetAllContacts", null);
              

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();
            
                DbCommand dbCommand = db.GetStoredProcCommand("spGetAllContacts");

                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog(" End: ManageContactDL.aspx - GetAllContacts", null);

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
           
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("itivo");
            DbConnection conn = db.CreateConnection();
            conn.Open();
            try
            {
                Audit.CustomLog(" Start: ManageContactDL.aspx - CreateContact - ", objContact);

                DbCommand dbCommand = db.GetStoredProcCommand("spInsertContact");
                db.AddInParameter(dbCommand, "CONT_Email_ID", DbType.String, objContact.Cont_email_id);
                db.AddInParameter(dbCommand, "USER_NAME", DbType.String, objContact.UserName);
                db.AddInParameter(dbCommand, "PASSWORD", DbType.String, objContact.Password);
                db.AddInParameter(dbCommand, "SECURITY_QUESTION", DbType.String, objContact.SecurityQuestion);
                db.AddInParameter(dbCommand, "SECURITY_ANSWER", DbType.String, objContact.SecurityAnswer);
                db.AddInParameter(dbCommand, "ADDED_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);

                Audit.CustomLog(" End: ManageContactDL.aspx - CreateContact", objContact);
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
                Audit.CustomLog(" Start: ManageContactDL.aspx - GetContactDetails", ContactId);
               
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
                objContact.SecurityQuestion = row["SECURITY_QUESTION"].ToString();
                objContact.SecurityAnswer = row["SECURITY_ANSWER"].ToString();
               // objContact.Cont_order_no =Convert.ToInt16( row["CONT_ORDER_NO"].ToString());
                objContact.Cont_order_no = (row["CONT_ORDER_NO"] == DBNull.Value) ? 0 : Convert.ToInt16(row["CONT_ORDER_NO"]);
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

                Audit.CustomLog(" End: ManageContactDL.aspx - GetContactDetails", ContactId);
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
        public bool UpdateContactProfile(BusinessObjects.Contact objContact)
        {  
            Audit.CustomLog(" Start: ManageContactDL.aspx - UpdateContact", objContact);

            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("itivo");
            DbConnection conn = db.CreateConnection();
            conn.Open();
            DbTransaction transaction = conn.BeginTransaction();
            
            try
            {
              
                Audit.CustomLog(" Start: ManageContactDL.aspx - UpdateContact - Contact Section", objContact);

                DbCommand dbCommandContact = db.GetStoredProcCommand("spUpdateContact");
                dbCommandContact.Transaction = transaction;
                
                db.AddInParameter(dbCommandContact, "CONTACTID", DbType.Int64, objContact.Cont_id);
                db.AddInParameter(dbCommandContact, "CONT_F_NAME", DbType.String, objContact.Cont_f_name);
                db.AddInParameter(dbCommandContact, "CONT_M_NAME", DbType.String, objContact.Cont_m_name);
                db.AddInParameter(dbCommandContact, "CONT_L_NAME", DbType.String, objContact.Cont_l_name);
                db.AddInParameter(dbCommandContact, "CONT_Email_ID", DbType.String, objContact.Cont_email_id);
                db.AddInParameter(dbCommandContact, "USER_NAME", DbType.String, objContact.UserName);
                db.AddInParameter(dbCommandContact, "PASSWORD", DbType.String, objContact.Password);
                db.AddInParameter(dbCommandContact, "SECURITY_QUESTION", DbType.String, objContact.SecurityQuestion);
                db.AddInParameter(dbCommandContact, "SECURITY_ANSWER", DbType.String, objContact.SecurityAnswer);
                db.AddInParameter(dbCommandContact, "CONT_ORDER_NO", DbType.Int16, objContact.Cont_order_no);
                db.AddInParameter(dbCommandContact, "SKYPE_ID", DbType.String, objContact.Skype_id);
                db.AddInParameter(dbCommandContact, "FACEBOOK_ID", DbType.String, objContact.Facebook_id);
                db.AddInParameter(dbCommandContact, "LINKEDIN_ID", DbType.String, objContact.Linkedin_id);
                db.AddInParameter(dbCommandContact, "TWITTER_ID", DbType.String, objContact.Twitter_id);
                db.AddInParameter(dbCommandContact, "GOOGLEPLUS_ID", DbType.String, objContact.Googleplus_id);
                db.AddInParameter(dbCommandContact, "LINK1_ID", DbType.String, objContact.Link1_id);
                db.AddInParameter(dbCommandContact, "LINK2_ID", DbType.String, objContact.Link2_id);
                db.AddInParameter(dbCommandContact, "LINK3_ID", DbType.String, objContact.Link3_id);
                db.AddInParameter(dbCommandContact, "BLOG_ID", DbType.String, objContact.Blog_id);
                db.AddInParameter(dbCommandContact, "WEBSITE_URL", DbType.String, objContact.Website_url);
                db.AddInParameter(dbCommandContact, "UPDATE_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommandContact,transaction);
                Audit.CustomLog(" End: ManageContactDL.aspx - UpdateContact - Contact Section", objContact);
                /*
                Audit.CustomLog(" Start: ManageContactDL.aspx - CreateContactProfile - Address Section", objContact);
               //Check if the address already exist then Update Address else Insert Address
                BusinessObjects.Address objAddress = new BusinessObjects.Address();
                if (objAddress.Post_add_id == 0)
                {
                    //Insert Address
                    DbCommand dbCommandAddress = db.GetStoredProcCommand("spInsertAddress");
                    dbCommandAddress.Transaction = transaction;
                    db.AddInParameter(dbCommandAddress, "CONT_ID", DbType.Int64, objAddress.Cont_id);
	                db.AddInParameter(dbCommandAddress, "POST_ADD_LINE_1", DbType.String, objAddress.Post_add_line_1);
	                db.AddInParameter(dbCommandAddress, "POST_ADD_LINE_2", DbType.String, objAddress.Post_add_line_2);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_LINE_3", DbType.String, objAddress.Post_add_line_3);
	                db.AddInParameter(dbCommandAddress, "POST_COUNTY", DbType.String, objAddress.Post_county);
	                db.AddInParameter(dbCommandAddress, "POST_ADD_INFO_1", DbType.String, objAddress.Post_add_info_1);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_INFO_2", DbType.String, objAddress.Post_add_info_2);
	                db.AddInParameter(dbCommandAddress, "POST_ADD_ATTN", DbType.String, objAddress.Post_add_attn);
	                db.AddInParameter(dbCommandAddress, "POST_ADD_PO_STREET", DbType.String, objAddress.Post_add_po_street);
	                db.AddInParameter(dbCommandAddress, "POST_ADD_CITY", DbType.String, objAddress.Post_add_city);
	                db.AddInParameter(dbCommandAddress, "POST_ADD_STATE", DbType.String, objAddress.Post_add_state);
	                db.AddInParameter(dbCommandAddress, "POST_ADD_POSTAL_CODE", DbType.String, objAddress.Post_add_postal_code);
	                db.AddInParameter(dbCommandAddress, "POST_ADD_COUNTRY", DbType.String, objAddress.Post_county);
	                db.AddInParameter(dbCommandAddress, "POST_ADD_TYPE", DbType.String, objAddress.Post_add_type);
                    db.AddInParameter(dbCommandAddress, "Added_By", DbType.String, BusinessObjects.LoggedInUser.User_ID);
                    DataSet dsContact = db.ExecuteDataSet(dbCommandAddress,transaction);
                    
                }
                else
                {
                    //Update Address
                    DbCommand dbCommandAddress = db.GetStoredProcCommand("spUpdateAddress");
                    dbCommandAddress.Transaction = transaction;
                    db.AddInParameter(dbCommandAddress, "POST_ADD_ID", DbType.Int64, objAddress.Post_add_id);
                    db.AddInParameter(dbCommandAddress, "CONT_ID", DbType.Int64, objAddress.Cont_id);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_LINE_1", DbType.String, objAddress.Post_add_line_1);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_LINE_2", DbType.String, objAddress.Post_add_line_2);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_LINE_3", DbType.String, objAddress.Post_add_line_3);
                    db.AddInParameter(dbCommandAddress, "POST_COUNTY", DbType.String, objAddress.Post_county);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_INFO_1", DbType.String, objAddress.Post_add_info_1);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_INFO_2", DbType.String, objAddress.Post_add_info_2);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_ATTN", DbType.String, objAddress.Post_add_attn);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_PO_STREET", DbType.String, objAddress.Post_add_po_street);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_CITY", DbType.String, objAddress.Post_add_city);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_STATE", DbType.String, objAddress.Post_add_state);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_POSTAL_CODE", DbType.String, objAddress.Post_add_postal_code);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_COUNTRY", DbType.String, objAddress.Post_add_country);
                    db.AddInParameter(dbCommandAddress, "POST_ADD_TYPE", DbType.String, objAddress.Post_add_type);
                    db.AddInParameter(dbCommandAddress, "Update_By", DbType.String, BusinessObjects.LoggedInUser.User_ID);
                    DataSet dsAddress = db.ExecuteDataSet(dbCommandAddress,transaction);
                }

                Audit.CustomLog(" End: ManageContactDL.aspx - CreateContactProfile - Address Section", objContact);


                Audit.CustomLog(" Start: ManageContactDL.aspx - CreateContactProfile - Phone Section", objContact);

                 //Check if Phone already exist then Update Phone else Insert Phone
                if (objPhone.Phone_id == 0)
                {
                    //Insert Phone
                    DbCommand dbCommandPhone = db.GetStoredProcCommand("spInsertPhone");
                    dbCommandPhone.Transaction = transaction;
                    db.AddInParameter(dbCommandPhone, "CONT_ID", DbType.Int16, objPhone.Cont_id);
                    db.AddInParameter(dbCommandPhone, "PHONE_COUNTRY", DbType.String, objPhone.Phone_country);
                    db.AddInParameter(dbCommandPhone, "PHONE_AREA", DbType.String, objPhone.Phone_area);
                    db.AddInParameter(dbCommandPhone, "PHONE_NUMBER", DbType.String, objPhone.Phone_number);
                    db.AddInParameter(dbCommandPhone, "PHONE_TYPE", DbType.String, objPhone.Phone_type);
                    db.AddInParameter(dbCommandPhone, "ADDED_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                    DataSet dsPhone = db.ExecuteDataSet(dbCommandPhone,transaction);

                } 
                else
                { 
                    //Update Phone
                    DbCommand dbCommandPhone = db.GetStoredProcCommand("spUpdatePhone");
                    dbCommandPhone.Transaction = transaction;
                    db.AddInParameter(dbCommandPhone, "PHONE_ID", DbType.Int64, objPhone.Phone_id);
                    db.AddInParameter(dbCommandPhone, "CONT_ID", DbType.Int64, objPhone.Cont_id);
                    db.AddInParameter(dbCommandPhone, "PHONE_COUNTRY", DbType.String, objPhone.Phone_country);
                    db.AddInParameter(dbCommandPhone, "PHONE_AREA", DbType.String, objPhone.Phone_area);
                    db.AddInParameter(dbCommandPhone, "PHONE_NUMBER", DbType.String, objPhone.Phone_number);
                    db.AddInParameter(dbCommandPhone, "PHONE_TYPE", DbType.String, objPhone.Phone_type);
                    db.AddInParameter(dbCommandPhone, "UPDATE_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                    DataSet dsPhone = db.ExecuteDataSet(dbCommandPhone,transaction);
                }

                Audit.CustomLog(" End: ManageContactDL.aspx - CreateContactProfile - Phone Section", objContact);
                */
                transaction.Commit();

                Audit.CustomLog(" End: ManageContactDL.aspx - UpdateContact", objContact);
                return true;

            }
            catch (Exception ex)
            {
                transaction.Rollback();
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
                Audit.CustomLog(" Start: ManageContactDL.aspx - DeleteContact", objContact);
               
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("SPDeleteContact");
                db.AddInParameter(dbCommand, "CONTACTID", DbType.String, objContact.Cont_id);
                db.AddInParameter(dbCommand, "UPDATE_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog(" End: ManageContactDL.aspx - DeleteContact", objContact);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactDL.aspx - DeleteContact", objContact, false);
                throw;
            }
        }


        /// <summary>
        /// Validates the user.
        /// </summary>
        /// <param name="UserName">Name of the user.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        public DataTable ValidateUser(string UserName,string Password)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContactDL.aspx - ValidateUser",UserName);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spValidateUser");
                db.AddInParameter(dbCommand, "User_Name", DbType.String, UserName);
                db.AddInParameter(dbCommand, "password", DbType.String, Password);
                DataSet ds = db.ExecuteDataSet(dbCommand); 

                Audit.CustomLog(" End: ManageContactDL.aspx - ValidateUser", UserName);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactDL.aspx - ValidateUser", UserName, false);
                throw ex;
            }
        }
    }
}
