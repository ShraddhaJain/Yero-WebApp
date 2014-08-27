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
    public class ManageOrderDL
    {

        public DataTable GetProductSearchResult(string ProductDescription)
        {
            try
            {  

                Audit.CustomLog(" Start: ManageOrderDL.aspx - GetProductSearchResult", null);


                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spSearchProduct");
                db.AddInParameter(dbCommand, "ProductDescription", DbType.String, ProductDescription);

                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog(" End: ManageOrderDL.aspx - GetProductSearchResult", null);

                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageOrderDL.aspx - GetSearchContactResult", null, false);
                throw;
            }
        }

        public DataTable CreateOrder(BusinessObjects.orders objOrder)
        {
            try
            {

                Audit.CustomLog(" Start: ManageOrderDL.aspx - CreateOrder", null);


                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spInsertOrder");
                db.AddInParameter(dbCommand, "CUSTOMER_ID", DbType.Int32, objOrder.Customer_id);
                db.AddInParameter(dbCommand, "PAYMENT_ID", DbType.Int32, objOrder.Payment_id);
                db.AddInParameter(dbCommand, "ORDER_NUMBER", DbType.Int32, objOrder.Order_number);
                db.AddInParameter(dbCommand, "PAYMENT_TYPE", DbType.Int32, objOrder.Payment_type);
                db.AddInParameter(dbCommand, "PAYMENTDATE", DbType.DateTime, objOrder.Paymentdate);
                db.AddInParameter(dbCommand, "ORDER_DATE", DbType.DateTime, objOrder.Order_date);
                db.AddInParameter(dbCommand, "ORDER_SCHEDULED_Date", DbType.DateTime, objOrder.Order_scheduled_date);
                db.AddInParameter(dbCommand, "ORDER_MODIFIED_Date", DbType.DateTime, objOrder.Order_modified_date);
                db.AddInParameter(dbCommand, "ORDER_SHIP_Date", DbType.DateTime, objOrder.Order_ship_date);
                db.AddInParameter(dbCommand, "ORDER_Status", DbType.String, objOrder.ORDER_Status);
                db.AddInParameter(dbCommand, "PAID", DbType.Boolean, objOrder.Paid);
                db.AddInParameter(dbCommand, "ADDED_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);


                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog(" End: ManageOrderDL.aspx - CreateOrder", null);

                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageOrderDL.aspx - CreateOrder", null, false);
                throw;
            }
        }



        public void CreateOrderDetails(BusinessObjects.Order_Details objOrderDetail)
        {
            try
            {

                Audit.CustomLog(" Start: ManageOrderDL.aspx - CreateOrder", null);


                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spInsertOrderDetails");
                db.AddInParameter(dbCommand, "ORDER_ID", DbType.Int32, objOrderDetail.Order_id);
                db.AddInParameter(dbCommand, "PRODUCT_ID", DbType.Int32, objOrderDetail.Product_id);
                db.AddInParameter(dbCommand, "PRODUCT_MASTER_CODE", DbType.Int32, objOrderDetail.Product_master_code);
                db.AddInParameter(dbCommand, "QUANTITY", DbType.Int32, objOrderDetail.Quantity);
                db.AddInParameter(dbCommand, "COST", DbType.Decimal, objOrderDetail.Cost);
                db.AddInParameter(dbCommand, "SELL", DbType.Decimal, objOrderDetail.Sell);
                db.AddInParameter(dbCommand, "DISCOUNT", DbType.Decimal, objOrderDetail.Discount);
                db.AddInParameter(dbCommand, "STATUS", DbType.String, objOrderDetail.Status);
                db.AddInParameter(dbCommand, "ADDED_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);


                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog(" End: ManageOrderDL.aspx - CreateOrder", null);


            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageOrderDL.aspx - CreateOrder", null, false);
                throw;
            }
        }


        public DataTable GetOrderDetails(int OrderID)
        {
            try
            {

                Audit.CustomLog(" Start: ManageOrderDL.aspx - CreateOrder", null);


                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spGetOrderDetails");
                db.AddInParameter(dbCommand, "ORDER_ID", DbType.Int32, OrderID);
                
                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog(" End: ManageOrderDL.aspx - CreateOrder", null);

                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageOrderDL.aspx - CreateOrder", null, false);
                throw;
            }
        }


        public DataTable SearchOrder(string OrderStatus, string OrderNumber, string OrderDate, string CustomerName)
        {

            try
            {

                Audit.CustomLog(" Start: ManageOrderDL.aspx - SearchOrder", null);


                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spSearchOrder");
                db.AddInParameter(dbCommand, "ORDER_Status", DbType.String, OrderStatus);
                db.AddInParameter(dbCommand, "ORDER_NUMBER", DbType.String, OrderNumber);
                db.AddInParameter(dbCommand, "ORDER_DATE", DbType.String, OrderDate);
                db.AddInParameter(dbCommand, "CUSTOMER_NAME", DbType.String, CustomerName);

                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog(" End: ManageOrderDL.aspx - SearchOrder", null);

                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageOrderDL.aspx - SearchOrder", null, false);
                throw;
            }
        }
    }
}