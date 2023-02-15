<%@ Page Title="" Language="C#" MasterPageFile="~/giaothuong24hMaster.Master" AutoEventWireup="true" CodeBehind="Default7.aspx.cs" Inherits="NHST.Default4" %>

<%@ Register Src="~/UC/uc_Banner.ascx" TagName="Banner" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="home">
        <uc:Banner ID="Banner1" runat="server" />
        <div class="services">
            <div class="all">
                <div class="sec100-wrap">
                    <div class="sec40-left">
                        <div class="sec-title">
                            <h2 class="hd">Dịch vụ
                                    <br>
                                <span class="color1">Giaothuong24h.com</span></h2>
                            <%--<p>Businesses often become known today through effective marketing. The marketing...</p>--%>
                        </div>
                        <ul class="list-navct">
                            <asp:Literal ID="ltrService1" runat="server"></asp:Literal>

                        </ul>
                    </div>
                    <span class="line-devide">
                        <span class="line-top"></span>
                        <span class="line-bot"></span>
                    </span>
                    <div class="sec60-right">
                        <div class="nav-content-wrap">
                            <asp:Literal ID="ltrService2" runat="server"></asp:Literal>

                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="present">
            <div class="all">
                <ul class="ps-wrap">
                    <li class="ps__child">
                        <div class="present-card">
                            <div class="img">
                                <img src="/App_Themes/giaothuong24h/images/present-icon1.png" alt="">
                            </div>
                            <div class="ct">
                                <h4 class="hd">10</h4>
                                <p class="sub-hd">Năm kinh nghiệm</p>
                            </div>
                        </div>
                    </li>
                    <li class="ps__child">
                        <div class="present-card">
                            <div class="img">
                                <img src="/App_Themes/giaothuong24h/images/present-icon2.png" alt="">
                            </div>
                            <div class="ct">
                                <h4 class="hd">12,345</h4>
                                <p class="sub-hd">Khách hàng</p>
                            </div>
                        </div>
                    </li>
                    <li class="ps__child">
                        <div class="present-card">
                            <div class="img">
                                <img src="/App_Themes/giaothuong24h/images/present-icon3.png" alt="">
                            </div>
                            <div class="ct">
                                <h4 class="hd">67,890</h4>
                                <p class="sub-hd">Đơn hàng</p>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>

        <div class="step-order">
            <div class="all">
                <div class="sec100-wrap">
                    <div class="sec40-left">
                        <div class="sec-title">
                            <h2 class="hd">Quy trình đặt hàng</h2>
                        </div>
                        <ul class="list-navct">
                            <asp:Literal ID="ltrStep1" runat="server"></asp:Literal>

                        </ul>
                    </div>
                    <span class="line-devide">
                        <span class="line-top"></span>
                        <span class="line-bot"></span>
                    </span>
                    <div class="sec60-right">
                        <div class="nav-content-wrap">
                            <asp:Literal ID="ltrStep2" runat="server"></asp:Literal>

                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="benefits">
            <div class="all">
                <div class="sec-title">
                    <h2 class="hd">Quyền lợi của
                            <br>
                        khách hàng</h2>

                </div>
                <ul class="list-benefits">
                    <asp:Literal ID="ltrQL1" runat="server"></asp:Literal>

                </ul>
            </div>
        </div>
        <div class="contact-info">
            <div class="all">
                <div class="sec-title">
                    <h2 class="hd">Thông tin liên hệ</h2>
                </div>
                <ul class="list-ct-info">
                    <li class="ct-info__item">
                        <div class="ct-info-card">
                            <div class="icon">
                                <span class="icon-circle"><i class="fas fa-map-marker-alt"></i></span>
                            </div>
                            <div class="ct">
                                <p class="tt">Địa chỉ:</p>
                                <asp:Literal ID="ltrFooterAddress" runat="server"></asp:Literal>

                            </div>
                        </div>
                    </li>
                    <li class="ct-info__item">
                        <div class="ct-info-card">
                            <div class="icon">
                                <span class="icon-circle"><i class="fas fa-phone"></i></span>
                            </div>
                            <div class="ct">
                                <p class="tt">Hotline:</p>
                                <asp:Literal ID="ltrFooterHotline" runat="server"></asp:Literal>
                                <%--<p><a href="tel:+">0126.922.0162</a></p>--%>
                            </div>
                        </div>
                    </li>
                    <li class="ct-info__item">
                        <div class="ct-info-card">
                            <div class="icon">
                                <span class="icon-circle"><i class="far fa-clock"></i></span>
                            </div>
                            <div class="ct">
                                <p class="tt">Giờ hoạt động:</p>
                                <asp:Literal ID="ltrFooterTimework" runat="server"></asp:Literal>
                                <%-- <p>08:30am - 06:30 pm</p>--%>
                            </div>
                        </div>
                    </li>
                    <li class="ct-info__item">
                        <div class="ct-info-card">
                            <div class="icon">
                                <span class="icon-circle"><i class="fas fa-envelope"></i></span>
                            </div>
                            <div class="ct">
                                <p class="tt">Email:</p>
                                <asp:Literal ID="ltrFooterEmail" runat="server"></asp:Literal>
                                <%--<p><a href="mailto:">admin@support.com</a></p>--%>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </main>
    <script type="text/javascript">
        function keyclose_ms(e) {
            if (e.keyCode == 27) {
                close_popup_ms();
            }
        }
        function close_popup_ms() {
            $("#pupip_home").animate({ "opacity": 0 }, 400);
            $("#bg_popup_home").animate({ "opacity": 0 }, 400);
            setTimeout(function () {
                $("#pupip_home").remove();
                $(".zoomContainer").remove();
                $("#bg_popup_home").remove();
                $('body').css('overflow', 'auto').attr('onkeydown', '');
            }, 500);
        }
        function closeandnotshow() {
            $.ajax({
                type: "POST",
                url: "/Default.aspx/setNotshow",
                //data: "{ID:'" + id + "',UserName:'" + username + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    close_popup_ms();
                },
                error: function (xmlhttprequest, textstatus, errorthrow) {
                    alert('lỗi');
                }
            });

        }
        $(document).ready(function () {
            $.ajax({
                type: "POST",
                url: "/Default.aspx/getPopup",
                //data: "{ID:'" + id + "',UserName:'" + username + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    if (msg.d != "null") {
                        var data = JSON.parse(msg.d);
                        var title = data.NotiTitle;
                        var content = data.NotiContent;
                        var email = data.NotiEmail;
                        var obj = $('form');
                        $(obj).css('overflow', 'hidden');
                        $(obj).attr('onkeydown', 'keyclose_ms(event)');
                        var bg = "<div id='bg_popup_home'></div>";
                        var fr = "<div id='pupip_home' class=\"columns-container1\">" +
                            "  <div class=\"center_column col-xs-12 col-sm-5\" id=\"popup_content_home\">";
                        fr += "<div class=\"popup_header\">";
                        fr += title;
                        fr += "<a style='cursor:pointer;right:5px;' onclick='close_popup_ms()' class='close_message'></a>";
                        fr += "</div>";
                        fr += "     <div class=\"changeavatar\">";
                        fr += "         <div class=\"content1\">";
                        fr += content;
                        fr += "         </div>";
                        fr += "         <div class=\"content2\">";
                        fr += "<a href=\"javascript:;\" class=\"btn btn-close-full\" onclick='closeandnotshow()'>Đóng & không hiện thông báo</a>";
                        fr += "<a href=\"javascript:;\" class=\"btn btn-close\" onclick='close_popup_ms()'>Đóng</a>";
                        fr += "         </div>";
                        fr += "     </div>";
                        fr += "<div class=\"popup_footer\">";
                        fr += "<span class=\"float-right\">" + email + "</span>";
                        fr += "</div>";

                        fr += "   </div>";
                        fr += "</div>";
                        $(bg).appendTo($(obj)).show().animate({ "opacity": 0.7 }, 800);
                        $(fr).appendTo($(obj));
                        setTimeout(function () {
                            $('#pupip').show().animate({ "opacity": 1, "top": 20 + "%" }, 200);
                            $("#bg_popup").attr("onclick", "close_popup_ms()");
                        }, 1000);
                    }
                },
                error: function (xmlhttprequest, textstatus, errorthrow) {
                    alert('lỗi');
                }
            });
        });
    </script>
    <style>
        #bg_popup_home {
            position: fixed;
            width: 100%;
            height: 100%;
            background-color: #333;
            opacity: 0.7;
            filter: alpha(opacity=70);
            left: 0px;
            top: 0px;
            z-index: 999999999;
            opacity: 0;
            filter: alpha(opacity=0);
        }

        #popup_ms_home {
            background: #fff;
            border-radius: 0px;
            box-shadow: 0px 2px 10px #fff;
            float: left;
            position: fixed;
            width: 735px;
            z-index: 10000;
            left: 50%;
            margin-left: -370px;
            top: 200px;
            opacity: 0;
            filter: alpha(opacity=0);
            height: 360px;
        }

            #popup_ms_home .popup_body {
                border-radius: 0px;
                float: left;
                position: relative;
                width: 735px;
            }

            #popup_ms_home .content {
                /*background-color: #487175;     border-radius: 10px;*/
                margin: 12px;
                padding: 15px;
                float: left;
            }

            #popup_ms_home .title_popup {
                /*background: url("../images/img_giaoduc1.png") no-repeat scroll -200px 0 rgba(0, 0, 0, 0);*/
                color: #ffffff;
                font-family: Arial;
                font-size: 24px;
                font-weight: bold;
                height: 35px;
                margin-left: 0;
                margin-top: -5px;
                padding-left: 40px;
                padding-top: 0;
                text-align: center;
            }

            #popup_ms_home .text_popup {
                color: #fff;
                font-size: 14px;
                margin-top: 20px;
                margin-bottom: 20px;
                line-height: 20px;
            }

                #popup_ms_home .text_popup a.quen_mk, #popup_ms_home .text_popup a.dangky {
                    color: #FFFFFF;
                    display: block;
                    float: left;
                    font-style: italic;
                    list-style: -moz-hangul outside none;
                    margin-bottom: 5px;
                    margin-left: 110px;
                    -webkit-transition-duration: 0.3s;
                    -moz-transition-duration: 0.3s;
                    transition-duration: 0.3s;
                }

                    #popup_ms_home .text_popup a.quen_mk:hover, #popup_ms_home .text_popup a.dangky:hover {
                        color: #8cd8fd;
                    }

            #popup_ms_home .close_popup {
                background: url("/App_Themes/Camthach/images/close_button.png") no-repeat scroll 0 0 rgba(0, 0, 0, 0);
                display: block;
                height: 28px;
                position: absolute;
                right: 0px;
                top: 5px;
                width: 26px;
                cursor: pointer;
                z-index: 10;
            }

        #popup_content_home {
            height: auto;
            position: fixed;
            background-color: #fff;
            top: 15%;
            z-index: 999999999;
            left: 25%;
            border-radius: 10px;
            -moz-border-radius: 10px;
            -webkit-border-radius: 10px;
            width: 50%;
            padding: 20px;
        }

        #popup_content_home {
            padding: 0;
        }

        .popup_header, .popup_footer {
            float: left;
            width: 100%;
            background: #29aae1;
            padding: 10px;
            position: relative;
            color: #fff;
        }

        .popup_header {
            font-weight: bold;
            font-size: 16px;
            text-transform: uppercase;
        }

        .close_message {
            top: 10px;
        }

        .changeavatar {
            padding: 10px;
            margin: 5px 0;
            float: left;
            width: 100%;
        }

        .float-right {
            float: right;
        }

        .content1 {
            float: left;
            width: 100%;
        }

        .content2 {
            float: left;
            width: 100%;
            border-top: 1px solid #eee;
            clear: both;
            margin-top: 10px;
        }

        .btn.btn-close {
            float: right;
            background: #29aae1;
            color: #fff;
            margin: 10px 5px;
            text-transform: none;
            padding: 10px 20px;
        }

            .btn.btn-close:hover {
                background: #1f85b1;
            }

        .btn.btn-close-full {
            float: right;
            background: #7bb1c7;
            color: #fff;
            margin: 10px 5px;
            text-transform: none;
            padding: 10px 20px;
        }

            .btn.btn-close-full:hover {
                background: #6692a5;
            }
    </style>
</asp:Content>
