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
    public class ManageContactAddressDL
    {

        /// <summary>
        /// Gets the contact details.
        /// </summary>
        /// <param name="ContactId">The contact identifier.</param>
        /// <returns></returns>
        public DataTable GetAddressDetails(int ContactId)
        {

            try
            {
                Audit.CustomLog(" Start: ManageContactDL.aspx - GetContactAddressDetails", ContactId);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spGetAddressDetails");
                db.AddInParameter(dbCommand, "CONT_ID", DbType.Int64, ContactId);


                BusinessObjects.Address objAddress = new BusinessObjects.Address();
                DataSet ds = db.ExecuteDataSet(dbCommand);
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    foreach (DataRow row in ds.Tables[0].Rows)
                //    {
                //        DataTable dt = ds.Tables[0];
                //       // DataRow row = ds.Tables[0].Rows[0];
                //        objAddress.Post_add_id = Convert.ToInt16(row["POST_ADD_ID"]);
                //        objAddress.Cont_id = Convert.ToInt16(row["CONT_ID"]);
                //        objAddress.Post_add_line_1 = row["POST_ADD_LINE_1"].ToString();
                //        objAddress.Post_add_line_2 = row["POST_ADD_LINE_2"].ToString();
                //        objAddress.Post_add_line_3 = row["POST_ADD_LINE_3"].ToString();
                //        objAddress.Post_county = row["POST_COUNTY"].ToString();
                //        objAddress.Post_add_info_1 = row["POST_ADD_INFO_1"].ToString();
                //        objAddress.Post_add_info_2 = row["POST_ADD_INFO_2"].ToString();
                //        objAddress.Post_add_attn = row["POST_ADD_ATTN"].ToString();
                //        objAddress.Post_add_po_street = row["POST_ADD_PO_STREET"].ToString();
                //        objAddress.Post_add_city = row["POST_ADD_CITY"].ToString();
                //        objAddress.Post_add_state = row["POST_ADD_STATE"].ToString();
                //        objAddress.Post_add_postal_code = row["POST_ADD_POSTAL_CODE"].ToString();
                //        objAddress.Post_add_country = row["POST_ADD_COUNTRY"].ToString();
                //        objAddress.Post_add_type = row["POST_ADD_TYPE"].ToString();
                //    }
                //}

                Audit.CustomLog(" End: ManageContactDL.aspx - GetContactAddressDetails", ContactId);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactDL.aspx - GetContactAddressDetails", ContactId, false);
                throw;
            }
        }

        /// <summary>
        /// Creates the address.
        /// </summary>
        /// <param name="objAddress">The object address.</param>
        /// <returns></returns>
        public bool CreateAddress(BusinessObjects.Address objAddress)
        {

            try
            {
                Audit.CustomLog(" Start: ManageContactAddressDL.aspx - CreateAddress", objAddress);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                
                DbCommand dbCommandAddress = db.GetStoredProcCommand("spInsertAddress");
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
                db.AddInParameter(dbCommandAddress, "Added_By", DbType.String, BusinessObjects.LoggedInUser.User_ID);
                DataSet dsContact = db.ExecuteDataSet(dbCommandAddress);


                Audit.CustomLog(" Start: ManageContactAddressDL.aspx - CreateAddress", objAddress);
                return true;
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactAddressDL.aspx - CreateAddress", objAddress, false);
                throw;
            }
        }

        /// <summary>
        /// Updates the address.
        /// </summary>
        /// <param name="objAddress">The object address.</param>
        /// <returns></returns>
        public bool UpdateAddress(BusinessObjects.Address objAddress)
        {

            try
            {
                Audit.CustomLog(" Start: ManageContactAddressDL.aspx - UpdateAddress", objAddress);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();


                DbCommand dbCommandAddress = db.GetStoredProcCommand("spUpdateAddress");
                db.AddInParameter(dbCommandAddress, "POST_ADD_ID", DbType.Int64, objAddress.Post_add_id);
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
                DataSet dsAddress = db.ExecuteDataSet(dbCommandAddress);


                Audit.CustomLog(" Start: ManageContactAddressDL.aspx - UpdateAddress", objAddress);
                return true;
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactAddressDL.aspx - UpdateAddress", objAddress, false);
                throw;
            }
        }

        /// <summary>
        /// Deletes the address.
        /// </summary>
        /// <param name="objAddress">The object address.</param>
        public void DeleteAddress(BusinessObjects.Address objAddress)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContactAddressDL.aspx - DeleteAddress", objAddress);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spDeleteAddress");
                db.AddInParameter(dbCommand, "POST_ADD_ID", DbType.String, objAddress.Post_add_id);
                db.AddInParameter(dbCommand, "CONT_ID", DbType.String, objAddress.Cont_id);
                db.AddInParameter(dbCommand, "Update_By", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog(" End: ManageContactAddressDL.aspx - DeleteAddress", objAddress);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactAddressDL.aspx - DeleteAddress", objAddress, false);
                throw;
            }
        }

    }
}