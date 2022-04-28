using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value
    Int32 bookId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of the book to deleted
        bookId = Convert.ToInt32(Session["bookId"]);

    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the book class
        clsStockCollection StockBook = new clsStockCollection();
        //find record to delete
        StockBook.ThisStock.Find(bookId);
        //deletd
        StockBook.Delete();
        //redirect to the main page
        Response.Redirect("StockList.aspx");
    }
}