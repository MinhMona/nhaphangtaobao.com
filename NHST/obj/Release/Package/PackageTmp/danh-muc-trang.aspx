<%@ Page Title="" Language="C#" MasterPageFile="~/NhapHangTaoBaoMaster.Master" AutoEventWireup="true" CodeBehind="danh-muc-trang.aspx.cs" Inherits="NHST.danh_muc_trang1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .services {
            background: #f8f8f8;
        }

        .services-content {
            float: right;
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
        <div class="breadcrumb wow fadeIn" data-wow-duration="1s" data-wow-delay="0s">
            <div class="container">
                <ul>
                    <li><a href="/">Trang chủ</a></li>
                    <li>
                        <asp:Literal runat="server" ID="ltrbre"></asp:Literal></li>
                </ul>
            </div>
        </div>
        <div class="service-page-section sec">
            <div class="container">
                <div class="columns">
                    <div class="column left wow fadeInLeft" data-wow-duration="1s" data-wow-delay="0s">
                        <div class="sidebar">
                            <div class="sidebar">
                                <p class="sidebar-title">DANH MỤC</p>
                                <div class="sidebar-list-item">
                                    <div class="sidebar-item">
                                        <asp:Literal runat="server" ID="ltrCategory"></asp:Literal>
                                        <ul class="sidebar-item-nav">
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class="column right wow fadeInRight" data-wow-duration="1s" data-wow-delay="0s">
                        <section class="price-section">
                            <asp:Literal runat="server" ID="ltrTitle"></asp:Literal>
                            <div class="">
                                <asp:Literal runat="server" ID="ltrDetail"></asp:Literal>
                            </div>
                            <div class="guide-list">
                                <div class="columns">
                                    <asp:Literal runat="server" ID="ltrList"></asp:Literal>
                                </div>
                            </div>
                        </section>
                    </div>
                </div>
            </div>
        </div>

    </main>
</asp:Content>
