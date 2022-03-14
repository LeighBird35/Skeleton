using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{   

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AstaffMember = new clsStaff();
        //capture the staff no
        AstaffMember.StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //capture other staff info
        AstaffMember.StaffDesc = txtStaffDesc.Text;
        AstaffMember.StaffName = txtStaffName.Text;
        AstaffMember.StaffDob = txtStaffDob.Text;
        AstaffMember.StaffWage = Convert.ToDouble(txtStaffWage.Text);
        //AstaffMember.StaffAvaliable = Convert.ToBoolean(chkAvaliable.Text);
        //store the staff number in the session object
        Session["AstaffMember"] = AstaffMember;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}