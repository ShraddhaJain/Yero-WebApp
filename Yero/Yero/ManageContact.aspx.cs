using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Yero 
{
    public partial class Contact : Page
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
                Audit.CustomLog(" Start: ManageContact.aspx - Page_Load", null);
                if (!IsPostBack)
                {
                  
                    FillContactDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
                    //FillAddressDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
                    //FillPhoneDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));

                }
                Audit.CustomLog(" End: ManageContact.aspx - Page_Load", null);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContact.aspx - Page_Load", null,true);
            }
          
        }



        /// <summary>
        /// Fills the contact data to form.
        /// </summary>
        /// <param name="ContactID">The contact identifier.</param>
        protected void FillContactDataToForm(int ContactID)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContact.aspx - FillContactDataToForm", ContactID);

                if (ContactID > 0)
                {

                    //----Show controls as per Update---//
                   // btnAddContact.Visible = false;
                    btnUpdateContact.Visible = true;
                    btnDeleteContact.Visible = true;

                    lblContactId.Visible = true;
                    lblContactIdValue.Visible = true;
                    lblContactIdValue.Text = ContactID.ToString();
                    //----//

                    DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
                    BusinessObjects.Contact objContact = objManageContact.GetContactDetails(Convert.ToInt16(ContactID));

                    txtFname.Text = objContact.Cont_f_name;
                    txtLname.Text = objContact.Cont_l_name;
                    txtMname.Text = objContact.Cont_m_name;
                    txtEmail.Text = objContact.Cont_email_id;
                    txtUserName.Text = objContact.UserName;
                    txtPassword.Text = objContact.Password;
                    txtSecurityQue.Text = objContact.SecurityQuestion;
                    txtSecurityAns.Text = objContact.SecurityAnswer;
                    txtOrderNo.Text = objContact.Cont_order_no.ToString();
                    txtSkypeId.Text = objContact.Skype_id;
                    txtFacebookId.Text = objContact.Facebook_id;
                    txtLinkedinId.Text = objContact.Linkedin_id;
                    txtTwitterId.Text = objContact.Twitter_id;
                    txtGoogleplusId.Text = objContact.Googleplus_id;
                    txtLink1Id.Text = objContact.Link1_id;
                    txtLink2Id.Text = objContact.Link2_id;
                    txtLink3Id.Text = objContact.Link3_id;
                    txtBlogId.Text = objContact.Blog_id;
                    txtWebsiteUrl.Text = objContact.Website_url;

                }
                else
                {
                    //----Show controls as per Add---//
                    //btnAddContact.Visible = true;
                    btnUpdateContact.Visible = false;
                    btnDeleteContact.Visible = false;

                    lblContactId.Visible = false;
                    lblContactIdValue.Visible = false;
                    lblContactIdValue.Text = "";
                    //-------//
                }

                Audit.CustomLog(" End: ManageContact.aspx - FillContactDataToForm", ContactID);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContact.aspx - FillContactDataToForm", ContactID, false);
                throw;
            }

        }

        ///// <summary>
        ///// Fills the address data to form.
        ///// </summary>
        ///// <param name="ContactID">The contact identifier.</param>
        //protected void FillAddressDataToForm(int ContactID)
        //{
        //    try
        //    {
        //        Audit.CustomLog(" Start: ManageContact.aspx - FillAddressDataToForm", ContactID);
        //        DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
        //        DataTable tblAddress = objManageContact.GetAddressDetails(Convert.ToInt16(ContactID));

        //        if (tblAddress.Rows.Count > 0)
        //        {
        //            foreach (DataRow row in tblAddress.Rows)
        //            {
        //                int AddressType =Convert.ToInt16(row["POST_ADD_TYPE"]);
        //                if (AddressType == 3) //Residential Address
        //                {
        //                    lblRAAddressID.Text = row["POST_ADD_ID"].ToString();
        //                    txtRAAddressLine1.Text = row["POST_ADD_LINE_1"].ToString();
        //                    txtRAAddressLine2.Text = row["POST_ADD_LINE_2"].ToString();
        //                    txtRAAddressLine3.Text = row["POST_ADD_LINE_3"].ToString();
        //                    txtRACounty.Text = row["POST_COUNTY"].ToString();
        //                    txtRAAddressInfo1.Text = row["POST_ADD_INFO_1"].ToString();
        //                    txtRAAddressInfo2.Text = row["POST_ADD_INFO_2"].ToString();
        //                    txtRAAddressAttention.Text = row["POST_ADD_ATTN"].ToString();
        //                    txtRAPostalStreet.Text = row["POST_ADD_PO_STREET"].ToString();
        //                    txtRACity.Text = row["POST_ADD_CITY"].ToString();
        //                    txtRAState.Text = row["POST_ADD_STATE"].ToString();
        //                    txtRAPostalCode.Text = row["POST_ADD_POSTAL_CODE"].ToString();
        //                    txtRACountry.Text = row["POST_ADD_COUNTRY"].ToString();
        //                }
        //                else if(AddressType==4) //Postal Address
        //                {
        //                    lblPAAddressID.Text = row["POST_ADD_ID"].ToString();
        //                    txtPAAddressLine1.Text = row["POST_ADD_LINE_1"].ToString();
        //                    txtPAAddressLine2.Text = row["POST_ADD_LINE_2"].ToString();
        //                    txtPAAddressLine3.Text = row["POST_ADD_LINE_3"].ToString();
        //                    txtPACounty.Text = row["POST_COUNTY"].ToString();
        //                    txtPAAddressInfo1.Text = row["POST_ADD_INFO_1"].ToString();
        //                    txtPAAddressInfo2.Text = row["POST_ADD_INFO_2"].ToString();
        //                    txtPAAddressAttention.Text = row["POST_ADD_ATTN"].ToString();
        //                    txtPAPostalStreet.Text = row["POST_ADD_PO_STREET"].ToString();
        //                    txtPACity.Text = row["POST_ADD_CITY"].ToString();
        //                    txtPAState.Text = row["POST_ADD_STATE"].ToString();
        //                    txtPAPostalCode.Text = row["POST_ADD_POSTAL_CODE"].ToString();
        //                    txtPACountry.Text = row["POST_ADD_COUNTRY"].ToString();
        //                }
                        
        //            }
        //        }

        //        Audit.CustomLog(" End: ManageContact.aspx - FillAddressDataToForm", ContactID);
        //    }
        //    catch (Exception ex)
        //    {
        //        Audit.CustomError(ex, "ItivoError: ManageContact.aspx - FillAddressDataToForm", ContactID, false);
        //        throw;
        //    }

        //}

        /// <summary>
        /// Fills the phone data to form.
        /// </summary>
        /// <param name="ContactID">The contact identifier.</param>
        //protected void FillPhoneDataToForm(int ContactID)
        //{
        //    try
        //    {
        //        Audit.CustomLog(" Start: ManageContact.aspx - FillPhoneDataToForm", ContactID);

        //        DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
        //        DataTable dtPhone = objManageContact.GetPhoneDetails(Convert.ToInt16(ContactID));

        //        if (dtPhone.Rows.Count > 0)
        //        {
        //            foreach (DataRow row in dtPhone.Rows)
        //            {
        //                int PhoneType = Convert.ToInt16( row["PHONE_TYPE"]);
        //                if(PhoneType == 1) //Home Phone
        //                {
        //                    lblHomePhoneID.Text = row["PHONE_ID"].ToString();
        //                    txtHPPhoneCountry.Text = row["PHONE_COUNTRY"].ToString();
        //                    txtHPPhoneArea.Text = row["PHONE_AREA"].ToString();
        //                    txtHPPhoneNumber.Text = row["PHONE_NUMBER"].ToString();
        //                }
        //                else if(PhoneType == 2)  //Office Phone
        //                {
        //                    lblOfficePhoneID.Text = row["PHONE_ID"].ToString();
        //                    txtOPPhoneCountry.Text = row["PHONE_COUNTRY"].ToString();
        //                    txtOPPhoneArea.Text = row["PHONE_AREA"].ToString();
        //                    txtOPPhoneNumber.Text = row["PHONE_NUMBER"].ToString();
        //                }
        //                else if (PhoneType == 6)  //Mobile
        //                {
        //                    lblMobilePhoneID.Text = row["PHONE_ID"].ToString();
        //                    txtMPPhoneCountry.Text = row["PHONE_COUNTRY"].ToString();
        //                    txtMPPhoneArea.Text = row["PHONE_AREA"].ToString();
        //                    txtMPPhoneNumber.Text = row["PHONE_NUMBER"].ToString();
        //                }

        //            }
        //        }

        //        Audit.CustomLog(" End: ManageContact.aspx - FillPhoneDataToForm", ContactID);
        //    }
        //    catch (Exception ex)
        //    {
        //        Audit.CustomError(ex, "ItivoError: ManageContact.aspx - FillPhoneDataToForm", ContactID, false);
        //        throw;
        //    }

        //}


        /// <summary>
        /// Handles the Click event of the btnUpdateContact control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnUpdateContact_Click(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContact.aspx - btnUpdateContact_Click", null);
                
                BusinessObjects.Contact objContact = new BusinessObjects.Contact();
                objContact.Cont_id =Convert.ToInt16(lblContactIdValue.Text);
                objContact.Cont_f_name = txtFname.Text.ToString();
                objContact.Cont_l_name = txtLname.Text.ToString();
                objContact.Cont_m_name = txtMname.Text.ToString();
                objContact.Cont_email_id = txtEmail.Text.ToString();
                objContact.UserName = txtUserName.Text.ToString();
                objContact.Password = txtPassword.Text.ToString();
                objContact.SecurityQuestion = txtSecurityQue.Text.ToString();
                objContact.SecurityAnswer = txtSecurityAns.Text.ToString();
                objContact.Cont_order_no = Convert.ToInt32(txtOrderNo.Text);
                objContact.Skype_id = txtSkypeId.Text.ToString();
                objContact.Facebook_id = txtFacebookId.Text.ToString();
                objContact.Linkedin_id = txtLinkedinId.Text.ToString();
                objContact.Twitter_id = txtTwitterId.Text.ToString();
                objContact.Googleplus_id = txtGoogleplusId.Text.ToString();
                objContact.Link1_id = txtLink1Id.Text.ToString();
                objContact.Link2_id = txtLink2Id.Text.ToString();
                objContact.Link3_id = txtLink3Id.Text.ToString();
                objContact.Blog_id = txtBlogId.Text.ToString();
                objContact.Website_url = txtWebsiteUrl.Text.ToString();

