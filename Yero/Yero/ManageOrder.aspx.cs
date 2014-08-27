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
        static int OrderId ;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitializePage();
                OrderId = 0;
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
                    ddProducts.DataValueField = dtProducts.Columns["ProductID"].ToString();
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
            //1. Create New Order in db 

            BusinessObjects.orders objOrder = new BusinessObjects.orders();
            
            // Hardcoding values for testing
            objOrder.Payment_id = 1;
            objOrder.Customer_id = 1;
            objOrder.ORDER_Status = "Pending";

            if (OrderId == 0)
            {
                DataLayer.ManageOrderDL objCreateOrder = new DataLayer.ManageOrderDL();
                DataTable dtOrder = objCreateOrder.CreateOrder(objOrder);
                OrderId = Convert.ToInt16(dtOrder.Rows[0]["ORDER_ID"]);
                // Bind order grid with new created order
                grdOrder.DataSource = dtOrder;
                grdOrder.DataBind();
            }
            
            //2. Create new OrderDetails in db 
            BusinessObjects.Order_Details objOrderDetails = new BusinessObjects.Order_Details();
            objOrderDetails.Product_id =Convert.ToInt16(ddProducts.SelectedValue);
            objOrderDetails.Quantity =Convert.ToInt16(txtQuantity.Text);
            objOrderDetails.Order_id = OrderId;


            DataLayer.ManageOrderDL objCreateOrderDetails = new DataLayer.ManageOrderDL();
             objCreateOrderDetails.CreateOrderDetails(objOrderDetails);

            //2. Bring back new order details to gridOrderDetails

            DataLayer.ManageOrderDL objGetOrderDetails = new DataLayer.ManageOrderDL();
            DataTable dtGetOrderDetails = objGetOrderDetails.GetOrderDetails(OrderId);
            grdOrderDetails.DataSource = dtGetOrderDetails;
            grdOrderDetails.DataBind();

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