<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exe7.WebForm1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        div {
            font-family: Verdana;
            font-size: 11pt;
            color: #0000cc;
        }
    </style>
    <title>Required Field Validation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please fill out the form:<br />
            * Required field:
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator1" 
                runat="server" 
                ControlToValidate="textbox1" 
                ErrorMessage="Please enter your name." 
                ForeColor="Red" />
            <br />
            <asp:TextBox ID="textbox1" runat="server" />
            &nbsp;* Name<br />
            <asp:TextBox ID="textbox2" runat="server" />
            &nbsp;City<br />
            <asp:TextBox ID="textbox3" runat="server" Width="38px" />
            &nbsp;State<br />
            <asp:TextBox ID="textbox4" runat="server" Width="78px" />
            &nbsp;Zip<br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </p>
    </form>
</body>
</html>