/*
                List<BusinessObjects.Address> lstAddress = new List<BusinessObjects.Address>();
                if (lblRAAddressID.Text != "")
                {
                    BusinessObjects.Address objRAAddress = new BusinessObjects.Address();
                    objRAAddress.Post_add_id = Convert.ToInt16(lblRAAddressID.Text);
                    objRAAddress.Cont_id = Convert.ToInt16(lblContactIdValue.Text);
                    objRAAddress.Post_add_line_1 = txtRAAddressLine1.Text.Trim();
                    objRAAddress.Post_add_line_2 = txtRAAddressLine2.Text.Trim();
                    objRAAddress.Post_add_line_3 = txtRAAddressLine3.Text.Trim();
                    objRAAddress.Post_county = txtRACounty.Text.Trim();
                    objRAAddress.Post_add_info_1 = txtRAAddressInfo1.Text.Trim();
                    objRAAddress.Post_add_info_2 = txtRAAddressInfo2.Text.Trim();
                    objRAAddress.Post_add_attn = txtRAAddressAttention.Text.Trim();
                    objRAAddress.Post_add_po_street = txtRAPostalStreet.Text.Trim();
                    objRAAddress.Post_add_city = txtRACity.Text.Trim();
                    objRAAddress.Post_add_state = txtRAState.Text.Trim();
                    objRAAddress.Post_add_postal_code = txtRAPostalCode.Text.Trim();
                    objRAAddress.Post_add_country = txtRACountry.Text.Trim();
                    lstAddress.Add(objRAAddress);
                }

                if (lblPAAddressID.Text != "")
                {
                    BusinessObjects.Address objPAAddress = new BusinessObjects.Address();
                    objPAAddress.Post_add_id = Convert.ToInt16(lblPAAddressID.Text);
                    objPAAddress.Cont_id = Convert.ToInt16(lblContactIdValue.Text);
                    objPAAddress.Post_add_line_1 = txtPAAddressLine1.Text.Trim();
                    objPAAddress.Post_add_line_2 = txtPAAddressLine2.Text.Trim();
                    objPAAddress.Post_add_line_3 = txtPAAddressLine3.Text.Trim();
                    objPAAddress.Post_county = txtPACounty.Text.Trim();
                    objPAAddress.Post_add_info_1 = txtPAAddressInfo1.Text.Trim();
                    objPAAddress.Post_add_info_2 = txtPAAddressInfo2.Text.Trim();
                    objPAAddress.Post_add_attn = txtPAAddressAttention.Text.Trim();
                    objPAAddress.Post_add_po_street = txtPAPostalStreet.Text.Trim();
                    objPAAddress.Post_add_city = txtPACity.Text.Trim();
                    objPAAddress.Post_add_state = txtPAState.Text.Trim();
                    objPAAddress.Post_add_postal_code = txtPAPostalCode.Text.Trim();
                    objPAAddress.Post_add_country = txtPACountry.Text.Trim();
                    lstAddress.Add(objPAAddress);
                }


                BusinessObjects.Phone objPhone = new BusinessObjects.Phone();
                objPhone.Cont_id = Convert.ToInt16(lblContactIdValue.Text);
                objPhone.Phone_id = Convert.ToInt16(lblMobilePhoneID.Text);
                objPhone.Phone_area = txtMPPhoneArea.Text;
                objPhone.Phone_country = txtMPPhoneCountry.Text;
                objPhone.Phone_number = txtMPPhoneNumber.Text;
                //objPhone.Phone_type = txtPhoneType.Text;
                //objPhone.Phone_type = ddPhoneType.SelectedValue;
                */
                DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
                bool bl = objManageContact.UpdateContactProfile(objContact);

                this.Session["SelectedContact"] = 0; // Remove ContactID from session after update

                Audit.CustomLog(" End: ManageContact.aspx - btnUpdateContact_Click", null);
                Response.Redirect("~/ViewContact.aspx",false);

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContact.aspx - btnUpdateContact_Click", null,true);
            }
            
        }

        /// <summary>
        /// Handles the Click event of the btnDeleteContact control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected void btnDeleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ManageContact.aspx - btnDeleteContact_Click", null);

                BusinessObjects.Contact objContact = new BusinessObjects.Contact();
                objContact.Cont_id = Convert.ToInt16(lblContactIdValue.Text);

                DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
                objManageContact.DeleteContact(objContact);

                this.Session["SelectedContact"] = 0; //Remove contactid from sessoin after delete

                Audit.CustomLog(" End: ManageContact.aspx - btnDeleteContact_Click", null);
                Response.Redirect("ViewContact.aspx");

            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageContact.aspx - btnDeleteContact_Click", null,true);
            }
            
        }

        protected void btnManageAddress_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewContactAddress.aspx", false);
        }

        protected void btnManagePhone_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewPhone.aspx", false);
        }

       

    }
}