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
            
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order number
        AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);

        //capture other order data
        AnOrder.OrderAddress = txtOrderAddress.Text;
        AnOrder.OrderReturn = txtOrderReturn.Text;
        //AnOrder.OrderSearch = Convert.ToBoolean(txtOrderSearch.Text);
        AnOrder.OrderDelivery = Convert.ToBoolean(txtOrderDelivery.Text);
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

        //store the order number in the session object
        Session["AnOrder"] = AnOrder;

        //navigate to the viewer page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderAddress.Text = AnOrder.OrderAddress;
            txtOrderReturn.Text = AnOrder.OrderReturn;
            txtOrderSearch.Text = AnOrder.OrderSearch.ToString();
            txtOrderDelivery.Text = AnOrder.OrderDelivery.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
        }
    }

  
}