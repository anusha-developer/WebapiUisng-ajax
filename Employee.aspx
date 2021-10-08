<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WebapiusingAjax.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h2>Consume the values using Ajax</h2>
                <hr />
                 <table border="1">
                    <tr>
                        <td> EmpName</td>
                        <td><asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox></td>
                     </tr>
                     <tr>
                        <td> EmpEmailId</td>
                        <td><asp:TextBox ID="txtEmpEmailId" runat="server"></asp:TextBox></td>
                     </tr>
                     <tr>
                        <td> EmpPhoneno</td>
                        <td><asp:TextBox ID="txtEmpPhoneno" runat="server"></asp:TextBox></td>
                     </tr>
                     <tr>
                        <td> EmpAddress</td>
                        <td><asp:TextBox ID="txtEmpAddress" runat="server"></asp:TextBox></td>
                        </tr>
                     </table>
                    <br />
                      <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" BackColor="Green"   Text="Save" OnClientClick="Save()" return="false;" OnClick="btnSave_Click1"/>&nbsp;
                        <asp:Button ID="btnUpdate" runat="server" BackColor="blue"   Text="Update" OnClientClick="Update()" return="false;" OnClick="btnUpdate_Click"/>&nbsp;
                       <asp:Button ID="btnDelete" runat="server"  BackColor="Red"  Text="Delete" OnClientClick="Delete()" return="false;" OnClick="btnDelete_Click"/>
                    </td>
                </tr>
                <hr />
                 <asp:GridView ID="GvEmployee" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnClick="Delete(Id)" >
                     <AlternatingRowStyle BackColor="White" />
                     <Columns>
                     <asp:BoundField DataField="EmpName" HeaderText="EmpName" />
                    <asp:BoundField DataField="EmpEmailId" HeaderText="EmpEmailId" />
                    <asp:BoundField DataField="EmpPhoneno" HeaderText="EmpPhoneno" />
                    <asp:BoundField DataField="EmpAddress" HeaderText="EmpAddress" />
                     </Columns>
                     <EditRowStyle BackColor="#7C6F57" />
                     <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                     <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                     <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                     <RowStyle BackColor="#E3EAEB" />
                     <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                     <SortedAscendingCellStyle BackColor="#F8FAFA" />
                     <SortedAscendingHeaderStyle BackColor="#246B61" />
                     <SortedDescendingCellStyle BackColor="#D4DFE1" />
                     <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
               
            </center>
        </div>
    </form>
</body>
</html>
<script src="Scripts/jquery-3.4.1.min.js"></script>
<script src="Content/Scripts/Product.js"></script>
