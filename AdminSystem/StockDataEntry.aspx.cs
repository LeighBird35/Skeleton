using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primark key with page leel scope
    Int32 bookId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the book to be processed
        bookId = Convert.ToInt32(Session["bookId"]);
        if (IsPostBack == false)
        {
            DisplayStock();
            //if this is not a new record
            if (bookId != -1)
            {
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        //create an instance of the address book
        clsStockCollection stockBook = new clsStockCollection();
        //find the recrd to pdate
        stockBook.ThisStock.Find(bookId);
        //display the data for this record
        txtbookId.Text = stockBook.ThisStock.bookId.ToString();
        txtbookSearches.Text = stockBook.ThisStock.bookSearches;
        txtbookDescription.Text = stockBook.ThisStock.bookDescription;
        txtprice.Text = stockBook.ThisStock.price.ToString();
        txtdayAdded.Text = stockBook.ThisStock.dayAdded.ToString();
        chkavailable.Text = stockBook.ThisStock.available.ToString();

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock aStock = new clsStock();

        //capture the data
        string bookSearches = txtbookSearches.Text;
        string bookDescription = txtbookDescription.Text;
        string price = txtprice.Text;
        string dayAdded = txtdayAdded.Text;

        //variable to store any errors
        string Error = "";

        //validate data
        Error = aStock.Valid(bookSearches, bookDescription, price, dayAdded);
        if (Error == "")
        {
            //capture the primary key
            aStock.bookId = bookId;  //ToString int32?
            //capture data
            aStock.bookSearches = bookSearches;
            aStock.bookDescription = bookDescription;
            aStock.price = Convert.ToDouble(price);
            aStock.dayAdded = Convert.ToDateTime(dayAdded);

            //capture active
            aStock.available = chkavailable.Checked;

            //create new instance of stock collection
            clsStockCollection StockList = new clsStockCollection();
            
            if (bookId == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = aStock;
                //add new record
                StockList.Add();
            }
            //otherwise it must be an uodate
            else
            {
                //find the record to update
                StockList.ThisStock.Find(bookId);
                //set thsi stoc property
                StockList.ThisStock = aStock;
                //update the record
                StockList.Update();
            }
                
            //navigate to the page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsStock aStock = new clsStock();
        //variable to store the primary key
        Int32 bookId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get primary key entered by user
        bookId = Convert.ToInt32(txtbookId.Text);
        //find the record
        Found = aStock.Find(bookId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtbookSearches.Text = aStock.bookSearches;
            txtbookDescription.Text = aStock.bookDescription;
            txtprice.Text = aStock.price.ToString();
            txtdayAdded.Text = aStock.dayAdded.ToString();
            //chkavailable.Text = aStock.available.ToString();

        }
    }
}