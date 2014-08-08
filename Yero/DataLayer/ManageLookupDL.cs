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
    public class ManageLookupDL
    {
         /// <summary>
        /// Creates the contact.
        /// </summary>
        /// <param name="objContact">The object contact.</param>
        /// <returns></returns>
        public DataTable GetLookupDetailValues(string CODE_NAME)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContactDL.aspx - CreateContact - ", CODE_NAME);

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();
                DbCommand dbCommand = db.GetStoredProcCommand("GetLookUpDetailValues");
                db.AddInParameter(dbCommand, "CODE_NAME", DbType.String, CODE_NAME);
              
                DataSet ds = db.ExecuteDataSet(dbCommand);

                Audit.CustomLog(" End: ManageContactDL.aspx - CreateContact", CODE_NAME);
                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContactDL.aspx - CreateContact", CODE_NAME, false);
                throw;
            }
        }
    }
}