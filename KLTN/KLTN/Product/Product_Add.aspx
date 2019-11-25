<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product_Add.aspx.cs" Inherits="KLTN.Product" %>--%>
<%@ Page Title="Add Product Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product_Add.aspx.cs" Inherits="KLTN.Product" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="AddProductForm">
        <div style="margin: 0px auto; padding-left: 370px; padding-right: 30px; overflow: auto;">
            <div class="table-resposive">
                <table class="table">
                    <tr>
                        <td colspan="2" style="background-color: Green; height: 30px; color: White;" align="center">Thêm Sản phẩm
                        </td>
                    </tr>
                    <tr>
                        <td>Mã </td>
                        <td>
                            <asp:TextBox ID="txtID" Width="150px" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                    <tr>
                        <td>Tên </td>
                        <td>
                            <asp:TextBox ID="txtName" Width="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Hạn Sử Dụng </td>
                        <td>
                            <asp:TextBox TextMode="DateTime" ID="txtExpiryDate" Width="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Tên Công Ty </td>
                        <td>
                            <asp:TextBox ID="txtCompany" Width="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Năm Sản Xuất   </td>
                        <td>
                            <asp:TextBox ID="txtYear" Width="150px" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorYear"
                                ControlToValidate="txtYear" runat="server"
                                ErrorMessage="Only Numbers allowed"
                                ValidationExpression="\d+">
                            </asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Loại Hàng  </td>
                        <td>
                            <asp:TextBox ID="txtCategory" Width="150px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Button ID="BtnSave" runat="server" Width="100px" Text="Save" OnClick="BtnSave_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>

</asp:Content>

