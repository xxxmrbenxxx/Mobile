<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MobileDetails.aspx.cs" Inherits="MobileStore.MobileDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	   <asp:FormView ID="mobileDetail" runat="server"
        ItemType="MobileStore.Models.Mobile" SelectMethod ="GetDetails"
         RenderOuterTable="false">
         <ItemTemplate>
         <div>
         <h1><%#:Item.MoblieName %></h1>
         </div>
         <br />
         <table>
         <tr>
         <td>
         <img src="/Images/<%#:Item.ImagePath %>"
         style="border:solid; height:225px" alt="<%#:Item.MoblieName %>"/>
         </td>
         <td>&nbsp;</td>
         <td style="vertical-align: top; text-align:left;">
         <b>Description:</b><br /><%#:Item.Description %>
         <br />
         <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}",Item.Price)
        %></span>
         <br />
         <span><b>Book Number:</b>&nbsp;<%#:Item.MoblieID %></span>
         <br />
         </td>
         </tr>
         </table>
         </ItemTemplate>
         </asp:FormView>
</asp:Content>
