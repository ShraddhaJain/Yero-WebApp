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
using MySql.Data.MySqlClient;

namespace Yero.DataLayer
{
    public class ManageContactPhoneDL
    {
        /// <summary>
        /// Gets all phone.
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllPhone()
        {

            try
            {

                Audit.CustomLog(" Start: ManageContactPhoneDL.aspx - GetAllPhone", null);


                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spGetAllPhone");

                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog(" End: ManageContactPhoneDL.aspx - GetAllPhone", null);

                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactPhoneDL.aspx - GetAllPhone", null, false);
                throw;
            }
        }


        /// <summary>
        /// Creates the phone.
        /// </summary>
        /// <param name="objPhone">The object phone.</param>
        /// <returns></returns>
        public bool CreatePhone(BusinessObjects.Phone objPhone)
        {

            try
            {
                Audit.CustomLog(" Start: ManageContactPhoneDL.aspx - CreatePhone", objPhone);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();


                DbCommand dbCommand = db.GetStoredProcCommand("spInsertPhone");
                db.AddInParameter(dbCommand, "CONT_ID", DbType.Int16, objPhone.Cont_id);
                db.AddInParameter(dbCommand, "PHONE_COUNTRY", DbType.String, objPhone.Phone_country);
                db.AddInParameter(dbCommand, "PHONE_AREA", DbType.String, objPhone.Phone_area);
                db.AddInParameter(dbCommand, "PHONE_NUMBER", DbType.String, objPhone.Phone_number);
                db.AddInParameter(dbCommand, "PHONE_TYPE", DbType.String, objPhone.Phone_type);
                db.AddInParameter(dbCommand, "ADDED_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);

                Audit.CustomLog(" End: ManageContactPhoneDL.aspx - CreatePhone", objPhone);
                return true;

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactPhoneDL.aspx - CreatePhone", objPhone, false);
                throw;
            }
        }


        /// <summary>
        /// Gets the phone details.
        /// </summary>
        /// <param name="PhoneID">The phone identifier.</param>
        /// <returns></returns>
        public BusinessObjects.Phone GetPhoneDetails(int ContactID)
        {

            try
            {
                Audit.CustomLog(" Start: ManageContactPhoneDL.aspx - GetPhoneDetails", ContactID);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spGetPhoneDetails");
                db.AddInParameter(dbCommand, "CONT_ID", DbType.Int64, ContactID);

                DataSet ds = db.ExecuteDataSet(dbCommand);
                DataTable dt = ds.Tables[0];
                BusinessObjects.Phone objPhone = new BusinessObjects.Phone();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    objPhone.Cont_id = Convert.ToInt16(row["CONT_ID"]);
                    objPhone.Phone_id = Convert.ToInt16(row["PHONE_ID"]);
                    objPhone.Phone_country = row["PHONE_COUNTRY"].ToString();
                    objPhone.Phone_area = row["PHONE_AREA"].ToString();
                    objPhone.Phone_number = row["PHONE_NUMBER"].ToString();
                    objPhone.Phone_type = row["PHONE_TYPE"].ToString();
                }

                Audit.CustomLog(" End: ManageContactPhoneDL.aspx - GetPhoneDetails", ContactID);
                return objPhone;
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactPhoneDL.aspx - GetPhoneDetails", ContactID, false);
                throw;
            }
        }

        /// <summary>
        /// Updates the Phone.
        /// </summary>
        /// <param name="objPhone">The object Phone.</param>
        /// <returns></returns>
        public bool UpdatePhone(BusinessObjects.Phone objPhone)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContactPhoneDL.aspx - UpdatePhone", objPhone);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();


                DbCommand dbCommand = db.GetStoredProcCommand("spUpdatePhone");
                db.AddInParameter(dbCommand, "PHONE_ID", DbType.Int64, objPhone.Phone_id);
                db.AddInParameter(dbCommand, "CONT_ID", DbType.Int64, objPhone.Cont_id);
                db.AddInParameter(dbCommand, "PHONE_COUNTRY", DbType.String, objPhone.Phone_country);
                db.AddInParameter(dbCommand, "PHONE_AREA", DbType.String, objPhone.Phone_area);
                db.AddInParameter(dbCommand, "PHONE_NUMBER", DbType.String, objPhone.Phone_number);
                db.AddInParameter(dbCommand, "PHONE_TYPE", DbType.String, objPhone.Phone_type);
                db.AddInParameter(dbCommand, "UPDATE_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);

                Audit.CustomLog(" End: ManageContactPhoneDL.aspx - UpdatePhone", objPhone);
                return true;

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactPhoneDL.aspx - UpdatePhone", objPhone, false);
                throw;
            }
        }


        /// <summary>
        /// Deletes the phone.
        /// </summary>
        /// <param name="objPhone">The object phone.</param>
        public void DeletePhone(BusinessObjects.Phone objPhone)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContactPhoneDL.aspx - DeletePhone", objPhone);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spDeletePhone");
                db.AddInParameter(dbCommand, "PHONE_ID", DbType.String, objPhone.Phone_id);
                db.AddInParameter(dbCommand, "CONT_ID", DbType.String, objPhone.Cont_id);
                db.AddInParameter(dbCommand, "Update_By", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);
               Audit.CustomLog(" End: ManageContactPhoneDL.aspx - DeletePhone", objPhone);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactPhoneDL.aspx - DeletePhone", objPhone, false);
                throw;
            }
        }



    }
}