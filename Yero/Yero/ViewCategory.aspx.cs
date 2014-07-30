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
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                { 
                 PopulateCategoryTree();
                }
               
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


        /// <summary>
        /// Populates the category tree.
        /// </summary>
        private void PopulateCategoryTree()
        {
            DataTable dt = new DataTable();
            DataLayer.ManageCategoryDL objManageContact = new DataLayer.ManageCategoryDL();
            dt = objManageContact.GetAllCategories();

            CreateTreeViewDataTable(dt, 0, null);
        }

        /// <summary>
        /// Creates the TreeView data table.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <param name="parentID">The parent identifier.</param>
        /// <param name="parentNode">The parent node.</param>
        private void CreateTreeViewDataTable(DataTable dt, int parentID, TreeNode parentNode)
        {
            DataRow[] drs = dt.Select("CategoryParentID = " + parentID.ToString());
            foreach (DataRow i in drs)
            {
                TreeNode newNode = new TreeNode(i["categoryname"].ToString(), i["CategoryID"].ToString());
                if (parentNode == null)
                {
                    TVCategory.Nodes.Add(newNode);
                }
                else
                {
                    parentNode.ChildNodes.Add(newNode);
                }
                CreateTreeViewDataTable(dt, Convert.ToInt32(i["CategoryID"]), newNode);
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
                DataLayer.ManageCategoryDL objManageContact = new DataLayer.ManageCategoryDL();
                DataTable dtCategory = objManageContact.GetAllCategories();
                return dtCategory;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnEditCategory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btnAddCategory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the SelectedIndexChanged event of the grdCategory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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