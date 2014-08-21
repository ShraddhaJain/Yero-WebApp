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
    
    }
}