<%@ Page Title="" Language="C#" MasterPageFile="~/NhapHangTaoBaoMaster.Master" AutoEventWireup="true" CodeBehind="chi-tiet-trang.aspx.cs" Inherits="NHST.chi_tiet_trang2" %>

<%@ Register Src="~/UC/uc_Sidebar.ascx" TagName="SideBar" TagPrefix="uc" %>
<%@ Register Src="~/UC/uc_Banner.ascx" TagName="Banner" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        p {
            text-align: initial;
        }

        .intro-page table {
            width: 100% !important;
        }
    </style>
    <style>
        .services {
            background: #f8f8f8;
        }

        .header {
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            z-index: 999;
            /* background-color: rgba(126, 31, 31, 0.5); */
            color: #fff;
            background-color: #333333;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="main">
        <div class="breadcrumb">
            <div class="container">
                <ul>
                    <li><a href="/">Trang chủ</a></li>
                    <asp:Literal runat="server" ID="ltrBread"></asp:Literal>
                </ul>
            </div>
        </div>

        <asp:Panel runat="server" ID="pnSideBar" Visible="false">
            <div class="service-page-section sec">
                <div class="container">
                    <div class="columns">
                        <div class="column left wow fadeInLeft" data-wow-duration="1s" data-wow-delay="0s">
                            <uc:SideBar ID="SideBar1" runat="server" />
                        </div>
                        <div class="column right">
                            <asp:Label runat="server" ID="lblTitle"></asp:Label>
                            <asp:Literal runat="server" ID="ltrDetail"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
        </asp:Panel>

        <asp:Panel runat="server" ID="pnFull">
            <section class="about-section sec">
                <div class="container">
                    <asp:Label runat="server" ID="lblTitleFull"></asp:Label>
                    <asp:Literal runat="server" ID="ltrContent"></asp:Literal>
                </div>
            </section>
        </asp:Panel>

    </main>
</asp:Content>
