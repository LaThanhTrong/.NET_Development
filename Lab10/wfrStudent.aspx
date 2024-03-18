<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrStudent.aspx.cs" Inherits="Lab10.wfrStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style>
    .gridview th {
    padding: 8px; /* Add padding to the header cells */
    }

    .gridview td {
        padding: 8px; /* Add padding to the data cells */
    }

    .pagination {
        padding: 0px;
        background-color: rgb(0, 141, 218);
        color: white;
        text-align: -webkit-center;
    }
</style>
<body>
    <form id="form1" runat="server">
        <h1>Danh sách sinh viên</h1>
        <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" GridLines="None" Width="100%" OnRowDataBound="GridView_RowDataBound" OnRowCreated="GridView_RowCreated" OnRowDeleting="GridView_RowDeleting" AllowPaging="true" OnPageIndexChanging="grdSV_OnPageIndexChanging" PageSize="5" CssClass="gridview" OnRowCancelingEdit="GridView_RowCancelingEdit" OnRowEditing="GridView_RowEditing" OnRowUpdating="GridView_RowUpdating" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField SortExpression="Action">
                    <ItemTemplate>
                        <asp:LinkButton ID="Edit" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                        <asp:LinkButton ID="Delete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
                        <asp:LinkButton ID="Select" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="Update" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                        <asp:LinkButton ID="Cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                    </EditItemTemplate>
                </asp:TemplateField>
            
                <asp:TemplateField HeaderText="Mã sinh viên" SortExpression="MaSV" >
                    <ItemTemplate>
                        <asp:Label ID="LabelMaSV" runat="server" Text='<%# Eval("MaSV") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Họ tên" SortExpression="TenSV">
                    <ItemTemplate>
                        <asp:Label ID="LabelTenSV" runat="server" Text='<%# Eval("TenSV") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxTenSV" runat="server" Text='<%# Bind("TenSV") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Phái" SortExpression="Phai">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBoxPhai" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Lớp" SortExpression="Lop">
                    <ItemTemplate>
                        <asp:Label ID="LabelLop" runat="server" Text='<%# Eval("Lop") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxLop" runat="server" Text='<%# Bind("Lop") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
          
            </Columns>
            <PagerStyle CssClass="pagination" />
            <HeaderStyle BackColor="#6699FF" ForeColor="White" BorderStyle="None" HorizontalAlign="Left" />
        </asp:GridView>
    </form>

</body>
</html>
