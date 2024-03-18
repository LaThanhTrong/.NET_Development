<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FillingForm.aspx.cs" Inherits="lab9_again.FillingForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 206px;
        }
        .auto-style3 {
            width: 206px;
            text-align: center;
            height: 21px;
        }
        .auto-style4 {
            width: 206px;
            height: 23px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="2" style="background-color: #FFFFFF; color: #000000; font-weight: bold">Đăng ký khách hàng</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2" style="color: #FFFFFF; background-color: #0000FF; font-weight: bold;">Thông tin đăng nhập</td>
            </tr>
            <tr>
                <td class="auto-style4">Tên đăng nhập</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtTenDN" runat="server" Width="690px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_TenDN" runat="server" ControlToValidate="txtTenDN" ErrorMessage="Tên đăng nhập không được rỗng">(*)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Mật khẩu</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtMK" runat="server" Width="690px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_MK" runat="server" ControlToValidate="txtMK" ErrorMessage="Mật khẩu không được rỗng">(*)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Nhập lại mật khẩu</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtNhaplaiMK" runat="server" Width="690px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_Nhaplai" runat="server" ControlToValidate="txtNhaplaiMK" ErrorMessage="Nhập lại mật khẩu không được rỗng">(*)</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cv_Nhaplai" runat="server" ControlToCompare="txtMK" ControlToValidate="txtNhaplaiMK" ErrorMessage="Mật khẩu nhập lại chưa đúng">(*)</asp:CompareValidator>
                </td>
            </tr>
        </table>
        <br />
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2" style="color: #FFFFFF; background-color: #0000FF; font-weight: bold;">Chi tiết</td>
            </tr>
            <tr>
                <td class="auto-style4">Họ tên khách hàng</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtKH" runat="server" Width="690px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_KH" runat="server" ControlToValidate="txtKH" ErrorMessage="Họ tên khách hàng không được rỗng">(*)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Ngày sinh</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtNgaySinh" runat="server" Width="690px" TextMode="Date"></asp:TextBox>
                    <asp:CompareValidator ID="cv_Ngaysinh" runat="server" ControlToValidate="txtNgaySinh" ErrorMessage="Ngày sinh không hợp lệ" Operator="DataTypeCheck" Type="Date">(*)</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Giới tính</td>
                <td>
                    <asp:RadioButton ID="radNam" runat="server" Text="Nam" GroupName="gender" OnCheckedChanged="radNam_CheckedChanged" />
                    <asp:RadioButton ID="radNu" runat="server" Text="Nữ" GroupName="gender" OnCheckedChanged="radNu_CheckedChanged" />
                    
                    <asp:CustomValidator ID="cv_gender" runat="server" ErrorMessage="Gender can not be empty" OnServerValidate="cv_gender_ServerValidate" style="color: #FF0000">(*)</asp:CustomValidator>
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtEmail" runat="server" Width="690px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email không hợp lệ" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">(*)</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Thu nhập</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtThuNhap" runat="server" Width="690px"></asp:TextBox>
                    <asp:RangeValidator ID="rvThuNhap" runat="server" ControlToValidate="txtThuNhap" ErrorMessage="Thu nhập từ 1 triệu đến 50 triệu" MaximumValue="50000000" MinimumValue="1000000">(*)</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2" style="background-color: #FFFFFF; color: #000000; font-weight: bold">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2" style="background-color: #FFFFFF; color: #000000; font-weight: bold">
                    <asp:Button ID="btnDangKy" runat="server" Text="Đăng kí" OnClick="btnDangKy_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2">
                    <asp:Label ID="lblThongBao" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:ValidationSummary style="color: #FF0000; text-align: center;" ID="vsTonghop" runat="server" HeaderText="Danh sách các lỗi" />
        <br />
    </div>
    </form>
</body>
</html>

