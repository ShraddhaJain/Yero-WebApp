using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Yero
{
    public partial class ContactSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                 Audit.CustomLog(" Start: ContactSearch.aspx - btnSearch_Click", null);

                DataLayer.ManageSearchContactDL objManageSearchContact = new DataLayer.ManageSearchContactDL();
                DataTable dtContacts = objManageSearchContact.GetSearchContactResult(txtFname.Text.Trim(),txtLname.Text.Trim(),txtUserName.Text.Trim(),txtEmail.Text.Trim());

                grdSearchResult.DataSource = dtContacts;
                grdSearchResult.DataBind();


                Audit.CustomLog(" End: ContactSearch.aspx - btnSearch_Click", null);

               
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}