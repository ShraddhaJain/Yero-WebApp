using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yero
{
    public partial class ManageContactPhone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContact.aspx - Page_Load", null);
                if (!IsPostBack)
                {

                    //FillPhoneDataToForm(Convert.ToInt16(this.Session["SelectedPhone"]));
                }
                Audit.CustomLog(" End: ManageContact.aspx - Page_Load", null);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContact.aspx - Page_Load", null, true);
            }
          
        }


        /// <summary>
        /// Fills the contact data to form.
        /// </summary>
        /// <param name="PhoneID">The contact identifier.</param>
        //protected void FillPhoneDataToForm(int PhoneID)
        //{
        //    try
        //    {
        //        Audit.CustomLog(" Start: ManageContact.aspx - FillContactDataToForm", PhoneID);

        //        if (PhoneID > 0)
        //        {

        //            //----Show controls as per Update---//
        //            btnAddPhone.Visible = false;
        //            btnUpdatePhone.Visible = true;
        //            btnDeletePhone.Visible = true;

        //            lblPhoneId.Visible = true;
        //            lblPhoneIDValue.Visible = true;
                    
        //            //----//

        //            DataLayer.ManageContactPhoneDL objManagePhone = new DataLayer.ManageContactPhoneDL();
        //            BusinessObjects.Phone objPhone = objManagePhone.GetPhoneDetails(Convert.ToInt16(PhoneID));

        //            lblPhoneIDValue.Text = objPhone.Phone_id.ToString();
        //            txtPhoneArea.Text = objPhone.Phone_area;
        //            txtPhoneCountry.Text = objPhone.Phone_country;
        //            txtPhoneNumber.Text = objPhone.Phone_number;
        //            txtPhoneType.Text = objPhone.Phone_type;

        //        }
        //        else
        //        {
        //            //----Show controls as per Add---//
        //            btnAddPhone.Visible = true;
        //            btnUpdatePhone.Visible = false;
        //            btnDeletePhone.Visible = false;

        //            lblPhoneId.Visible = false;
        //            lblPhoneIDValue.Visible = false;
        //            lblPhoneIDValue.Text = "";
        //            //-------//
        //        }

        //        Audit.CustomLog(" End: ManageContact.aspx - FillContactDataToForm", PhoneID);
        //    }
        //    catch (Exception ex)
        //    {
        //        Audit.CustomError(ex, "ItivoError: ManageContact.aspx - FillContactDataToForm", PhoneID, false);
        //        throw;
        //    }

        //}

        /// <summary>
        /// Handles the Click event of the btnAddContactPhone control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnAddContactPhone_Click(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContact.aspx - btnAddContactPhone_Click", null);
                BusinessObjects.Phone objPhone = new BusinessObjects.Phone();
                this.Session["SelectedContact"] = 1;    ///Remove
                objPhone.Cont_id = Convert.ToInt16( this.Session["SelectedContact"]);
                objPhone.Phone_area = txtPhoneArea.Text.ToString();
                objPhone.Phone_country = txtPhoneCountry.Text.ToString();
                objPhone.Phone_number = txtPhoneNumber.Text.ToString();
                objPhone.Phone_type = txtPhoneType.Text.ToString();
                
                DataLayer.ManageContactPhoneDL objManagePhone = new DataLayer.ManageContactPhoneDL();
                bool bl = objManagePhone.CreatePhone(objPhone);

                this.Session["SelectedPhone"] = 0;
                this.Session["SelectedContact"] = 0;

                Audit.CustomLog(" End: ManageContact.aspx - btnAddContactPhone_Click", null);
                Response.Redirect("ViewContact.aspx");
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContact.aspx - btnAddContactPhone_Click", null, true);
            }
        }

        protected void btnUpdateContactPhone_Click(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContact.aspx - btnUpdateContactPhone_Click", null);

                BusinessObjects.Phone objPhone = new BusinessObjects.Phone();

                objPhone.Cont_id =Convert.ToInt16 (this.Session["SelectedContact"]);
                objPhone.Phone_id = Convert.ToInt16 (this.Session["SelectedPhone"]);
                objPhone.Phone_area = txtPhoneArea.Text;
                objPhone.Phone_country = txtPhoneCountry.Text;
                objPhone.Phone_number = txtPhoneNumber.Text;
                objPhone.Phone_type = txtPhoneType.Text;

                DataLayer.ManageContactPhoneDL objManagePhone = new DataLayer.ManageContactPhoneDL();
                bool result = objManagePhone.UpdatePhone(objPhone);
                this.Session["SelectedPhone"] = 0;
                this.Session["SelectedContact"] = 0;

                Audit.CustomLog(" End: ManageContact.aspx - btnUpdateContactPhone_Click", null);
                Response.Redirect("ViewContact.aspx");

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContact.aspx - btnUpdateContactPhone_Click", null, true);
            }
        }

        protected void btnDeleteContactPhone_Click(object sender, EventArgs e)
        {
            try
            {
                 Audit.CustomLog(" Start: ManageContact.aspx - btnDeleteContactPhone_Click", null);

                 BusinessObjects.Phone objPhone = new BusinessObjects.Phone();
                 objPhone.Cont_id = Convert.ToInt16(this.Session["SelectedContact"]);
                 objPhone.Phone_id = Convert.ToInt16(this.Session["SelectedPhone"]);

                 DataLayer.ManageContactPhoneDL objManagePhone = new DataLayer.ManageContactPhoneDL();
                 objManagePhone.DeletePhone(objPhone);
                 this.Session["SelectedPhone"] = 0;
                 this.Session["SelectedContact"] = 0;

                 Audit.CustomLog(" End: ManageContact.aspx - btnDeleteContactPhone_Click", null);
                 Response.Redirect("ViewContact.aspx");
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContact.aspx - btnDeleteContactPhone_Click", null, true);
            }
        }

    }
}