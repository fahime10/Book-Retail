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
        string StaffID = txtStaffID.Text;
        string StaffFirstName = txtStaffFirstName.Text;
        string StaffLastName = txtStaffLastName.Text;
        string StaffEndDate = txtStaffEndDate.Text;
        string StaffSalary = txtStaffSalary.Text;
        string StaffEmployed = chkStaffEmployed.Checked.ToString();
        string Error = "";
        Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, StaffSalary, StaffEmployed);
        if (Error == "")
        {
            AStaff.StaffID = Convert.ToInt32(StaffID);
            AStaff.StaffFirstName = StaffFirstName;
            AStaff.StaffLastName = StaffLastName;
            AStaff.StaffEndDate = Convert.ToDateTime(StaffEndDate).Date;
            AStaff.StaffSalary = Convert.ToInt32(StaffSalary);
            AStaff.StaffEmployed = chkStaffEmployed.Checked;
            Session["AStaff"] = AStaff;
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = AStaff.Find(StaffID);
        if (Found == true)
        {
            txtStaffFirstName.Text = AStaff.StaffFirstName;
            txtStaffLastName.Text = AStaff.StaffLastName;
            txtStaffEndDate.Text = AStaff.StaffEndDate.ToString();
            txtStaffSalary.Text = AStaff.StaffSalary.ToString();
            chkStaffEmployed.Checked = AStaff.StaffEmployed;
        }

    }
}