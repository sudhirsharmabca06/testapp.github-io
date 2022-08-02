using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Data;
using System.Net.Mail;
using System.IO;
using System.Configuration;
using System.Text;


public partial class contactus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   

    private void ResetAll()
    {

        txtName.Text = string.Empty;
        txtmail.Text = string.Empty;
        txtMessage.Text = string.Empty;
        txtContactNo.Text = string.Empty;

    }
    /* public string GetGridviewData(GridView gv)
     {
         StringBuilder strBuilder = new StringBuilder();
         StringWriter strWriter = new StringWriter(strBuilder);
         HtmlTextWriter htw = new HtmlTextWriter(strWriter);
         gv.RenderControl(htw);
         return strBuilder.ToString();
     }*/
    /* public override void VerifyRenderingInServerForm(Control control)
     {
         /* Verifies that the control is rendered 
     }*/
    protected void btnSend_Click(object sender, EventArgs e)
    {
       
        string message = string.Empty;
        string name = txtName.Text.Trim();
        string email = txtmail.Text.Trim();
        string phone = txtContactNo.Text.Trim();
        string messageText =  "Name : " + txtName.Text + "\t" +
            "Mobile No :" + txtContactNo.Text + "\t" +
            "Email :" + txtmail.Text + "\t" +

        "Enquiry Message: " + txtMessage.Text; txtMessage.Text.Trim();
        MailService.SendMail(email, "Bharat-Agrawal | Contact | Thanks", "Website Enquiry", messageText, EmailType.ContactThanks);
       // Response.Redirect("~/PostContactUs.aspx");
        Page.ClientScript.RegisterClientScriptBlock(GetType(), "", "alert('Thank You. We will contact you soon')", true);
        ResetAll();

    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ResetAll();
    }
   }