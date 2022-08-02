using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

/// <summary>
/// Summary description for MailService
/// </summary>
public class MailService
{
	public MailService()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static void SendMail(string from, string bcc, string subject, string mailBody, EmailType mailType)
    {
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "mail.bharat-agrawal.com";
        MailMessage message = new MailMessage();


        switch (mailType)
        {

           
            case EmailType.ContactThanks:
                smtp.Credentials = new System.Net.NetworkCredential("enquiry@bharat-agrawal.com", "bharat@123");


                message = new MailMessage(from,"enquiry@bharat-agrawal.com", subject, mailBody);
                message.CC.Add("jcbharat30@yahoo.com");

                message.IsBodyHtml = true;
                break;

            default:
                break;

        }


        message.IsBodyHtml = true;

        smtp.Send(message);

    }


}

public enum EmailType
{
    ForgetPassword,
    ContactThanks

}