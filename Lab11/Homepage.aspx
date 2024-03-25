<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Lab11.Homepage" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome,
                <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
            </h2>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />  
            <br />
            <div style="margin-top:20px; display:flex; gap: 20px">
                <asp:DropDownList ID="cbbCourse" runat="server" OnSelectedIndexChanged="cbbCourse_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
                <asp:DropDownList ID="cbbClass" runat="server" OnSelectedIndexChanged="cbbClass_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </div>

            <asp:GridView ID="GridView" style="margin-top: 30px" runat="server" AutoGenerateColumns="False" GridLines="None" Width="100%" AllowPaging="true" PageSize="5" CssClass="gridview" 
                OnRowCreated="GridView_RowCreated"
                OnRowDataBound="GridView_RowDataBound"
                OnRowDeleting="GridView_RowDeleting"
                OnPageIndexChanging="grdSV_OnPageIndexChanging"
                OnRowCancelingEdit="GridView_RowCancelingEdit"
                OnRowEditing="GridView_RowEditing"
                OnRowUpdating="GridView_RowUpdating"
                OnSelectedIndexChanged="GridView_SelectedIndexChanged">
                <Columns>            
                    <asp:TemplateField HeaderText="Mã sinh viên" SortExpression="MSSV" >
                        <ItemTemplate>
                            <asp:Label ID="LabelMSSV" runat="server" Text='<%# Eval("MSSV") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Họ tên" SortExpression="Name">
                        <ItemTemplate>
                            <asp:Label ID="LabelName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                
                    <asp:TemplateField HeaderText="Điểm" SortExpression="Grade">
                        <ItemTemplate>
                            <asp:Label ID="LabelGrade" runat="server" Text='<%# Eval("Grade") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBoxGrade" runat="server" Text='<%# Bind("Grade") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxGrade" ErrorMessage="Grade is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxGrade" ErrorMessage="Grade must be an integer between 0 and 10" ForeColor="Red" ValidationExpression="^(?:[0-9]|10)$"></asp:RegularExpressionValidator>
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
                                <asp:LinkButton ID="Update" runat="server" CausesValidation="True" CommandName="Update" Text="Cập nhật"></asp:LinkButton>
                                <asp:LinkButton ID="Cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="Hủy"></asp:LinkButton>
                            </div>
                        </EditItemTemplate>
                    </asp:TemplateField>
          
                </Columns>
            <PagerStyle CssClass="pagination" />
            <HeaderStyle BackColor="#6699FF" ForeColor="White" BorderStyle="None" HorizontalAlign="Left" />
        </asp:GridView>

        </div>
    </form>
</body>
</html>
