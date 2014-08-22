using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Yero.BusinessObjects;

namespace Yero
{
    public partial class ViewPhone : System.Web.UI.Page
    {
        Cache objCache = new Cache("mycache");
        private static object _cacheLock = new object();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDropdowns();
                FillPhoneDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
            }
        }

        protected void FillDropdowns()
        {
            try
            {
                Audit.CustomLog(" Start: ViewPhone.aspx - FillDropdowns", null);


                DataLayer.ManageLookupDL objManageLookUp = new DataLayer.ManageLookupDL();

                DataTable dtLookupPhone = (DataTable)objCache.getCache("PhoneLkUp");

                if (dtLookupPhone == null)
                {
                    // lock this section of the code while we populate this.
                    lock (_cacheLock)
                    {
                        // only populate if this was not populated by another thread while this thread was waiting
                        dtLookupPhone = (DataTable)objCache.getCache("PhoneLkUp");
                        if (dtLookupPhone == null)
                        {
                            dtLookupPhone = objManageLookUp.GetLookupDetailValues("phone");
                            bool boolPhone = objCache.setCache(dtLookupPhone, "PhoneLkUp");
                            if (boolPhone == false)
                                Audit.CustomLog(" WARNING: ManageContact.aspx - PhoneLkUp - Cache is not setting", dtLookupPhone);
                        }
                    }
                }




                //DataTable dtLookupPhone = objManageLookUp.GetLookupDetailValues("Phone");

                if (dtLookupPhone.Rows.Count > 0)
                {
                    ddPhoneType.DataSource = dtLookupPhone;
                    ddPhoneType.DataTextField = dtLookupPhone.Columns["CODE_DT_NAME"].ToString();
                    ddPhoneType.DataValueField = dtLookupPhone.Columns["CODE_DT_ID"].ToString();
                    ddPhoneType.DataBind();
                }
                else
                {
                    ddPhoneType.Visible = false;
                    lblPhoneType.Visible = false;
                }

                Audit.CustomLog(" End: ViewPhone.aspx - FillDropdowns", null);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewPhone.aspx - FillDropdowns", null, false);
                throw;
            } 
        }

        protected void FillPhoneDataToForm(int ContactID)
        {
            try
            {
                Audit.CustomLog(" Start: ViewPhone.aspx - FillPhoneDataToForm", ContactID);

                DataLayer.ManageContactPhoneDL objManageContact = new DataLayer.ManageContactPhoneDL();
                DataTable dtPhone = objManageContact.GetPhoneDetails(Convert.ToInt16(ContactID));
                
                if (dtPhone.Rows.Count > 0)
                {
                    lblNoPhoneRecord.Visible = false;
                    grdPhone.Visible = true;
                    lblUpdateDeletemsg.Visible = true;

                    grdPhone.DataSource = dtPhone;
                    grdPhone.DataBind();
                }
                else
                {
                    grdPhone.Visible = false;
                    lblUpdateDeletemsg.Visible = false;
                    lblNoPhoneRecord.Visible = true;
                }

                pnlEditPhone.Visible = false;
                InitializeEditPhonePanel();

                Audit.CustomLog(" End: ViewPhone.aspx - FillPhoneDataToForm", ContactID);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ViewPhone.aspx - FillPhoneDataToForm", ContactID, false);
                throw;
            }

        }

        protected void grdPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEditPhone.Visible = true;
            InitializeEditPhonePanel();
            btnUpdatePhone.Visible = true;
            btnDeletePhone.Visible = true;
            btnAddPhone.Visible = false;

            GridViewRow row = grdPhone.SelectedRow;
            
            lblPhoneID.Text = row.Cells[1].Text;
            txtPhoneCountry.Text = row.Cells[4].Text;
            txtPhoneArea.Text = row.Cells[5].Text;
            txtPhoneNumber.Text = row.Cells[6].Text;
            ddPhoneType.SelectedValue = ((HiddenField)row.Cells[7].FindControl("PHONE_TYPE")).Value;
            
        }
      
        protected void btnUpdatePhone_Click(object sender, EventArgs e)
        {
              BusinessObjects.Phone objPhone = new BusinessObjects.Phone();
                objPhone.Cont_id = Convert.ToInt16(this.Session["SelectedContact"]);
                objPhone.Phone_id = Convert.ToInt16(lblPhoneID.Text);
                objPhone.Phone_area = txtPhoneArea.Text;
                objPhone.Phone_country = txtPhoneCountry.Text;
                objPhone.Phone_number = txtPhoneNumber.Text;
                objPhone.Phone_type = ddPhoneType.SelectedValue;

            DataLayer.ManageContactPhoneDL objManageContact = new DataLayer.ManageContactPhoneDL();
            bool bl = objManageContact.UpdatePhone(objPhone);

            FillPhoneDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
        }


        protected void btnAddPhone_Click(object sender, EventArgs e)
        {

            BusinessObjects.Phone objPhone = new BusinessObjects.Phone();
            objPhone.Cont_id = Convert.ToInt16(this.Session["SelectedContact"]);
            objPhone.Phone_area = txtPhoneArea.Text;
            objPhone.Phone_country = txtPhoneCountry.Text;
            objPhone.Phone_number = txtPhoneNumber.Text;
            objPhone.Phone_type = ddPhoneType.SelectedValue;

            DataLayer.ManageContactPhoneDL objManageContact = new DataLayer.ManageContactPhoneDL();
            bool bl = objManageContact.CreatePhone(objPhone);

            FillPhoneDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
        
        }

        protected void btnDeletePhone_Click(object sender, EventArgs e)
        {

            BusinessObjects.Phone objPhone = new BusinessObjects.Phone();
            objPhone.Cont_id = Convert.ToInt16(this.Session["SelectedContact"]);
            objPhone.Phone_id = Convert.ToInt16(lblPhoneID.Text);
            objPhone.Phone_area = txtPhoneArea.Text;
            objPhone.Phone_country = txtPhoneCountry.Text;
            objPhone.Phone_number = txtPhoneNumber.Text;
            objPhone.Phone_type = ddPhoneType.SelectedValue;

            DataLayer.ManageContactPhoneDL objManageContact = new DataLayer.ManageContactPhoneDL();
            objManageContact.DeletePhone(objPhone);

            FillPhoneDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
        
        }

        protected void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            pnlEditPhone.Visible = true;
            InitializeEditPhonePanel();

            btnUpdatePhone.Visible = false;
            btnDeletePhone.Visible = false;
            btnAddPhone.Visible = true;
        }

        protected void InitializeEditPhonePanel()
        {
            lblPhoneID.Text = string.Empty;
            txtPhoneCountry.Text = string.Empty;
            txtPhoneArea.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            ddPhoneType.SelectedIndex = 0;
        }

       
    }
}