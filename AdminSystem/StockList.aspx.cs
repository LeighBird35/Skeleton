using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }

    }

    void DisplayStock()
    {
        //create an instance of the stock sollection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to list of addresses in the collection
        lstStockList.DataSource  = Stock.stockList;
        //set the name of theprimary key
        lstStockList.DataValueField = "bookId";
        //set data field to display
        lstStockList.DataTextField = "bookDescription";
        //bind the data to the list
        lstStockList.DataBind();
    }

}