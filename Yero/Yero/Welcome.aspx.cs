using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Caching;
using System.IO;
using System.Data;

namespace Yero
{
    public partial class Welcome : System.Web.UI.Page
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                //this.Session["ContactID"] = 6;
                //Caching required data for the application
                GetContactPermission();
                

            }
        }

        protected void GetContactPermission()
        { 
            ObjectCache objCache = MemoryCache.Default;
           // DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
           // BusinessObjects.Contact objContact = objManageContact.GetContactDetails(Convert.ToInt16(Session["ContactID"]));

            if (HttpContext.Current.Cache["RolePermission"] == null)
            {
                DataLayer.ManageRolePermissionsDL objManagePermissions = new DataLayer.ManageRolePermissionsDL();
                DataTable ContactPermissions = objManagePermissions.GetContactPermissions(Convert.ToInt16(Session["LoggedInUserContactID"]));
                HttpContext.Current.Cache.Insert("RolePermission", ContactPermissions, null, DateTime.Now.AddMinutes(30), System.Web.Caching.Cache.NoSlidingExpiration);
            }

            
        }


        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            DataTable dt = HttpContext.Current.Cache["RolePermission"] as DataTable;

            gridpermissions.DataSource = dt;
            gridpermissions.DataBind();
        }
    }
}