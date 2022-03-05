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
            //capture data
            aStock.bookSearches = bookSearches;
            aStock.bookDescription = bookDescription;
            aStock.price = Convert.ToDouble(price);
            aStock.dayAdded = Convert.ToDateTime(dayAdded);

            //store the data in the session object
            Session["aStock"] = aStock;
            //navigate to the user page
            Response.Write("StockViewer.aspx");
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