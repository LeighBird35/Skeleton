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
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();

        //capture the data
        AnCustomer.customerNo = Convert.ToInt32(txtcustomerNo.Text);
        AnCustomer.CustomerName = txtcustomerNo.Text;
        AnCustomer.customerAddress = txtcustomerAddress.Text;
        AnCustomer.hasAccount = chkhasAccount.Checked;
        AnCustomer.creationDate = Convert.ToDateTime(txtCreationDate.Text);


        //store the customer info in the session object
        Session["AnCustomer"] = AnCustomer;

        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 customerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        customerID = Convert.ToInt32(txtcustomerNo.Text);
        //find the record
        Found = AnCustomer.Find(customerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtcustomerName.Text = AnCustomer.CustomerName;
            txtcustomerAddress.Text = AnCustomer.customerAddress;
            txtCreationDate.Text = AnCustomer.creationDate.ToString();
            //chkhasAccount = AnCustomer.hasAccount();
        }

        else
        {
            txtcustomerName.Text = ("N/A");
            txtcustomerAddress.Text = ("N/A");
            txtCreationDate.Text = DateTime.Now.ToString();
        }
    }
}