using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {

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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();


        //capture other order data
        string OrderAddress = txtOrderAddress.Text;
        string OrderReturn = txtOrderReturn.Text;
        string OrderSearch = txtOrderSearch.Text;
        string OrderDelivery = txtOrderDelivery.Text;
        string OrderDate = txtOrderDate.Text;

        //variable to store any errors
        string Error = "";

        //validate data
        Error = AnOrder.Valid(OrderSearch, OrderAddress, OrderReturn, OrderDelivery, OrderDate);
        if (Error == "")
        {
            //capture the primary key

            //capture data
            AnOrder.OrderSearch = Convert.ToBoolean(OrderSearch);
            AnOrder.OrderAddress = OrderAddress;
            AnOrder.OrderReturn = OrderReturn;
            AnOrder.OrderDelivery = Convert.ToBoolean(OrderDelivery);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture active
            AnOrder.Active = chkActive.Checked;

            //create new instance of stock collection
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderID == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add new record
                OrderList.Add();
            }
            //otherwise it must be an uodate
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderID);
                //set thsi Order property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back tot he listpage
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }








    }
}





