using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Yero
{
    public partial class ViewContactAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDropdowns();
                FillAddressDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
            }
        }

        protected void FillDropdowns()
        {
            try
            {
                Audit.CustomLog(" Start: ViewPhone.aspx - FillDropdowns", null);


                DataLayer.ManageLookupDL objManageLookUp = new DataLayer.ManageLookupDL();
                DataTable dtLookupPhone = objManageLookUp.GetLookupDetailValues("Address");

                if (dtLookupPhone.Rows.Count > 0)
                {
                    ddAddressType.DataSource = dtLookupPhone;
                    ddAddressType.DataTextField = dtLookupPhone.Columns["CODE_DT_NAME"].ToString();
                    ddAddressType.DataValueField = dtLookupPhone.Columns["CODE_DT_ID"].ToString();
                    ddAddressType.DataBind();
                }
                else
                {
                    ddAddressType.Visible = false;
                    lblAddressType.Visible = false;
                }

                Audit.CustomLog(" End: ViewPhone.aspx - FillDropdowns", null);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewPhone.aspx - FillDropdowns", null, false);
                throw;
            }
        }

        protected void FillAddressDataToForm(int ContactID)
        {
            try
            {
                Audit.CustomLog(" Start: ViewPhone.aspx - FillPhoneDataToForm", ContactID);

                DataLayer.ManageContactAddressDL objManageContactAddress = new DataLayer.ManageContactAddressDL();
                DataTable dtPhone = objManageContactAddress.GetAddressDetails(Convert.ToInt16(ContactID));

                if (dtPhone.Rows.Count > 0)
                {
                    lblNoAddressRecord.Visible = false;
                    grdAddress.Visible = true;
                    lblUpdateDeletemsg.Visible = true;

                    grdAddress.DataSource = dtPhone;
                    grdAddress.DataBind();
                }
                else
                {
                    grdAddress.Visible = false;
                    lblUpdateDeletemsg.Visible = false;
                    lblNoAddressRecord.Visible = true;
                }

                pnlEditAddress.Visible = false;
                InitializeEditAddressPanel();

                Audit.CustomLog(" End: ViewPhone.aspx - FillPhoneDataToForm", ContactID);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewPhone.aspx - FillPhoneDataToForm", ContactID, false);
                throw;
            }

        }

        protected void InitializeEditAddressPanel()
        {
            lblAddressID.Text = string.Empty;
            txtAddressAttention.Text = null;
            txtAddressInfo1.Text = string.Empty;
            txtAddressInfo2.Text = string.Empty;
            txtAddressLine1.Text = string.Empty;
            txtAddressLine2.Text = string.Empty;
            txtAddressLine3.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCounty.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtPostalStreet.Text = string.Empty;
            txtState.Text = string.Empty;
            ddAddressType.SelectedIndex = 0;
        }

        protected void btnAddAddress_Click(object sender, EventArgs e)
        {
            BusinessObjects.Address objAddress = new BusinessObjects.Address();
            objAddress.Cont_id = Convert.ToInt16(this.Session["SelectedContact"]);
            objAddress.Post_add_line_1 = String.IsNullOrWhiteSpace(txtAddressLine1.Text.TrimStart().TrimEnd()) ? null : txtAddressLine1.Text.TrimStart().TrimEnd();
            objAddress.Post_add_line_2 = String.IsNullOrWhiteSpace(txtAddressLine2.Text.TrimStart().TrimEnd()) ? null : txtAddressLine2.Text.TrimStart().TrimEnd();
            objAddress.Post_add_line_3 = String.IsNullOrWhiteSpace(txtAddressLine3.Text.TrimStart().TrimEnd()) ? null : txtAddressLine3.Text.TrimStart().TrimEnd();
            objAddress.Post_county = String.IsNullOrWhiteSpace(txtCounty.Text.TrimStart().TrimEnd()) ? null : txtCounty.Text.TrimStart().TrimEnd();
            objAddress.Post_add_info_1 = String.IsNullOrWhiteSpace(txtAddressInfo1.Text.TrimStart().TrimEnd()) ? null : txtAddressInfo1.Text.TrimStart().TrimEnd();
            objAddress.Post_add_info_2 = String.IsNullOrWhiteSpace(txtAddressInfo2.Text.TrimStart().TrimEnd()) ? null : txtAddressInfo2.Text.TrimStart().TrimEnd();
            objAddress.Post_add_attn = String.IsNullOrWhiteSpace(txtAddressAttention.Text.TrimStart().TrimEnd()) ? null : txtAddressAttention.Text.TrimStart().TrimEnd();
            objAddress.Post_add_po_street = String.IsNullOrWhiteSpace(txtPostalStreet.Text.TrimStart().TrimEnd()) ? null : txtPostalStreet.Text.TrimStart().TrimEnd();
            objAddress.Post_add_city = String.IsNullOrWhiteSpace(txtCity.Text.TrimStart().TrimEnd()) ? null : txtCity.Text.TrimStart().TrimEnd();
            objAddress.Post_add_state = String.IsNullOrWhiteSpace(txtState.Text.TrimStart().TrimEnd()) ? null : txtState.Text.TrimStart().TrimEnd();
            objAddress.Post_add_postal_code = String.IsNullOrWhiteSpace(txtPostalCode.Text.TrimStart().TrimEnd()) ? null : txtPostalCode.Text.TrimStart().TrimEnd();
            objAddress.Post_add_country = String.IsNullOrWhiteSpace(txtCountry.Text.TrimStart().TrimEnd()) ? null : txtCountry.Text.TrimStart().TrimEnd();
            objAddress.Post_add_type = ddAddressType.SelectedValue;

            DataLayer.ManageContactAddressDL objManageAddress = new DataLayer.ManageContactAddressDL();
            bool bl = objManageAddress.CreateAddress(objAddress);

            FillAddressDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
        
        }

        /// <summary>
        /// Handles the Click event of the btnUpdateAddress control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            BusinessObjects.Address objAddress = new BusinessObjects.Address();
            objAddress.Post_add_id = Convert.ToInt16(lblAddressID.Text);
            objAddress.Cont_id = Convert.ToInt16(this.Session["SelectedContact"]);
            objAddress.Post_add_line_1 = String.IsNullOrWhiteSpace(txtAddressLine1.Text.TrimStart().TrimEnd()) ? null : txtAddressLine1.Text.TrimStart().TrimEnd();
            objAddress.Post_add_line_2 = String.IsNullOrWhiteSpace(txtAddressLine2.Text.TrimStart().TrimEnd()) ? null : txtAddressLine2.Text.TrimStart().TrimEnd();
            objAddress.Post_add_line_3 = String.IsNullOrWhiteSpace(txtAddressLine3.Text.TrimStart().TrimEnd()) ? null : txtAddressLine3.Text.TrimStart().TrimEnd();
            objAddress.Post_county = String.IsNullOrWhiteSpace(txtCounty.Text.TrimStart().TrimEnd()) ? null : txtCounty.Text.TrimStart().TrimEnd();
            objAddress.Post_add_info_1 = String.IsNullOrWhiteSpace(txtAddressInfo1.Text.TrimStart().TrimEnd()) ? null : txtAddressInfo1.Text.TrimStart().TrimEnd();
            objAddress.Post_add_info_2 = String.IsNullOrWhiteSpace(txtAddressInfo2.Text.TrimStart().TrimEnd()) ? null : txtAddressInfo2.Text.TrimStart().TrimEnd();
            objAddress.Post_add_attn = String.IsNullOrWhiteSpace(txtAddressAttention.Text.TrimStart().TrimEnd()) ? null : txtAddressAttention.Text.TrimStart().TrimEnd();
            objAddress.Post_add_po_street = String.IsNullOrWhiteSpace(txtPostalStreet.Text.TrimStart().TrimEnd()) ? null : txtPostalStreet.Text.TrimStart().TrimEnd();
            objAddress.Post_add_city = String.IsNullOrWhiteSpace(txtCity.Text.TrimStart().TrimEnd()) ? null : txtCity.Text.TrimStart().TrimEnd();
            objAddress.Post_add_state = String.IsNullOrWhiteSpace(txtState.Text.TrimStart().TrimEnd()) ? null : txtState.Text.TrimStart().TrimEnd();
            objAddress.Post_add_postal_code = String.IsNullOrWhiteSpace(txtPostalCode.Text.TrimStart().TrimEnd()) ? null : txtPostalCode.Text.TrimStart().TrimEnd();
            objAddress.Post_add_country = String.IsNullOrWhiteSpace(txtCountry.Text.TrimStart().TrimEnd()) ? null : txtCountry.Text.TrimStart().TrimEnd();
            objAddress.Post_add_type = ddAddressType.SelectedValue;

            DataLayer.ManageContactAddressDL objManageAddress = new DataLayer.ManageContactAddressDL();
            bool bl = objManageAddress.UpdateAddress(objAddress);

            FillAddressDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
        
        }

        protected void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            BusinessObjects.Address objAddress = new BusinessObjects.Address();
            objAddress.Cont_id = Convert.ToInt16(this.Session["SelectedContact"]);
            objAddress.Post_add_id = Convert.ToInt16(lblAddressID.Text);

            DataLayer.ManageContactAddressDL objManageAddress = new DataLayer.ManageContactAddressDL();
             objManageAddress.DeleteAddress(objAddress);

            FillAddressDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
        
        }

        protected void btnAddNewAddress_Click(object sender, EventArgs e)
        {
            pnlEditAddress.Visible = true;
            InitializeEditAddressPanel();

            btnUpdateAddress.Visible = false;
            btnDeleteAddress.Visible = false;
            btnAddAddress.Visible = true;
        }

        protected void grdAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEditAddress.Visible = true;
            InitializeEditAddressPanel();
            btnUpdateAddress.Visible = true;
            btnDeleteAddress.Visible = true;
            btnAddAddress.Visible = false;

            GridViewRow row = grdAddress.SelectedRow;

            lblAddressID.Text = row.Cells[1].Text;
            txtAddressLine1.Text = row.Cells[3].Text;
            txtAddressLine2.Text = row.Cells[4].Text;
            txtAddressLine3.Text = row.Cells[5].Text;
            txtCounty.Text = row.Cells[6].Text;
            txtAddressInfo1.Text = row.Cells[7].Text;
            txtAddressInfo2.Text = row.Cells[8].Text;
            txtAddressAttention.Text = row.Cells[9].Text;
            txtPostalStreet.Text = row.Cells[10].Text;
            txtCity.Text = row.Cells[11].Text;
            txtState.Text = row.Cells[12].Text;
            txtPostalCode.Text = row.Cells[13].Text;
            txtCountry.Text = row.Cells[14].Text;
            ddAddressType.SelectedValue = ((HiddenField)row.Cells[7].FindControl("POST_ADD_TYPE")).Value;
            
        }
    }
}