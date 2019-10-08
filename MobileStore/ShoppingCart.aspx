<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="MobileStore.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	   <div id="ShoppingCartTitle" runat="server" class="ContentHead"><h1>Giỏ Hàng</h1></div>
 <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4" ItemType="MobileStore.Models.CartItem" SelectMethod ="GetShoppingCartItems" CssClass="table table-striped table-bordered" >
 <Columns><asp:BoundField DataField="MobileID" HeaderText="ID" SortExpression="MobileID" />
 <asp:BoundField DataField="Mobile.MobileName" HeaderText="Mobile Name" />
 <asp:BoundField DataField="Mobile.Price" HeaderText="Mobile Price" DataFormatString="{0:c}"/>
 <asp:TemplateField HeaderText="Số lượng">
 <ItemTemplate>
 <asp:TextBox ID="PurchaseQuantity" Width="40" runat="server" Text="<%#: Item.Quantity %>"></asp:TextBox>
 </ItemTemplate>
 </asp:TemplateField>
 <asp:TemplateField HeaderText="Total">
 <ItemTemplate>
 <%#: String.Format("{0:c}", ((Convert.ToDouble(Item.Quantity)) * Convert.ToDouble(Item.Mobile.Price)))%>
 </ItemTemplate>
 </asp:TemplateField>
 <asp:TemplateField HeaderText="Cancel">
 <ItemTemplate>
 <asp:CheckBox id="Remove" runat="server"></asp:CheckBox>
 </ItemTemplate>
 </asp:TemplateField>
 </Columns>
</asp:GridView>
<div>
 <p></p>
 <strong>
 <asp:Label ID="LabelTotalText" runat="server" Text="Total:"></asp:Label>
 <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
 </strong>
</div>
<br />        <table>
<tr>
<td>
<asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
</td>
    <td>
</td>
</tr>
</table>
</asp:Content>
</asp:Content>
