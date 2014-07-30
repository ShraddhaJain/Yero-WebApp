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
    public class ManageCategoryDL
    {

        /// <summary>
        /// Initializes the <see cref="ManageCategoryDL"/> class.
        /// </summary>
        static ManageCategoryDL()
        {
           // DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
        }


        /// <summary>
        /// Gets all categories.
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllCategories()
        {

            try
            {

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();


                DbCommand dbCommand = db.GetStoredProcCommand("spGetAllCategories");
                DataSet ds = db.ExecuteDataSet(dbCommand);

                return ds.Tables[0];

            }
            catch (Exception)
            {
                
                throw;
            }
        }


        /// <summary>
        /// Creates the category.
        /// </summary>
        /// <param name="objCategory">The object category.</param>
        /// <returns></returns>
        public bool CreateCategory(BusinessObjects.Category objCategory)
        {

            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();


                DbCommand dbCommand = db.GetStoredProcCommand("spInsertCategory");
                db.AddInParameter(dbCommand, "CategoryName", DbType.String, objCategory.Categoryname);
                db.AddInParameter(dbCommand, "Description", DbType.String, objCategory.Description);
                db.AddInParameter(dbCommand, "Picture", DbType.String, objCategory.Picture);
                db.AddInParameter(dbCommand, "ADDED_BY", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);
                return true;

            }
            catch (Exception)
            {
                
                throw;
            }
        }


        /// <summary>
        /// Gets the category details.
        /// </summary>
        /// <param name="CategoryID">The category identifier.</param>
        /// <returns></returns>
        public BusinessObjects.Category GetCategoryDetails(int CategoryID)
        {

            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();


                DbCommand dbCommand = db.GetStoredProcCommand("spGetCategoryDetails");
                db.AddInParameter(dbCommand, "CategoryID", DbType.Int64, CategoryID);

                DataSet ds = db.ExecuteDataSet(dbCommand);

                BusinessObjects.Category objCategory = new BusinessObjects.Category();

                DataRow row = ds.Tables[0].Rows[0];
                objCategory.Categoryid = Convert.ToInt16(row["Categoryid"]);
                objCategory.Categoryname = row["Categoryname"].ToString();
                objCategory.Description = row["Description"].ToString();
                objCategory.Picture = row["Picture"].ToString();
                objCategory.Active = row["Active"].ToString();

                return objCategory;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /// <summary>
        /// Updates the category.
        /// </summary>
        /// <param name="objCatogory">The object catogory.</param>
        /// <returns></returns>
        public bool UpdateCategory(BusinessObjects.Category objCatogory)
        {
            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();


                DbCommand dbCommand = db.GetStoredProcCommand("spUpdateCategory");
                db.AddInParameter(dbCommand, "CategoryID", DbType.Int64, objCatogory.Categoryid);
                db.AddInParameter(dbCommand, "CategoryName", DbType.String, objCatogory.Categoryname);
                db.AddInParameter(dbCommand, "Description", DbType.String, objCatogory.Description);
                db.AddInParameter(dbCommand, "Picture", DbType.String, objCatogory.Picture);
                db.AddInParameter(dbCommand, "Update_By", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);

                return true;

            }
            catch (Exception)
            {
                
                throw;
            }

        }

        /// <summary>
        /// Deletes the category.
        /// </summary>
        /// <param name="objCategory">The object category.</param>
        public void DeleteCategory(BusinessObjects.Category objCategory)
        {
            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("SPDeleteCategory");
                db.AddInParameter(dbCommand, "CategoryID", DbType.String, objCategory.Categoryid);
                db.AddInParameter(dbCommand, "Update_By", DbType.String, BusinessObjects.LoggedInUser.User_ID);

                DataSet ds = db.ExecuteDataSet(dbCommand);
                
                

            }
            catch (Exception)
            {
                
                throw;
            }
        }


    }
}