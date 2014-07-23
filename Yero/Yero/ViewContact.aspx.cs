using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Yero
{
    public partial class ViewContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtContacts = new DataTable();
                dtContacts = GetContacts();
                grdContact.DataSource = dtContacts;
                grdContact.DataBind();
            }
            catch (Exception)
            {
                
                throw;
            }
             
        }

        DataTable GetContacts()
        {
            try
            {
                DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
                DataTable dtContacts = objManageContact.GetAllContacts();
                return dtContacts;
            }
            catch (Exception)
            {
                
                throw;
            }
          
        }


        protected void grdContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = grdContact.SelectedRow;
                string ContactID = row.Cells[1].Text;
                this.Session["SelectedContact"] = ContactID;
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        protected void btnEditContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(this.Session["SelectedContact"]) > 0)
                {
                    Response.Redirect("ManageContact.aspx");
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Please select Contact to update')", true);

                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

       

        protected void btnAddContact_Click(object sender, EventArgs e)
        {
            try
            {
                this.Session["SelectedContact"] = 0;
                Response.Redirect("ManageContact.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}