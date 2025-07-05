﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniUrun.aspx.cs" Inherits="EntityAspProje.Urun.YeniUrun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   
    <form runat="server" class="form-group">
        <div>
            <asp:TextBox ID="TxtUrunAd" runat="server" placeholder="Ürün Adını Girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:TextBox ID="TxtMarka" runat="server" placeholder="Markayı Girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <br />

        <div>
            <asp:TextBox ID="TxtFiyat" runat="server" placeholder="Fiyatı Girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:TextBox ID="TxtStok" runat="server" placeholder="Stok Sayısı..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />

          <div>
              <asp:Button ID="Button1" runat="server" Text="Ürün Ekle" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>





</asp:Content>
