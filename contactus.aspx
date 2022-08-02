<%@ Page Title="Bharat Agrawal Soft Skill Trainer In Rajasthan| Vastu Consultant| Astrologer In Rajasthan| Management
        Trainer In Rajasthan | MidBrain Activation Trainer | DMIT Course in Rajasthan | MidBrain Activation Course in Rajasthan" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="contactus.aspx.cs" Inherits="contactus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="pad">
        <div class="wrapper">
            <article class="col1">
            <h2>Contact form</h2>
          </article>
            <article class="col2 pad_left1">
            <h2>Contact us</h2>
          </article>
        </div>
    </div>
    <div class="box pad_bot1">
        <div class="pad marg_top">
            <article class="col1" style="float: left">
            
              <div id="ContactForm">

              <table>
              <tr >
              <td style="width:80px" class="wrapper">
              <span style="color:Red; font-weight:bolder">*</span>Name:
              </td>
              <td class="bg">
                <asp:TextBox ID="txtName" class="input" runat="server"></asp:TextBox>
                
                    <asp:RequiredFieldValidator ID="reqName" runat="server" 
                          ErrorMessage="Name cannot be blank."  SetFocusOnError="true" ValidationGroup="g" ControlToValidate="txtName"></asp:RequiredFieldValidator>
              </td>
             
            
              
              </tr>
                    <tr>
              <td  class="wrapper">
               <span style="color:Red; font-weight:bolder">*</span>Email:
              </td>
              <td class="bg">
               <asp:TextBox ID="txtmail" class="input" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqMail" runat="server" SetFocusOnError="true" 
                          ErrorMessage="Email cannot be blank."  ControlToValidate="txtmail" ValidationGroup="g"></asp:RequiredFieldValidator>
                          <asp:RegularExpressionValidator ID="regexmail"  SetFocusOnError="true" Display="None"
                           runat="server" ErrorMessage="please enter valid Email."  
                          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="g" 
                          ControlToValidate="txtmail"></asp:RegularExpressionValidator> </td>
              
              </tr>
                <tr>
              <td  class="wrapper">
               <span style="color:Red; font-weight:bolder">*</span>Tel No:
              </td>
              <td class="bg">
               <asp:TextBox ID="txtContactNo" class="input" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqContactNo" runat="server" 
                          ErrorMessage="ContactNo cannot be blank." ControlToValidate="txtContactNo" SetFocusOnError="true" ValidationGroup="g"></asp:RequiredFieldValidator>
                        </td>
              
              </tr>
              <tr>
              <td  class="wrapper">
              Message:
              </td>
              
              <td class="bg2">
               <asp:TextBox ID="txtMessage" TextMode="MultiLine" Columns="1" Rows="1" runat="server"></asp:TextBox></td>
              </tr>
              </table>




           
             


<asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="button"  ValidationGroup="g"  OnClick="btnClear_Click"></asp:Button>
<asp:Button ID="btnSend" runat="server" Text="Send" CssClass="button"  ValidationGroup="g" OnClick="btnSend_Click"></asp:Button>
                  <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                            ShowMessageBox="True" ShowSummary="False" ValidationGroup="g" />
                </div>
           
          </article>
        </div>
        <div class="pad marg_top">
            <article class="col2 pad_left1">
            <div class="wrapper under">
              
            <b>
                
              Bharat Agrawal<br />
A-115 Ranjeet nagar<br />
Bharatpur-321001 (Rajasthan)<br />
<br />
 +91(941)402-3552<br />
+91(963)655-8773</b><br /><br />
 <a href="mailto:jcbharat30@yahoo.com">jcbharat30@yahoo.com</a><br />
  <a href="mailto:enquiry@bharat-agrawal.com">enquiry@bharat-agrawal</a>

<br />

 </div>
         
   <div class="wrapper under">
               <b>
                <a href="mailto:enquiry@bharat-agrawal.com">Write Your Problems</a>
</b>

</div>
         

          </article>
        </div>
    </div>
     <h2>Find my Location in map</h2>
    <div>
          <iframe width="945" height="420" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.co.in/maps/ms?ll=27.231422,77.489372&amp;spn=0.0058,0.010568&amp;t=h&amp;z=17&amp;iwloc=0004ed7814816bafa0980&amp;lci=com.panoramio.all&amp;msa=0&amp;msid=212127670777410805559.0004ed7810d83ba497383&amp;output=embed"></iframe><br /><small>View <a href="https://maps.google.com/maps/ms?ll=27.231422,77.489372&amp;spn=0.0058,0.010568&amp;t=h&amp;z=17&amp;iwloc=0004ed7814816bafa0980&amp;lci=com.panoramio.all&amp;msa=0&amp;msid=212127670777410805559.0004ed7810d83ba497383&amp;source=embed" style="color:#0000FF;text-align:left">Bharat Agrawal</a> in a larger map</small>
                
        </div> 

        <br />
</asp:Content>
