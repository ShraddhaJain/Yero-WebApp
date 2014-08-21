using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Yero
{
    public partial class ManageOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitializePage();
            }
            
        }

        protected void InitializePage()
        {
            pnlProductSearch.Visible = true;
            pnlOrderDetails.Visible = false;
            pnlManageOrder.Visible = false;
            lblNoProducts.Visible = false;
        }

        protected void btnSearchProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Audit.CustomLog(" Start: ManageOrder.aspx - btnSearchProduct_Click", null);

                DataLayer.ManageOrderDL objSearchProduct = new DataLayer.ManageOrderDL();
                DataTable dtProducts = objSearchProduct.GetProductSearchResult(txtProductName.Text.Trim());

                if (dtProducts.Rows.Count > 0)
                {
                    pnlManageOrder.Visible = true;
                    grdProduct.Visible = true;
                    lblNoProducts.Visible = false;
                    pnlOrderDetails.Visible = true;
                    
                    ///BindDropdown and grid with the data
                    grdProduct.DataSource = dtProducts;
                    grdProduct.DataBind();

                    ddProducts.DataSource = dtProducts;
                    ddProducts.DataTextField = dtProducts.Columns["ProductDescription"].ToString();
                    ddProducts.DataValueField = dtProducts.Columns["Cost"].ToString();
                    ddProducts.DataBind();
                }
                else
                {
                    grdProduct.Visible = false;
                    lblNoProducts.Visible = true;
                    lblNoProducts.Text = "No Products with Name :: " + txtProductName.Text;
                    pnlManageOrder.Visible = false;
                    pnlOrderDetails.Visible = false;
                }

                Audit.CustomLog(" End: ManageOrder.aspx - btnSearchProduct_Click", null);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: ManageOrder.aspx - btnSearchProduct_Click", null, true);
                
            }
        }

        protected void btnAddToOrder_Click(object sender, EventArgs e)
        {
            //1. New Order in db Order and OrderDetails table 
            //2. Bring back new order details to gridOrderDetails
            //3. Calculate the total Amount and show in lblTotalAmount
            decimal ProductCost =Convert.ToDecimal( ddProducts.SelectedValue);
            int Quantity =Convert.ToInt32( txtQuantity.Text);

            if (lblTotalAmount.Text == "")
            {
                lblTotalAmount.Text = (ProductCost * Quantity).ToString();
            }
            else
            {
                decimal TotalAmount = Convert.ToDecimal(lblTotalAmount.Text);
                lblTotalAmount.Text = ((ProductCost * Quantity) + TotalAmount).ToString();
            }
        }
    }
}