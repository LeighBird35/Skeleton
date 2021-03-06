using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the house number for this entry
        Response.Write(AnCustomer.customerNo);
        Response.Write(AnCustomer.CustomerName);
        Response.Write(AnCustomer.customerAddress);
        Response.Write(AnCustomer.hasAccount);
        Response.Write(AnCustomer.creationDate);
    }
}