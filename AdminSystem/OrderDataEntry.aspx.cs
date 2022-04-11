using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the order number for this entry
        Response.Write(AnOrder.OrderID);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order number
        string OrderID = txtOrderID.Text;
        //capture the order search
        string OrderSearch = txtOrderSearch.Text;
        //capture the order delivery
        string OrderDelivery = txtOrderDelivery.Text;
        //capture the order address
        string OrderAddress = txtOrderAddress.Text;
        //capture the order return
        //string OrderReturn = txtOrderReturn.Text;
        //capture the order date
        string OrderDate = txtOrderDate.Text;
        //varaible to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderID, OrderAddress, OrderDelivery, OrderSearch,OrderDate, //OrderReturn);
        if (Error == "")
        {
            //capture the order id
            AnOrder.OrderID = Convert.ToInt32 ( OrderID);
            //capture the address
            AnOrder.OrderAddress = OrderAddress;
            //capture the search
            AnOrder.OrderSearch = Convert.ToBoolean (OrderSearch);
            //capture the delivery
            AnOrder.OrderDelivery = Convert.ToBoolean(OrderDelivery);
            //CAPTURE THE RETURN
            AnOrder.OrderReturn = Convert.ToString( OrderReturn);
            //capture the date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);

        
             //store the address in the session object
             Session["AnOrder"] = AnOrder;
             //navigate to the viewer page
             Response.Redirect("OrderDataEntry.aspx");
        }
        else
         {
            //display the error message
            lblError.Text = Error;

        }


    protected void btnFind_Click(object sender, EventArgs e)
    {

    }




