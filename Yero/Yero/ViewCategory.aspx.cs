using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Yero
{
    public partial class ViewCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtCategory = new DataTable();
                dtCategory = GetContacts();
                grdCategory.DataSource = dtCategory;
                grdCategory.DataBind(); 

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
                DataLayer.ManageCategoryDL objManageContact = new DataLayer.ManageCategoryDL();
                DataTable dtCategory = objManageContact.GetAllCategories();
                return dtCategory;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void btnEditCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(this.Session["SelectedCategory"]) > 0)
                {
                    Response.Redirect("ManageCategory.aspx");
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Please select Category to update')", true);

                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                this.Session["SelectedCategory"] = 0;
                Response.Redirect("ManageCategory.aspx");

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void grdCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = grdCategory.SelectedRow;
                string CategoryID = row.Cells[1].Text;
                this.Session["SelectedCategory"] = CategoryID;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}