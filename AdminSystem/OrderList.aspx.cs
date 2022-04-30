using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                //update the list box
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        //create an instance of the orders collection
        clsOrderCollections Order= new clsOrderCollections();
        //find the record to update
        Order.ThisOrder.Find(OrderID);
        //display the data for this record
        txtOrderID.Text = Order.ThisOrder.OrderID.ToString();
        txtOrderSearch.Text = Order.ThisOrder.OrderSearch;
        txtOrderAddress.Text = Order.ThisOrder.OrderAddress;
        txtOrderReturn.Text = Order.ThisOrder.OrderReturn;
        txtOrderDelivery.Text = Order.ThisOrder.OrderDelivery;
        txtOrderDate.text = Order.ThisOrder.OrderDate.ToString();
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data emtry page
        Response.Redirect("OrderDataEntry.aspx");
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key values of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key values of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a reecord has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //gt the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }



    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the oder collection
        clsOrderCollections Orders = new clsOrderCollections();
        Orders.ReportByOrderAddress(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the firld to display
        lstOrderList.DataValueField = "OrderID";
        //set the name of the field to display
        lstOrderList.DataTextField = "OrderAddress";
        //bind the data to the list
        lstOrderList.DataBind();
    }
}