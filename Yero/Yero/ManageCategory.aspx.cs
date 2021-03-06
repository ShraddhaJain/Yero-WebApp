﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Yero
{
    public partial class ManageCategory : System.Web.UI.Page
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
                FillCategoryDataToForm(Convert.ToInt16(this.Session["SelectedCategory"]));           
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
                BusinessObjects.Category objCategory = new BusinessObjects.Category();

                objCategory.Categoryname = txtCategoryname.Text.ToString();
                objCategory.Description = txtCategorydesc.Text.ToString();

                DataLayer.ManageCategoryDL objManageCategoryDL = new DataLayer.ManageCategoryDL();
                bool result = objManageCategoryDL.CreateCategory(objCategory);

                this.Session["SelectedCategory"] = 0; //Remove categoryid from session
                Response.Redirect("ViewCategory.aspx");

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnUpdateCategory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessObjects.Category objCategory = new BusinessObjects.Category();

                objCategory.Categoryid =Convert.ToInt16( lblCategoryIdValue.Text);
                objCategory.Categoryname = txtCategoryname.Text.ToString();
                objCategory.Description = txtCategorydesc.Text.ToString();

                DataLayer.ManageCategoryDL objManageCategoryDL = new DataLayer.ManageCategoryDL();
                bool result = objManageCategoryDL.UpdateCategory(objCategory);

                this.Session["SelectedCategory"] = 0; //Remove categoryid from session
                Response.Redirect("ViewCategory.aspx");

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnDeleteCategory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessObjects.Category objCategory = new BusinessObjects.Category();

                objCategory.Categoryid = Convert.ToInt16(lblCategoryIdValue.Text);
                objCategory.Categoryname = txtCategoryname.Text.ToString();
                objCategory.Description = txtCategorydesc.Text.ToString();

                DataLayer.ManageCategoryDL objManageCategoryDL = new DataLayer.ManageCategoryDL();
                objManageCategoryDL.DeleteCategory(objCategory);

                this.Session["SelectedCategory"] = 0; //Remove categoryid from session
                Response.Redirect("ViewCategory.aspx");

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /// <summary>
        /// Fills the category data to form.
        /// </summary>
        /// <param name="CategoryId">The category identifier.</param>
        protected void FillCategoryDataToForm(int CategoryId)
        {
            try
            {
                if (CategoryId > 0)
                {
                    //----Show Controls as per update operation---//
                    btnAddCategory.Visible = false;
                    btnUpdateCategory.Visible = true;
                    btnDeleteCategory.Visible = true;

                    lblCategoryId.Visible = true;
                    lblCategoryIdValue.Visible = true;
                    lblCategoryIdValue.Text = CategoryId.ToString();
                    //----//

                    DataLayer.ManageCategoryDL objManageCategory = new DataLayer.ManageCategoryDL();
                    BusinessObjects.Category objCategory = objManageCategory.GetCategoryDetails(Convert.ToInt16(CategoryId));

                    txtCategoryname.Text = objCategory.Categoryname;
                    txtCategorydesc.Text = objCategory.Description;

                }
                else
                {
                    btnAddCategory.Visible = true;
                    btnUpdateCategory.Visible = false;
                    btnDeleteCategory.Visible = false;

                    lblCategoryId.Visible = false;
                    lblCategoryIdValue.Visible = false;
                    lblCategoryIdValue.Text = "";
                }

            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}