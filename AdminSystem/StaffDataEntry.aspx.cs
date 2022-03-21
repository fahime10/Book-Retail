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
        clsStaff AStaff = new clsStaff();
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        AStaff.StaffFirstName = txtStaffFirstName.Text;
        AStaff.StaffLastName = txtStaffLastName.Text;
        AStaff.StaffEndDate = Convert.ToDateTime(txtStaffEndDate.Text);
        AStaff.StaffSalary = Convert.ToDouble(txtStaffSalary.Text);
        AStaff.StaffEmployed = chkStaffEmployed.Checked;
        Session["AStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = AStaff.Find(StaffID);
        if (Found == true) {
            txtStaffFirstName.Text= AStaff.StaffFirstName;
            txtStaffLastName.Text = AStaff.StaffLastName;
            txtStaffEndDate.Text = AStaff.StaffEndDate.ToString();
            txtStaffSalary.Text = AStaff.StaffSalary.ToString();


        }
    }
}