using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Yero
{
    public partial class SearchOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ContactSearch.aspx - btnSearch_Click", null);

                DataLayer.ManageOrderDL objManageSearchContact = new DataLayer.ManageOrderDL();
                DataTable dtOrder = objManageSearchContact.SearchOrder(txtOrderStatus.Text.Trim(), txtOrderNumber.Text.Trim(), txtOrderDate.Text.Trim(), txtCustomerName.Text.Trim());

                grdSearchResult.DataSource = dtOrder;
                grdSearchResult.DataBind();


                Audit.CustomLog(" End: ContactSearch.aspx - btnSearch_Click", null);


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}