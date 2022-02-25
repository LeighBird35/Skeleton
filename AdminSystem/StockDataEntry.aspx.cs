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
        aStock.bookId = Convert.ToInt32(txtbookId.Text);
        aStock.bookSearches = txtbookSearches.Text;
        aStock.bookDescription = txtbookDescription.Text;
        aStock.price = Convert.ToDouble(txtprice.Text);
        aStock.dayAdded = Convert.ToDateTime(txtdayAdded.Text);
        aStock.available = chkavailable.Checked;
        
        
        //store the data in the session object
        Session["aStock"] = aStock;
        //navigate to the user page
        Response.Redirect("StockViewer.aspx");

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