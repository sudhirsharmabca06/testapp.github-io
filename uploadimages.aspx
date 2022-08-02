<%@ Page Language="C#" AutoEventWireup="true" CodeFile="uploadimages.aspx.cs" Inherits="uploadimages" %>

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
    <div class="pad">
        
         <br />
         <div style="float:left; font-size:20px"><b><u>Image Upload Admin Panel</u></b></div>
          <div style="float:right; width:400px; text-align:right">
         
          <asp:Button ID="hlViwGallery" CssClass="Mybutton" Text="View Gallery"  
                  runat="server" onclick="hlViwGallery_Click"></asp:Button>
           <asp:Button ID="btnlogout" runat="server" CssClass="Mybutton" onclick="btnlogout_Click" Text="Logout" 
                  ></asp:Button>
          </div>
        </div>
        <hr />
     <br />
     <br />
        <div class="pad marg_top">

       Select File :       <asp:FileUpload ID="FileUpload1" CssClass="Mybutton" runat="server"></asp:FileUpload>&nbsp;
        
         <asp:Button  ID="btnSave" runat="server" CssClass="Mybutton" Text="Upload" onclick="btnSave_Click" 
                BorderColor="#6699FF"></asp:Button>
      


 
            
    </div>
 
     </div>
        <asp:ListView ID="lvImagecollection" runat="server" ItemPlaceholderID="itemplace"
                GroupItemCount="4" GroupPlaceholderID="groupitemplace">
                <LayoutTemplate>
                    <table width="100%">
                        <asp:PlaceHolder runat="server" ID="groupitemplace"></asp:PlaceHolder>
                   </table>
                </LayoutTemplate>
                <GroupTemplate>
                    <tr>
                        <asp:PlaceHolder ID="itemplace" runat="server"></asp:PlaceHolder>
                   </tr>
                   <tr>
                   <td><br /></td>
                   </tr>
                    
                </GroupTemplate>
                <ItemTemplate>
                                          

                            <td><a href='<%# Eval("ImageUrl")%>' rel="prettyPhoto[gallery1]" title="Image 1"><img id="img" src='<%# Eval("ThumbUrl")%>' alt="" runat="server" /></a>
                        <asp:HiddenField ID="hdnId" Value='<%#Eval("ThumbUrl")%>' runat="server" />
                       <asp:Label ID="Label1" runat="server" Visible="false" Text='<%# Eval("ThumbUrl")%>'></asp:Label>
                       <br /><asp:LinkButton   ID="btnDelete" CommandName='<%#Eval("ThumbUrl")%>' OnClick="btnDelete_Click" runat="server">Delete</asp:LinkButton>
                            </td>
                            

                </ItemTemplate>
            </asp:ListView>

    </div>
    </form>
</body>
</html>
