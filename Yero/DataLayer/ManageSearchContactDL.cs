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
    public class ManageSearchContactDL
    {

        public DataTable GetSearchContactResult(string Cont_F_Name, string Cont_L_Name, string User_Name, string Cont_Email)
        {
            try
            {
                
                Audit.CustomLog(" Start: ManageSearchContactDL.aspx - GetSearchContactResult", null);
              

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database db = factory.Create("itivo");
                DbConnection conn = db.CreateConnection();
                conn.Open();
            
                DbCommand dbCommand = db.GetStoredProcCommand("spSearchContact");
                 db.AddInParameter(dbCommand, "CONT_F_NAME", DbType.String, Cont_F_Name);
                 db.AddInParameter(dbCommand, "CONT_L_NAME", DbType.String, Cont_L_Name);
                 db.AddInParameter(dbCommand, "USER_NAME", DbType.String, User_Name);
                 db.AddInParameter(dbCommand, "CONT_Email_ID", DbType.String, Cont_Email);
                
                DataSet ds = db.ExecuteDataSet(dbCommand);
                Audit.CustomLog(" End: ManageSearchContactDL.aspx - GetSearchContactResult", null);

                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageSearchContactDL.aspx - GetSearchContactResult", null, false);   
                throw;
            }
        }
    }
}