<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="aspcrud2.index" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfProductID" runat="server" />
            <table>
                <tr>
                    <td>
                        <asp:Label Text="product" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="txtProduct" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="price" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="txtPrice" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="count" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="txtCount" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="description" runat="server" />
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="txtDescription" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:Button Text="Save" ID="btnSave" runat="server" OnClick="btnSave_Click" />
                        <asp:Button Text="Delete" ID="btnDelete" runat="server" />
                        <asp:Button Text="Clear" ID="btnClear" runat="server" OnClick="btnClear_Click" />

                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:Label Text="" ID="lblSuccessMessage" runat="server" ForeColor="Green" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:Label Text="" ID="lblErrorMessage" runat="server" ForeColor="Red" />
                    </td>
                </tr>
            </table>
            <br/. />
            <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="product" HeaderText="product" />
                     <asp:BoundField DataField="price" HeaderText="price" />
                     <asp:BoundField DataField="count" HeaderText="count" />
                     <asp:TemplateField>
                         <ItemTemplate>
                             <asp:LinkButton Text="Select" ID="lnkselect" CommandArgument='<% Eval("productid") %>' runat="server" />
                         </ItemTemplate>
                     </asp:TemplateField>
                     
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>