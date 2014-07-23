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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillContactDataToForm(Convert.ToInt16(this.Session["SelectedContact"]));
            }

        }

        protected void btnAddContact_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessObjects.Contact objContact = new BusinessObjects.Contact();

                objContact.Cont_f_name = txtFname.Text.ToString();
                objContact.Cont_l_name = txtLname.Text.ToString();
                objContact.Cont_m_name = txtMname.Text.ToString();
                objContact.Cont_email_id = txtEmail.Text.ToString();
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

                DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
                bool bl = objManageContact.CreateContact(objContact);

                this.Session["SelectedContact"] = 0; // Remove ContactID from session before view page
                Response.Redirect("ViewContact.aspx");
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void btnUpdateContact_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessObjects.Contact objContact = new BusinessObjects.Contact();

                objContact.Cont_id =Convert.ToInt16(lblContactIdValue.Text);
                objContact.Cont_f_name = txtFname.Text.ToString();
                objContact.Cont_l_name = txtLname.Text.ToString();
                objContact.Cont_m_name = txtMname.Text.ToString();
                objContact.Cont_email_id = txtEmail.Text.ToString();
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

                DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
                bool bl = objManageContact.UpdateContact(objContact);
                this.Session["SelectedContact"] = 0; // Remove ContactID from session after update
                Response.Redirect("ViewContact.aspx");
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        protected void FillContactDataToForm(int ContactID)
        {
            try
            {
                if (ContactID > 0)
                {

                    //----Show controls as per Update---//
                    btnAddContact.Visible = false;
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
                    btnAddContact.Visible = true;
                    btnUpdateContact.Visible = false;
                    btnDeleteContact.Visible = false;

                    lblContactId.Visible = false;
                    lblContactIdValue.Visible = false;
                    lblContactIdValue.Text = "";
                    //-------//
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        
        }

        protected void btnDeleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessObjects.Contact objContact = new BusinessObjects.Contact();
                objContact.Cont_id = Convert.ToInt16(lblContactIdValue.Text);

                DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
                objManageContact.DeleteContact(objContact);

                this.Session["SelectedContact"] = 0; //Remove contactid from sessoin after delete
                Response.Redirect("ViewContact.aspx");
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}