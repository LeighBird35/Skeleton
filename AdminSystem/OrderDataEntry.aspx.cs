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
        //capture the order number
        string OrderID = txtOrderID.Text;
        //capture the order delivery
        string OrderDelivery = txtOrderDelivery.Text;
        //capture the order address
        string OrderAddress = txtOrderAddress.Text;
        //capture the order return
        string OrderReturn = txtOrderReturn.Text;
        //capture the order serach
        string OrderSearch = txtOrderSearch.Text;
        //capture the order date
        string OrderDate = txtOrderDate.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data 
        Error = AnOrder.Valid(OrderID, OrderSearch, OrderDelivery, OrderAddress, OrderDate);
        if (Error == "")
        {
            //capture the order number
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            //capture the delivery
            AnOrder.OrderDelivery = Convert.ToBoolean(OrderDelivery);
            //capture the address
            AnOrder.OrderAddress = OrderAddress;
            //capture the return 
            AnOrder.OrderReturn = OrderReturn;
            //capture the order search
            AnOrder.OrderSearch = Convert.ToBoolean(OrderSearch);
            //capture the order date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture Active
            AnOrder.Active = chkActive.Checked;
            //create a new instance of the order collection
            clsOrderCollections OrderList = new clsOrderCollections();

            //if this is a new record i.e OrderID = -1 then add data
            if (OrderID == -1)
            {
                //set the ThisOrder Propeerty
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderID);
                //set the ThisOrrder property
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }


            //navigate to the viewer page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            //display the error messgae
            lblError.Text = Error;
        }
    }
}