using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 customerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        customerNo = Convert.ToInt32(Session["customerNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (customerNo != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the customer list
        clsCustomerCollection customerList = new clsCustomerCollection();
        //find the record to update
        customerList.ThisCustomer.Find(customerNo);
        //display the data for this record
        txtcustomerNo.Text = customerList.ThisCustomer.customerNo.ToString();
        txtcustomerName.Text = customerList.ThisCustomer.customerName;
        txtcustomerAddress.Text = customerList.ThisCustomer.customerName;
        chkhasAccount.Checked = customerList.ThisCustomer.hasAccount;
        txtCreationDate.Text = customerList.ThisCustomer.creationDate.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();

        //capture the data
        string customerName = txtcustomerName.Text;
        string customerAddress = txtcustomerAddress.Text;
        string creationDate = txtCreationDate.Text;

        //variable to store any errors
        string Error = "";

        //validate the data
        Error = AnCustomer.Valid(customerName, customerAddress, creationDate);
        if (Error == "")
        {
            //capture the data
            AnCustomer.customerNo = customerNo;
            AnCustomer.customerName = customerName;
            AnCustomer.customerAddress = customerAddress;
            AnCustomer.creationDate = Convert.ToDateTime(creationDate);
            AnCustomer.hasAccount = chkhasAccount.Checked;

            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. customerNo = -1 then add the data
            if (customerNo == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(customerNo);
                //set the thiscustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }






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
            txtcustomerName.Text = AnCustomer.customerName;
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