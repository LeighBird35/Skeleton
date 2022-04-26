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


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 int the session object to indicate this is a new record
        Session["bookI"] = -1;
        //redirect to data entry page
        Response.Redirect("StocDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be eddited
        Int32 bookId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primark key value of the record to edit
            bookId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["bookId"] = bookId;
            //redirect to the exit page
            Response.Redirect("StockDataEntry.aspx");
        }

        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }



    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 bookId;
        //if record has been selcted from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get primary key value of the rcord to edit
            bookId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the seeeion object
            Session["bookId"] = bookId;
            //redirect to the delete page
            Response.Redirect("StockDeleteEntry.aspx");
        }
        else //if no record has been selcted
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the stock collection
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportBybookDescription(txtTitle.Text);
        lstStockList.DataSource = Stock.stockList;
        lstStockList.DataValueField = "bookId";
        lstStockList.DataTextField = "bookDescription";
        lstStockList.DataBind();
       
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportBybookDescription("");
        txtTitle.Text = "";
        lstStockList.DataSource = Stock.stockList;
        lstStockList.DataValueField = "bookId";
        lstStockList.DataTextField = "bookDescription";
        lstStockList.DataBind();
    }
}
