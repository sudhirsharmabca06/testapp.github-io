<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bharatlogin.aspx.cs" Inherits="bharatlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <title>:: Admin Login ::</title>
    <link rel="stylesheet" href="css/reset.css" type="text/css" media="all" />
    <link rel="stylesheet" href="css/layout.css" type="text/css" media="all" />
    <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
        <header>
    <div class="wrapper">
    <div style="float:left;">
        <img src="images/my photo1.jpg" title="My Photo" width="65" height="65" alt="My Photo" /></div>
      <h1><a href="index.aspx" id="logo">Bharat Agrawal</a></h1>
   
      <div style="float:right; padding:30px 0 0 0">
        <span style="font-size:20px; color:steelblue; font-weight:bold; padding:30px 30px 0 0">Contact:- +91(941)402-3552</span>
      <a href="https://www.facebook.com/bharatagrawalsoftskillbehaviouraltrainer" target="_blank"> <img src="images/facebook.png" title="Facebook" alt="Facebook" /></a>
                          <a href="http://in.linkedin.com/pub/bharat-agarwal/11/32b/b93" target="_blank"><img src="images/linkedin.png" title="Linkedin" alt="linkedin" /> </a>
                       <a href="https://twitter.com/astrobharat" target="_blank"> <img src="images/twitter.png" title="Twitter" alt="twitter" /> </a></div>
    </div>
     
      <div class="box pad_bot1">

        <div class="pad marg_top">


          <div id="ContactForm" align="center">

              <table width="520px">
              <tr >
              <td  style="width:150px" class="wrapper">
              <span style="color:Red; font-weight:bolder">*</span>User Name:
              </td>
              <td class="bg" >
              <asp:TextBox class="input"  id="txtUserName"  runat="server"></asp:TextBox>
                     </td>
              
              </tr>
                <tr>
              <td  class="wrapper" style="width:100px">
               <span style="color:Red; font-weight:bolder">*</span>Password:
              </td>
              <td class="bg" >
               <asp:TextBox class="input" id="txtPassword"  TextMode="Password" runat="server"></asp:TextBox>
   
                        </td>
                      
              
              </tr>
             <tr>
             
            <td>&nbsp;</td>
             <td>
               <asp:Button  id="btnLogin" CssClass="Mybutton"    runat="server" Text="Login" 
                                                        onclick="btnLogin_Click" />
             
             </td>
             </tr>
         
              </table>


                
                </div>
      
		  					
									

  
    </div>
    <%--<div id="kenburns" class="slideshow">
		<img src="images/UploadImages/1.jpg" alt="1">
	</div>--%>
    </div>
    </div>
    </form>
</body>
</html>
