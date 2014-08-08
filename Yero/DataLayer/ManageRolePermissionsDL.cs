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
    public class ManageRolePermissionsDL
    {
        public DataTable GetContactPermissions(int ContactID)
        {
            try
            {
                Audit.CustomLog(" Start: ManageRolePermissionsDL.aspx - GetContactPermissions", ContactID);
               
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();

                DbCommand dbCommand = db.GetStoredProcCommand("spGetRolePermission");
                db.AddInParameter(dbCommand, "CONTACT_ID", DbType.Int64, ContactID);
                DataSet ds = db.ExecuteDataSet(dbCommand);
                DataTable dt = ds.Tables[0];

                Audit.CustomLog(" End: ManageRolePermissionsDL.aspx - GetContactPermissions", ContactID);
               
                return dt;
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageRolePermissionsDL.aspx - GetContactPermissions", ContactID, false);
                throw;
            }

          
        }

    }
}