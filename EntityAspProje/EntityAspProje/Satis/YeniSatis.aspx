<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniSatis.aspx.cs" Inherits="EntityAspProje.Satis.YeniSatis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        Ürün Seçin
        <div>
            <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <br />
        Müşteri Seçin
        <div>
            <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <br />
        Personel Seçin
        <div>
            <asp:DropDownList ID="DropDownList3" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <br />
        Fiyat
        <div>
            <asp:TextBox ID="txtFiyat" runat="server" placeholder="Ürün Fiyatını Giriniz..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürün Ekle" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
