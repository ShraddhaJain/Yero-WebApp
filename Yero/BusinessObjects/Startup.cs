using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace BusinessObjects
{
    class Startup
    {
        public Startup(System.Web.UI.Page currentPage) 
        {
        //Check Contact ID and module Access 


            //if (HttpContext.Current.Cache["RolePermission"] == null)
            //{
            //    DataLayer.ManageRolePermissionsDL objManagePermissions = new DataLayer.ManageRolePermissionsDL();
            //    DataTable ContactPermissions = objManagePermissions.GetContactPermissions(Convert.ToInt16(Session["ContactID"]));
            //    HttpContext.Current.Cache.Insert("RolePermission", ContactPermissions, null, DateTime.Now.AddMinutes(30), System.Web.Caching.Cache.NoSlidingExpiration);
            //}

        //Redirect to login page 
        HttpContext.Current.Response.Redirect("/Login.aspx"); 

        }

    }

    // Call from page will be -  
    // StartUp startupactivity = new StartUp(this.Page);

}
