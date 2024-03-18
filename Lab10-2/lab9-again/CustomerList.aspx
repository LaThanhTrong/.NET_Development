<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="lab9_again.CustomerList" %>

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
    .right-align {
        text-align: right;
    }
</style>
<body>
    <form id="form1" runat="server">
        <h3 style="background-color: mediumpurple; color: white; margin-bottom: 7px;">Danh sách khách hàng</h3>
        <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" GridLines="None" Width="100%" OnRowDataBound="GridView_RowDataBound" OnRowCreated="GridView_RowCreated" OnRowDeleting="GridView_RowDeleting" AllowPaging="true" OnPageIndexChanging="grdSV_OnPageIndexChanging" PageSize="5" CssClass="gridview" OnRowCancelingEdit="GridView_RowCancelingEdit" OnRowEditing="GridView_RowEditing" OnRowUpdating="GridView_RowUpdating" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
            <Columns>            
                <asp:TemplateField HeaderText="Tên đăng nhập" SortExpression="Username" >
                    <ItemTemplate>
                        <asp:Label ID="LabelUsername" runat="server" Text='<%# Eval("Username") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Họ tên" SortExpression="Name">
                    <ItemTemplate>
                        <asp:Label ID="LabelName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Ngày Sinh" SortExpression="DOB">
                    <ItemTemplate>
                        <asp:Label ID="LabelDOB" runat="server" Text='<%# Eval("birthday", "{0:dd/MM/yyyy}") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <input type="date" id="TextBoxDOB" runat="server" value='<%# Bind("birthday") %>' class="datepicker" />
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Phái" SortExpression="Phai">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBoxPhai" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Email" SortExpression="Email">
                    <ItemTemplate>
                        <asp:Label ID="LabelEmail" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxEmail" runat="server" Text='<%# Bind("email") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField SortExpression="Action">
                    <ItemTemplate>
                        <div class="right-align">
                            <asp:LinkButton ID="Select" runat="server" CausesValidation="False" CommandName="Select" Text="Chọn"></asp:LinkButton>
                            <asp:LinkButton ID="Edit" runat="server" CausesValidation="False" CommandName="Edit" Text="Sửa"></asp:LinkButton>
                            <asp:LinkButton ID="Delete" runat="server" CausesValidation="False" CommandName="Delete" Text="Xóa"></asp:LinkButton>
                        </div>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <div class="right-align">
                            <asp:LinkButton ID="Update" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                            <asp:LinkButton ID="Cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                        </div>
                    </EditItemTemplate>
                </asp:TemplateField>
          
            </Columns>
            <PagerStyle CssClass="pagination" />
            <HeaderStyle BackColor="#6699FF" ForeColor="White" BorderStyle="None" HorizontalAlign="Left" />
        </asp:GridView>
    </form>

</body>
</html>
