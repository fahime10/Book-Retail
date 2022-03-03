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
        clsStaff AStaff = new clsStaff();
        AStaff = (clsStaff)Session["AStaff"];
        Session["AStaff"] = AStaff;
        Response.Write(AStaff.StaffID);
        Response.Write(AStaff.StaffFirstName);
        Response.Write(AStaff.StaffLastName);
        Response.Write(AStaff.StaffEndDate);
        Response.Write(AStaff.StaffSalary);
    }
}