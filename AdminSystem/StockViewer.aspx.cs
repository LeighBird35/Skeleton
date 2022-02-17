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
        //create a new instance of clsStock
        clsStock aStock = new clsStock();
        //get data from the session object
        aStock = (clsStock)Session["aStock"];
        //display the data for this entry
        Response.Write(aStock.bookId);
        Response.Write(aStock.bookSearches);
        Response.Write(aStock.bookDescription);
        Response.Write(aStock.price);
        Response.Write(aStock.dayAdded);
        Response.Write(aStock.available);

    }
}