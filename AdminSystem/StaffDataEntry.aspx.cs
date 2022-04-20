using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            if (StaffID != -1)
            {
                DisplayAddress();
            }
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        string StaffFirstName = txtStaffFirstName.Text;
        string StaffLastName = txtStaffLastName.Text;
        string StaffEndDate = txtStaffEndDate.Text;
        string StaffSalary = txtStaffSalary.Text;
        string StaffEmployed = chkStaffEmployed.Checked.ToString();
        string Error = "";
        Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEndDate, StaffSalary, StaffEmployed);
        if (Error == "")
        {
            AStaff.StaffID = StaffID;
            AStaff.StaffFirstName = StaffFirstName;
            AStaff.StaffLastName = StaffLastName;
            AStaff.StaffEndDate = Convert.ToDateTime(StaffEndDate).Date;
            AStaff.StaffSalary = Convert.ToInt32(StaffSalary);
            AStaff.StaffEmployed = chkStaffEmployed.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            if (StaffID == -1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffID);
                StaffList.ThisStaff = AStaff;
                StaffList.Update();

            }
            Response.Redirect("StaffList.aspx");
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
    void DisplayAddress()
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        AllStaff.ThisStaff.Find(StaffID);
        txtStaffID.Text = AllStaff.ThisStaff.StaffID.ToString();
        txtStaffFirstName.Text = AllStaff.ThisStaff.StaffFirstName;
        txtStaffLastName.Text = AllStaff.ThisStaff.StaffLastName;
        txtStaffEndDate.Text = AllStaff.ThisStaff.StaffEndDate.ToString();
        txtStaffSalary.Text = AllStaff.ThisStaff.StaffSalary.ToString();
        chkStaffEmployed.Checked = AllStaff.ThisStaff.StaffEmployed;

    }
}
