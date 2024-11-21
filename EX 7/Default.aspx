<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YourNamespace._Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>CheckBoxList Example</title>
    <style>
        body {
            background-color: lightgreen;
            font-family: Arial, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- CheckBoxList -->
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Text="Tomato" Value="Tomato"></asp:ListItem>
                <asp:ListItem Text="Onion" Value="Onion"></asp:ListItem>
                <asp:ListItem Text="Banana" Value="Banana"></asp:ListItem>
            </asp:CheckBoxList>
            
            <!-- Button -->
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            
            <br /><br />
            
            <!-- Literal for output -->
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
