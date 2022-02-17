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
        //create a new instance of clsStock
        //clsStock aStock = new clsStock();
        //capture the data
        //aStock.bookId = txtbookId.Text;
        //store the data in the session object
        //Session["aStock"] = aStock;
        //navigate to the user page
        //Response.Redirect("StockViewer.aspx");

        //create a new instance of clsStock
        //clsStock aStock = new clsStock();
        //capture the data
        //aStock.bookSearches = txtbookSearches.Text;
        //store the data in the session object
        //Session["aStock"] = aStock;
        //navigate to the user page
        //Response.Redirect("StockViewer.aspx");

        //create a new instance of clsStock
        clsStock aStock = new clsStock();
        //capture the data
        aStock.bookDescription = txtbookDescription.Text;
        //store the data in the session object
        Session["aStock"] = aStock;
        //navigate to the user page
        Response.Redirect("StockViewer.aspx");

        //create a new instance of clsStock
        //clsStock aStock = new clsStock();
        //capture the data
        //aStock.price = txtprice.Text;
        //store the data in the session object
        //Session["aStock"] = aStock;
        //navigate to the user page
        //Response.Redirect("StockViewer.aspx");

        //create a new instance of clsStock
        //clsStock aStock = new clsStock();
        //capture the data
        //aStock.dayAdded = txtdayAdded.Text;
        //store the data in the session object
        //Session["aStock"] = aStock;
        //navigate to the user page
        //Response.Redirect("StockViewer.aspx");

        //create a new instance of clsStock
        //clsStock aStock = new clsStock();
        //capture the data
        //aStock.available = chkavailable.Text;
        //store the data in the session object
        //Session["aStock"] = aStock;
        //navigate to the user page
        //Response.Redirect("StockViewer.aspx");


    }
}