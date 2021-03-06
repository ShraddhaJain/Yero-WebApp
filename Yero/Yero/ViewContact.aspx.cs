﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessObjects;
using System.ComponentModel;

namespace Yero
{
    public partial class ViewContact : System.Web.UI.Page
    {
       

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // //Check Contact ID and module Access
                //DataTable dt = HttpContext.Current.Cache["RolePermission"] as DataTable;
                //bool contains = dt.AsEnumerable()
                //   .Any(row => "Contact" == row.Field<String>("PermissionName"));
                //if (!contains)
                //{
                //    //Redirect to login page
                //    Response.Redirect("~/Account/Login.aspx",false);
                //}

                Audit.CustomLog(" Start: ViewContact.aspx - Page_Load", null);

                DataTable dtContacts = new DataTable();
                dtContacts = GetContacts();
                grdContact.DataSource = dtContacts;
                grdContact.DataBind();

                Audit.CustomLog(" End: ViewContact.aspx - Page_Load", null);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewContact.aspx - Page_Load", null,true);
            }
             
        }

        /// <summary>
        /// Gets the contacts.
        /// </summary>
        /// <returns></returns>
        DataTable GetContacts()
        {
            try
            {
                Audit.CustomLog(" Start: ViewContact.aspx - GetContacts", null);

                DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
                DataTable dtContacts = objManageContact.GetAllContacts();

                Audit.CustomLog(" End: ViewContact.aspx - GetContacts ", null);

                return dtContacts;

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewContact.aspx - GetContacts ", null,false);
                throw;
            }
          
        }


        /// <summary>
        /// Handles the SelectedIndexChanged event of the grdContact control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void grdContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ViewContact.aspx - grdContact_SelectedIndexChanged ", null);

                GridViewRow row = grdContact.SelectedRow;
                string ContactID = row.Cells[1].Text;
                this.Session["SelectedContact"] = ContactID;

                Audit.CustomLog(" End: ViewContact.aspx - grdContact_SelectedIndexChanged", null);

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewContact.aspx - grdContact_SelectedIndexChanged", null,true);   
            }

        }

        /// <summary>
        /// Handles the Click event of the btnEditContact control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnEditContact_Click(object sender, EventArgs e)
        {
            try
            {
               Audit.CustomLog(" Start: ViewContact.aspx - btnEditContact_Click", null);
                CheckContactSelection();
                if (Convert.ToInt16( this.Session["SelectedContact"]) != 0)
                {
                    Response.Redirect("~/ManageContact.aspx",false);
                }
                    Audit.CustomLog(" End: ViewContact.aspx - btnEditContact_Click", null);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewContact.aspx - btnEditContact_Click", null,true);
            }
        }

        protected void CheckContactSelection()
        {
            GridViewRow row = grdContact.SelectedRow;
            if (row == null)
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Please select Contact')", true);
            }
            else
            {
                string ContactID = row.Cells[1].Text;
                this.Session["SelectedContact"] = ContactID;
            }
           
        }

        /// <summary>
        /// Handles the Click event of the btnAddContact control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddContact_Click(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ViewContact.aspx - btnAddContact_Click", null);

                this.Session["SelectedContact"] = 0;
                Response.Redirect("ManageContact.aspx");

                Audit.CustomLog(" End: ViewContact.aspx - btnAddContact_Click", null);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewContact.aspx - btnAddContact_Click", null,true);
            }
        }

        protected void btnPhone_Click(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ViewContact.aspx - btnPhone_Click", null);
                 CheckContactSelection();
                Response.Redirect("ManageContactPhone.aspx");
                Audit.CustomLog(" End: ViewContact.aspx - btnPhone_Click", null);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewContact.aspx - btnPhone_Click", null, true);
            }
        }


        protected void btnAddress_Click(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ViewContact.aspx - btnAddress_Click", null);
                CheckContactSelection();
                Response.Redirect("ManageContactPhone.aspx");
                Audit.CustomLog(" End: ViewContact.aspx - btnAddress_Click", null);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewContact.aspx - btnAddress_Click", null, true);
            }
            
        }

    }
}