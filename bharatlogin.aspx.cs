using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bharatlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "", "alert('Please enter username.')", true);
            txtUserName.Focus();
            return;
        }
        if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "", "alert('Please enter password.')", true);
            txtPassword.Focus();
            return;
        }

        if (txtUserName.Text == "Admin" && txtPassword.Text == "1234")
        {
            Session["UserName"] = txtUserName.Text;
            Response.Redirect("uploadimages.aspx");
        }
        else
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "", "alert('please Enter Valid User Name or Password')", true);
            txtUserName.Focus();
        }
    }
}