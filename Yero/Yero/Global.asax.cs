using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Yero.BusinessObjects;
using Yero.DataLayer;
using System.Data;

namespace Yero
{
    public class Global : HttpApplication
    {
        Cache objCache;

        void Application_Start(object sender, EventArgs e)
        {

            Audit.CustomLog("Start :Global.asax - Application_start", null);
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            try
            {
                objCache = new Cache("myCache");
                DataLayer.ManageLookupDL objManageLookup = new DataLayer.ManageLookupDL();


                //Cache for Look up Details valuef of Phone
                DataTable dtPhone = objManageLookup.GetLookupDetailValues("phone");
                bool boolLkUpPhone = objCache.setCache(dtPhone, "PhoneLkUp");
                if (boolLkUpPhone == false)
                    Audit.CustomLog(" WARNING: Global.asax - Look up details for Phone - Cache is not setting", dtPhone);

                //Cache for Look up Details value of Address
                DataTable dtAddress = objManageLookup.GetLookupDetailValues("address");

                bool boolLkUpAddress = objCache.setCache(dtAddress, "AddressLkUp");
                if (boolLkUpAddress == false)
                    Audit.CustomLog(" WARNING: Global.asax - Look up detauks for Address - Cache is not setting", dtAddress);


                Audit.CustomLog("End :Global.asax - Application_start", null);

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "Global.asax - Application_start", null, false);
            }



        }


    }
}