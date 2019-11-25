<%@ Page Title="List Product Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product_List.aspx.cs" Inherits="KLTN.Product" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="AddProductForm">
        <div class="container">
            <h3>Danh Sách Sản phẩm</h3>
            <div class="table-resposive">
                <%--         <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>Mã</th>
                            <th>Tên Sản Phẩm</th>
                            <th>Hạn Sử Dụng</th>
                            <th>Tên Công Ty </th>
                            <th>Năm Sản Xuất</th>
                            <th>Loại Hàng</th>
                        </tr>
                    </thead>

                    <tr>
                        <td>Mã </td>
                        <td>
                            <asp:TextBox ID="txtID" runat="server" class="form-control"></asp:TextBox>
                            <asp:Label></asp:Label>
                        </td>
                    </tr>--%>


                <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th>Mã</th>
                                    <th>Tên Sản Phẩm</th>
                                    <th>Hạn Sử Dụng</th>
                                    <th>Tên Công Ty </th>
                                    <th>Năm Sản Xuất</th>
                                    <th>Loại Hàng</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>

                    <ItemTemplate>
                        <tr>
                            <td><%# DataBinder.Eval(Container.DataItem, "ID") %> </td>
                            <td><%# DataBinder.Eval(Container.DataItem, "Name") %> </td>
                            <td><%# DataBinder.Eval(Container.DataItem, "ExpiryDate") %> </td>
                            <td><%# DataBinder.Eval(Container.DataItem, "CompanyName") %> </td>
                            <td><%# DataBinder.Eval(Container.DataItem, "Year") %> </td>
                            <td><%# DataBinder.Eval(Container.DataItem, "Category") %> </td>
                        </tr>
                    </ItemTemplate>

                    <FooterTemplate>
                        </tbody> 
                            </table>
                    </FooterTemplate>

                </asp:Repeater>

               <%-- <asp:SqlDataSource ID="SQLDataSource1"
                    ConnectionString="<%$ ConnectionStrings:KTLT%>"
                    SelectCommand="SELECT * FROM [Product]"
                    runat="server"></asp:SqlDataSource>--%>

                <%--</table>--%>
            </div>
        </div>
    </form>

</asp:Content>

