using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{ 

    //var to store the primary key val of the record to be deleted
    Int32 customerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        customerNo = Convert.ToInt32(Session["customerNo"]);
    }

    protected void btnYesDelete_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book class
        clsCustomerCollection customerList = new clsCustomerCollection();
        //find the record to delete
        customerList.ThisCustomer.Find(customerNo);
        //delete the record
        customerList.Delete();
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }
}