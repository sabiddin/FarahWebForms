<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarSelect.aspx.cs" Inherits="SomeWebformsTutorial.CarSelect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlMake" AutoPostBack="true" OnSelectedIndexChanged ="ddlMake_SelectedIndexChanged" runat="server">               
            </asp:DropDownList>
             <asp:DropDownList ID="ddlModels" runat="server">               
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
