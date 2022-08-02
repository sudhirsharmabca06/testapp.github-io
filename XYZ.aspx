<%@ Page Language="C#" AutoEventWireup="true" CodeFile="XYZ.aspx.cs" Inherits="XYZ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div>

            <table style="width: 100%; border: solid">
                <thead style="text-align: center">
                    <tr>
                        <td>Time Based Task</td>
                        <td>Ongoing Task</td>
                      
                    </tr>
                </thead>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center; border-right: solid; width: 33%">
                        <u>Timer</u>
                        <br />
                        <br />
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                            <asp:Timer ID="Timer1" runat="server" Enabled="false" Interval="1000"
                                ontick="Timer1_Tick">
                            </asp:Timer>
                            <asp:Label ID="lblmin2" runat="server" Text="0"></asp:Label>
                            <asp:Label ID="lblmin1" runat="server" Text="0"></asp:Label>
                            <asp:Label ID="Label3" runat="server" Text=":"></asp:Label>
                            <asp:Label ID="lblsec2" runat="server" Text="0"></asp:Label>
                            <asp:Label ID="lblsec1" runat="server" Text="0"></asp:Label>
                        </ContentTemplate>
                        </asp:UpdatePanel>

                        <br />
                        <br />
                        <asp:Button ID="btnTimeStop" runat="server" Text="Click Here" OnClick="btnTimeStop_Click" />
                        <br />
                        <br />
                        <h2>
                            <asp:Label ID="lblTimerPressResult" runat="server" Text="Label" Visible="false"></asp:Label></h2>
                        <br />
                        <div style="text-align: left">
                            <h2>
                                <asp:Label ID="lblisRightCount" runat="server" Text="Is button press on right time: " Visible="false"></asp:Label></h2>
                            <h2>
                                <asp:Label ID="lblisWrongCount" runat="server" Text="Is button press on wrong time: " Visible="false"></asp:Label></h2>
                        </div>

                    </td>
                    <td style="text-align: center; width: 70%">
                      <u> Picture Match</u>
                        <asp:Panel ID="Panel1" runat="server" Height="400px">
                            <br />
                     
                            <asp:Image ID="img" runat="server"  Height="200" Width="200"/>
                            <br />
                            <br />
                      
                               <asp:Button ID="btnTree" runat="server" Text="Tree" Width="60px" OnClick="btnTree_Click"  /><br /><br />
                               <asp:Button ID="btnBird" runat="server" Text="Bird" Width="60px" OnClick="btnBird_Click" /><br /><br />
                               <asp:Button ID="btnHouse" runat="server" Text="House" Width="60px" OnClick="btnHouse_Click"  /><br /><br />
                               <asp:Button ID="btnCar" runat="server" Text="Car" Width="60px" OnClick="btnCar_Click"  /><br /><br />
                        </asp:Panel>
                       

                    </td>
                  <%--  <td style="text-align: center; border-left: solid; width: 33%;">
                        <u>Rearrange the numbers</u>
                        <br />
                        <br />
                        <table style="margin-left: 200px">
                            <thead>
                                <tr>
                                    <td></td>
                                    <td>Numbers&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td>Arranged</td>
                                </tr>
                            </thead>
                            <tr>
                                <td>
                                    <asp:Button ID="btnA" runat="server" Text="A" OnClick="btnA_Click" /></td>
                                <td>&nbsp;&nbsp;<asp:Label ID="lblFix2" runat="server" Text="2" /></td>
                                <td>&nbsp;&nbsp;<asp:Label ID="lbl1" runat="server" Text="0" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnB" runat="server" Text="B" OnClick="btnB_Click" /></td>
                                <td>&nbsp;&nbsp;<asp:Label ID="lblFix4" runat="server" Text="4" /></td>
                                <td>&nbsp;&nbsp;<asp:Label ID="lbl2" runat="server" Text="0" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnC" runat="server" Text="C" OnClick="btnC_Click" /></td>
                                <td>&nbsp;&nbsp;<asp:Label ID="lblFix1" runat="server" Text="1" /></td>
                                <td>&nbsp;&nbsp;<asp:Label ID="lbl3" runat="server" Text="0" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnD" runat="server" Text="D" OnClick="btnD_Click" /></td>
                                <td>&nbsp;&nbsp;<asp:Label ID="lblFix3" runat="server" Text="3" /></td>
                                <td>&nbsp;&nbsp;<asp:Label ID="lbl4" runat="server" Text="0" /></td>
                            </tr>

                        </table>
                        <br />
                        <br />
                        <asp:Button ID="btnABCDFinal" runat="server" Text="Submit" OnClick="btnABCDFinal_Click" /><br />
                        <h2>
                            <asp:Label ID="lblABCDStatus" runat="server" Text="Label" Visible="false"></asp:Label></h2>
                    </td>--%>

                </tr>


            </table>
            <br />
            <div>
                <h3>Instructions</h3>
                <pre>
This is a Prospective Memory task. 
This task include three tasks which will run together simultaneously enlisted below:

Task 1:
This is the ongoing task which is computer based.
A  image will be shown to you for example “ A picture of house”

And four options will be given to you in this manner:
CAR
HOUSE
BIRD
TREE

And you need to respond according to the options given by clicking 
key present computer screen. For ex: click on “house” for the sample question.

There will be no time limit for giving your response. A feedback in form of “Good” and “wrong” will be shown to you on every correct and incorrect answer.
In addition to that there will be a change in color of background randomly which will initiate the second task.

Task 2:
It is a pen paper task. Just after noticing the change in background color you need to rearrange the numbers written on a sheet of paper which will be given to you by the experimenter.
For example: 4, 2, 3 ,1 is written you need to write 1, 2 , 3 , 4 in the answer column.


Task 3:
A stop watchbis given to you at your left hand side after every 30 seconds you need to press the stop button present on it. 
A trial session of 15 practice trials will be given to you after which the “MAIN TASK” will start automatically.

            </pre>
            </div>
        </div>
    </form>
</body>
</html>
