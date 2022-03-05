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
        //create a new instance of clsStaff
        clsStaff AstaffMember = new clsStaff();
        //get the data from the session object
        AstaffMember = (clsStaff)Session["AstaffMember"];
        //display the staff number for this entry
        Response.Write(AstaffMember.StaffNo);
        Response.Write(AstaffMember.StaffDesc);
        Response.Write(AstaffMember.StaffName);
        Response.Write(AstaffMember.StaffDob);
        Response.Write(AstaffMember.StaffWage);
        Response.Write(AstaffMember.StaffAvaliable);
    }
}