using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using Yero.Models;

namespace Yero.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        /// <summary>
        /// Logs the in.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                //// Validate the user password
                //var manager = new UserManager();
                //ApplicationUser user = manager.Find(UserName.Text, Password.Text);
                //if (user != null)
                //{
                //    IdentityHelper.SignIn(manager, user, RememberMe.Checked);
                //    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                //}
                //else
                //{
                //    FailureText.Text = "Invalid username or password.";
                //    ErrorMessage.Visible = true;
                //}

                DataLayer.ManageContactDL objManageContact = new DataLayer.ManageContactDL();
                DataTable dtUser = objManageContact.ValidateUser(UserName.Text, Password.Text);

                if (dtUser.Rows.Count > 0)
                {
                    string password = BusinessObjects.Encryption.DecryptText(dtUser.Rows[0]["password"].ToString());

                    if (password == Password.Text.Trim())
                    {
                        if (dtUser.Rows[0]["active"].ToString() == "ACT")
                        {
                            //Login successful
                            this.Session["LoggedInUserContactID"] = dtUser.Rows[0]["cont_id"].ToString(); //Add contact ID to session
                            Response.Redirect("~/Welcome.aspx");
                        }
                        else
                        { 
                            FailureText.Text = "User is Inactive. Please contact site administrator.";
                            ErrorMessage.Visible = true;
                        }
                    }
                    else 
                        {
                            FailureText.Text = "Invalid password.";
                            ErrorMessage.Visible = true;
                        }
                    
                }
                else
                {
                    FailureText.Text = "Invalid username.";
                    ErrorMessage.Visible = true;
                }
            }
        }
    }
}