using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Yero.Models;

namespace Yero.Account
{
    public partial class Register : Page
    {
        /// <summary>
        /// Handles the Click event of the CreateUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            //var manager = new UserManager();
            //var user = new ApplicationUser() { UserName = UserName.Text };
            //IdentityResult result = manager.Create(user, Password.Text);
            //if (result.Succeeded)
            //{
            //    IdentityHelper.SignIn(manager, user, isPersistent: false);
            //    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            //}
            //else 
            //{
            //    ErrorMessage.Text = result.Errors.FirstOrDefault();
            //}

            try
            {
                Audit.CustomLog(" Start: Register.aspx - CreateUser_Click", null);
                BusinessObjects.Contact objContact = new BusinessObjects.Contact();

                objContact.UserName = txtUserName.Text.ToString().ToUpper();
                //objContact.Password = BusinessObjects.Encryption.EncryptText(txtPassword.Text.ToString());
                objContact.Password = txtPassword.Text.ToString();
                objContact.Cont_email_id = txtEmail.Text.ToString();
                objContact.SecurityQuestion = txtSecurityQuestion.Text.ToString().ToUpper();
                objContact.SecurityAnswer = txtSecurityAnswer.Text.ToString().ToUpper();

                DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
                bool bl = objManageContact.CreateContact(objContact);

                Audit.CustomLog(" End: Register.aspx - CreateUser_Click", null);
                Response.Redirect("~/Login.aspx",true);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: Register.aspx - CreateUser_Click", null, true);
            }
        }
    }
}